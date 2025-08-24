using AgendaWF.DAL;
using AgendaWF.Models;

namespace AgendaWF;

public partial class UI_Agenda : Form
{
    public UI_Agenda()
    {
        InitializeComponent();
    }

    #region ----- Variáveis diversas -----
    List<Contato> contatos = new List<Contato>();
    #endregion ----- Variáveis diversas ----- 

    #region ----- Rotinas -----
    private void Inicia_Forms()
    {
        try
        {
            Dal_Agenda.CreateDB();
            Dal_Agenda.CreateTableSQLite();

            Util.ArredondarBotao(bt_Adicionar, 15);
            Util.ArredondarBotao(bt_Excluir, 15);
            Util.ArredondarBotao(bt_Pesquisar, 15);

            dg_Contatos.AutoGenerateColumns = false;

            Exibe_Contatos();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erro: " + ex.Message);
        }
    }

    private void Limpa_Campos()
    {
        dg_Contatos.DataSource = null;

        txt_ID.Clear();
        txt_Nome.Clear();
        txt_Email.Clear();
        mk_Telefone.Clear();

        lb_Qtd_Registros.Text = "Quantidade de registros: " + dg_Contatos.Rows.Count;
    }

    private void Exibe_Contatos()
    {
        try
        {
            Contato contato = new Contato();

            contato.Id = Util.Verifica_Int(txt_ID.Text);
            contato.Nome = txt_Nome.Text;
            contato.Email = txt_Email.Text;

            dg_Contatos.DataSource = Dal_Agenda.GetContacts(contato);

            lb_Qtd_Registros.Text = "Quantidade de registros: " + dg_Contatos.Rows.Count;
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erro: " + ex.Message);
        }
    }

    private void Adicionar_Contato()
    {
        try
        {
            if (txt_Nome.Text == string.Empty)
            {
                MessageBox.Show("O nome do contato é obrigatório!");
                txt_Nome.Focus();
                return;
            }

            if (Util.Configura_String(mk_Telefone.Text) != string.Empty &&
                Util.Configura_String(mk_Telefone.Text).Length < 10)
            {
                MessageBox.Show("Número de telefone inválido!");
                mk_Telefone.Focus();
                return;
            }

            Contato contato = new Contato();

            contato.Id = Util.Verifica_Int(txt_ID.Text);
            contato.Nome = txt_Nome.Text.TrimStart().TrimEnd();
            contato.Email = txt_Email.Text.TrimStart().TrimEnd();

            if (Util.Configura_String(mk_Telefone.Text) != string.Empty)
            {
                contato.DDD = Util.Configura_String(mk_Telefone.Text).Substring(0, 2);
                contato.Telefone = Util.Configura_String(mk_Telefone.Text).Substring(2, 8);
            }

            Dal_Agenda.AddContact(contato);

            MessageBox.Show("Contato adicionado com sucesso!");

            Limpa_Campos();
            Exibe_Contatos();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erro: " + ex.Message);
        }
    }

    private void Deletar_Contato()
    {
        try
        {
            if (dg_Contatos.Rows.Count == 0)
                return;

            Dal_Agenda.DeleteContact(Util.Verifica_Int(dg_Contatos.Rows[dg_Contatos.CurrentRow.Index].Cells["col_ID"].Value.ToString()));

            MessageBox.Show("Contato excluído com sucesso!");

            Limpa_Campos();
            Exibe_Contatos();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erro: " + ex.Message);
        }
    }
    #endregion ----- Rotinas -----

    #region ----- Forms -----
    private void UI_Agenda_Load(object sender, EventArgs e)
    {
        Inicia_Forms();
    }

    private void UI_Agenda_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.F1)
            Limpa_Campos();

        if (e.KeyCode == Keys.F5)
            Exibe_Contatos();
    }

    private void UI_Agenda_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (txt_ID.Focused == true)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Bloqueia caracteres não numéricos
            }
        }
    }
    #endregion ----- Forms -----

    #region ----- Buttons -----
    private void bt_Adicionar_Click(object sender, EventArgs e)
    {
        Adicionar_Contato();
    }

    private void bt_Pesquisar_Click(object sender, EventArgs e)
    {
        Exibe_Contatos();
    }

    private void bt_Excluir_Click(object sender, EventArgs e)
    {
        Deletar_Contato();
    }
    #endregion ----- Buttons -----

    #region ----- DataGrid -----
    private void dg_Contatos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
    {
        if (dg_Contatos.Rows.Count == 0)
            return;

        txt_ID.Text = dg_Contatos.Rows[dg_Contatos.CurrentRow.Index].Cells["col_ID"].Value?.ToString();
        txt_Nome.Text = dg_Contatos.Rows[dg_Contatos.CurrentRow.Index].Cells["col_Nome"].Value?.ToString();
        txt_Email.Text = dg_Contatos.Rows[dg_Contatos.CurrentRow.Index].Cells["col_Email"].Value?.ToString();
        mk_Telefone.Text = dg_Contatos.Rows[dg_Contatos.CurrentRow.Index].Cells["col_Telefone"].Value?.ToString();
    }
    #endregion ----- DataGrid -----
}