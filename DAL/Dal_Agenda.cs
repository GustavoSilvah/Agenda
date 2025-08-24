using System.Data;
using System.Data.SQLite;
using AgendaWF.Models;

namespace AgendaWF.DAL;

public class Dal_Agenda
{
    public static string path = Directory.GetCurrentDirectory() + "\\BD_Agenda.sqlite";

    private static SQLiteConnection sqliteConnection;

    private static SQLiteConnection DBConnection()
    {
        sqliteConnection = new SQLiteConnection("Data Source=" + path);
        sqliteConnection.Open();
        return sqliteConnection;
    }

    public static void CreateDB()
    {
        try
        {
            if (File.Exists(path) == false)
                SQLiteConnection.CreateFile(path);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public static void CreateTableSQLite()
    {
        try
        {
            using (var cmd = DBConnection().CreateCommand())
            {
                cmd.CommandText =
                    @"CREATE TABLE IF NOT EXISTS Contatos(
                        Id integer primary key, 
                        Nome Varchar(50), 
                        Email Varchar(80),
                        DDD char(2),
                        Telefone Varchar(8)
                    )";
                cmd.ExecuteNonQuery();
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public static DataTable Get()
    {
        SQLiteDataAdapter da = null;
        DataTable dt = new DataTable();

        try
        {
            using (var cmd = DBConnection().CreateCommand())
            {
                cmd.CommandText = "SELECT Id, Nome, Email, DDD, Telefone FROM Contatos ";
                da = new SQLiteDataAdapter(cmd.CommandText, DBConnection());
                da.Fill(dt);

                return dt;
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
    
    public static DataTable GetContacts(Contato contato)
    {
        SQLiteDataAdapter da = null;
        DataTable dt = new DataTable();

        try
        {
            using (var cmd = DBConnection().CreateCommand())
            {
                cmd.CommandText = "SELECT Id, Nome, Email, ";
                cmd.CommandText += "'(' || DDD || ')' || ' ' || SUBSTR(Telefone, 0, 5) || '-' || SUBSTR(Telefone, 5, 8) AS Telefone ";
                cmd.CommandText += "FROM Contatos ";
                cmd.CommandText += "WHERE NOT Id IS NULL ";
                
                if (contato.Id > 0)
                    cmd.CommandText += "AND Id = " + contato.Id + " ";
                
                if (contato.Nome != string.Empty)
                    cmd.CommandText += "AND Nome LIKE '%" + contato.Nome + "%' ";
                
                if (contato.Email != string.Empty)
                    cmd.CommandText += "AND Email LIKE '%" + contato.Email + "%' ";
                
                da = new SQLiteDataAdapter(cmd.CommandText, DBConnection());
                da.Fill(dt);

                return dt;
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public static void AddContact(Contato contato)
    {
        try
        {
            using (var cmd = DBConnection().CreateCommand())
            {
                if (contato.Id == 0)
                {
                    cmd.CommandText = "INSERT INTO Contatos(Nome, Email, DDD, Telefone) VALUES (@Nome, @Email, @DDD, @Telefone)";
                    cmd.Parameters.AddWithValue("@Nome", contato.Nome);
                    cmd.Parameters.AddWithValue("@Email", contato.Email);
                    cmd.Parameters.AddWithValue("@DDD", contato.DDD);
                    cmd.Parameters.AddWithValue("@Telefone", contato.Telefone);
                }
                else
                {
                    cmd.CommandText = "UPDATE Contatos SET Nome = @Nome, Email = @Email, DDD = @DDD, Telefone = @Telefone WHERE Id = @Id";
                    cmd.Parameters.AddWithValue("@Id", contato.Id);
                    cmd.Parameters.AddWithValue("@Nome", contato.Nome);
                    cmd.Parameters.AddWithValue("@Email", contato.Email);
                    cmd.Parameters.AddWithValue("@DDD", contato.DDD);
                    cmd.Parameters.AddWithValue("@Telefone", contato.Telefone);
                }
                
                cmd.ExecuteNonQuery();
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public static void DeleteContact(int id)
    {
        try
        {
            using (var cmd = DBConnection().CreateCommand())
            {
                cmd.CommandText = "DELETE FROM Contatos WHERE Id = @Id";
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
}