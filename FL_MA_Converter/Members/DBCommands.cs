using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FL_MA_Converter
{
    public static class DBCommands
    {
        #region Conniction

        private static SqlConnection conn = new SqlConnection(
            @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\myDB.mdf;
            Integrated Security=True");

        public static void TestConn()
        {
            try
            {
                conn.Open();
                conn.Close();
            }
            catch
            {
                MessageBox.Show("فشل الإتصال بقاعدة البيانات", "فشل", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void OpenConn()
        {
            try
            {
                conn.Open();
            }
            catch
            {
                MessageBox.Show("فشل الإتصال بقاعدة البيانات", "فشل", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        public static void CloseConn()
        {
            try
            {
                conn.Close();
            }
            catch
            {
                MessageBox.Show("فشل الإتصال بقاعدة البيانات", "فشل", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        #endregion

        #region Commands

        public static List<WordsDB> Get_WordsW(string word)
        {
            List<WordsDB> Words = new List<WordsDB>();

            string sql = "SELECT * FROM Words WHERE ManaID=(SELECT ManaID FROM Words WHERE Word=N'" + word + "')";

            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                Words.Add(new WordsDB(Convert.ToInt32(r[0]), r[1].ToString()));
            }

            r.Close();

            return Words;
        }

        public static string GetDes(int ID)
        {
            SqlCommand cmd = new SqlCommand("SELECT Des FROM [Mana] WHERE Id=" + ID, conn);

            return (string)cmd.ExecuteScalar();
        }

        public static List<WordsDB> Get_WordsI(int ID)
        {
            List<WordsDB> w = new List<WordsDB>();

            SqlCommand cmd = new SqlCommand("SELECT Word FROM [Words] WHERE ManaID=" + ID, conn);
            SqlDataReader r = cmd.ExecuteReader();

            while (r.Read())
            {
                w.Add(new WordsDB(ID, r[0].ToString()));
            }

            r.Close();

            return w;
        }

        public static int Get_Max_ID()
        {
            SqlCommand cmd = new SqlCommand("SELECT ISNULL(MAX(Id), 0) FROM [Mana]", conn);

            return (int)cmd.ExecuteScalar();
        }

        public static int SaveInsert(string Des, string[] theWords)
        {
            int id = Get_Max_ID() + 1;
            // Add The Mana
            SqlCommand AddMana = new SqlCommand("INSERT INTO Mana(Id, Des) VALUES(" + id
                + ", N'" + Des + "')", conn);
            try
            {
                AddMana.ExecuteNonQuery();
            }
            catch
            {
                return 1;
            }

            // Insert Words
            string cmd = "";
            for(int i = 0, n = theWords.Length; i < n; i++)
            {
                cmd += "INSERT INTO Words(ManaID, Word) Values(" + id + ", N'" + theWords[i] + "');\n";
            }

            SqlCommand AddWords = new SqlCommand(cmd, conn);

            try
            {
                AddWords.ExecuteNonQuery();
            }
            catch
            {
                return 2;
            }

            return 0;
        }

        public static int SaveUpdate(int ID, string Des, List<Words> w)
        {
            // Update Des
            SqlCommand Update = new SqlCommand("UPDATE Mana SET Des=N'" + Des + "' WHERE Id=" + ID + "", conn);
            try
            {
                Update.ExecuteNonQuery();
            }
            catch
            {
                return 1;
            }

            // Words
            string cmd = "";
            foreach (Words ww in w)
            {
                if(ww.Type == 'D')
                {
                    // Delete
                    cmd += "DELETE FROM Words WHERE Word=N'" + ww.Text + "' AND ManaID=" + ID + ";\n";
                }
                else if(ww.Type == 'N')
                {
                    cmd += "INSERT INTO Words(ManaID, Word) Values(" + ID + ", N'" + ww.Text + "');\n";
                }
            }

            SqlCommand Add = new SqlCommand(cmd, conn);
            try
            {
                Add.ExecuteNonQuery();
            }
            catch
            {
                return 2;
            }

            return 0;
        }

        public static int DeleteMana(int ID)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM Words WHERE ManaID=" + ID
                + ";\nDELETE FROM Mana WHERE Id=" + ID + ";", conn);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                return 1;
            }

            return 0;
        }

        public static List<int> GetIDs()
        {
            SqlCommand cmd = new SqlCommand("SELECT Id FROM Mana", conn);

            List<int> Res = new List<int>();

            SqlDataReader r = cmd.ExecuteReader();

            while (r.Read())
            {
                Res.Add(Convert.ToInt32(r[0]));
            }

            r.Close();

            return Res;
        }

        #endregion
    }
}
