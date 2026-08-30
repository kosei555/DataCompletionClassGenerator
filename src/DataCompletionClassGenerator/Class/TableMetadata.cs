using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Data;

namespace DataCompletionClassGenerator.Class
{
    internal class TableMetadata                        //テーブルメタデータを保存し、キャッシュとして活用されるクラス
    {
        // #####struct宣言#####
        //テーブル単位のスキーマ
        private struct tableSchema
        {
            public string tableName;                    //テーブル名
            public Dictionary<string, int> columnIndex; //カラム名からインデックスを検索するためのDictionary
            public columnSchema[] columns;              //テーブルに属するカラムのスキーマ
        }
        //カラム単位のスキーマ
        private struct columnSchema
        {
            public string columnName;                   //カラム名
            public OdbcType oType;                      //カラムのデータ型(ODBC)
        }

        //#####メンバ変数宣言#####
        private tableSchema[] _ts;                      //テーブルスキーマ
        private Dictionary<string, int> _tableIndex;    //テーブル名からインデックスを検索するためのDictionary

        //#####メソッド#####
        public TableMetadata(OdbcConnection conn)       //指定したodbcデータソースのテーブル情報、フィールド情報を取得し、キャッシュする。
        {
            string[] tableName = GetTableName(conn);
            _ts = new tableSchema[tableName.Length];
            _tableIndex=new Dictionary<string, int>();
            for (int i = 0; i < tableName.Length; i++)
            {
                _tableIndex[tableName[i]] = i;
                _ts[i] = new tableSchema
                {
                    tableName = tableName[i],
                    columnIndex = new Dictionary<string, int>(),
                    columns = GetColumnSchema(conn, tableName[i])
                };
                for (int j = 0; j < _ts[i].columns.Length; j++)
                {
                    _ts[i].columnIndex.Add(_ts[i].columns[j].columnName, j);
                }
            }
        }
        public string[] GetTableNames()                 //すべてのテーブル名取得
        {
            return _ts.Select(data => data.tableName).ToArray();
        }
        public string[] GetColumnNames(string tableName)//テーブル属しているすべてのカラム名取得
        {
            return _ts[_tableIndex[tableName]].columns.Select(data => data.columnName).ToArray();
        }
        public OdbcType GetColumnOdbcType(string tableName,string columnName)//カラムのデータ型取得
        {
            tableSchema table;
            table = _ts[_tableIndex[tableName]];
            return table.columns[table.columnIndex[columnName]].oType;
        }

        //テーブル情報取一括取得
        private string[] GetTableName(OdbcConnection conn)
        {
            DataTable dt = conn.GetSchema("Tables");
            return dt.Rows.Cast<DataRow>().Select(row => row["TABLE_NAME"].ToString()).ToArray();
        }
        //カラム情報取一括取得
        private columnSchema[] GetColumnSchema(OdbcConnection conn,string targetTableName)
        {
            columnSchema[] res;
            using (OdbcCommand cmd=new OdbcCommand("SELECT * FROM "+targetTableName,conn))
            {
                using (OdbcDataReader reader=cmd.ExecuteReader(System.Data.CommandBehavior.SchemaOnly))
                {
                    DataTable schema = reader.GetSchemaTable();
                    res = schema.Rows
                        .Cast<DataRow>()
                        .Select(row => new columnSchema
                        {
                            columnName = row["ColumnName"].ToString(),
                            oType = (OdbcType)(row["ProviderType"])
                        })
                        .ToArray();
                }
            }
            return res;
        }
    }
}
