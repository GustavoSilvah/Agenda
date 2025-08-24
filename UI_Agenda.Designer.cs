namespace AgendaWF;

partial class UI_Agenda
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        DataGridViewCellStyle dataGridViewCellStyle20 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle19 = new DataGridViewCellStyle();
        label1 = new Label();
        txt_ID = new TextBox();
        txt_Nome = new TextBox();
        label2 = new Label();
        txt_Email = new TextBox();
        label3 = new Label();
        bt_Adicionar = new Button();
        dg_Contatos = new DataGridView();
        col_ID = new DataGridViewTextBoxColumn();
        col_Nome = new DataGridViewTextBoxColumn();
        col_Email = new DataGridViewTextBoxColumn();
        col_Telefone = new DataGridViewTextBoxColumn();
        bt_Excluir = new Button();
        bt_Pesquisar = new Button();
        lb_Qtd_Registros = new Label();
        mk_Telefone = new MaskedTextBox();
        label4 = new Label();
        label5 = new Label();
        label6 = new Label();
        ((System.ComponentModel.ISupportInitialize)dg_Contatos).BeginInit();
        SuspendLayout();
        // 
        // label1
        // 
        label1.ForeColor = SystemColors.ControlText;
        label1.Location = new Point(7, 22);
        label1.Name = "label1";
        label1.Size = new Size(35, 19);
        label1.TabIndex = 0;
        label1.Text = "Cód.";
        // 
        // txt_ID
        // 
        txt_ID.BackColor = SystemColors.Window;
        txt_ID.BorderStyle = BorderStyle.FixedSingle;
        txt_ID.Location = new Point(7, 37);
        txt_ID.Name = "txt_ID";
        txt_ID.Size = new Size(55, 23);
        txt_ID.TabIndex = 1;
        txt_ID.TabStop = false;
        txt_ID.TextAlign = HorizontalAlignment.Center;
        // 
        // txt_Nome
        // 
        txt_Nome.BorderStyle = BorderStyle.FixedSingle;
        txt_Nome.Location = new Point(68, 37);
        txt_Nome.Name = "txt_Nome";
        txt_Nome.Size = new Size(333, 23);
        txt_Nome.TabIndex = 2;
        // 
        // label2
        // 
        label2.ForeColor = SystemColors.ControlText;
        label2.Location = new Point(68, 22);
        label2.Name = "label2";
        label2.Size = new Size(47, 19);
        label2.TabIndex = 2;
        label2.Text = "Nome";
        // 
        // txt_Email
        // 
        txt_Email.BorderStyle = BorderStyle.FixedSingle;
        txt_Email.Location = new Point(407, 37);
        txt_Email.Name = "txt_Email";
        txt_Email.Size = new Size(299, 23);
        txt_Email.TabIndex = 3;
        // 
        // label3
        // 
        label3.ForeColor = SystemColors.ControlText;
        label3.Location = new Point(407, 22);
        label3.Name = "label3";
        label3.Size = new Size(47, 19);
        label3.TabIndex = 4;
        label3.Text = "E-mail";
        // 
        // bt_Adicionar
        // 
        bt_Adicionar.BackColor = Color.YellowGreen;
        bt_Adicionar.FlatAppearance.BorderColor = Color.YellowGreen;
        bt_Adicionar.FlatStyle = FlatStyle.Flat;
        bt_Adicionar.ForeColor = SystemColors.Window;
        bt_Adicionar.Location = new Point(818, 29);
        bt_Adicionar.Name = "bt_Adicionar";
        bt_Adicionar.Size = new Size(80, 31);
        bt_Adicionar.TabIndex = 6;
        bt_Adicionar.TabStop = false;
        bt_Adicionar.Text = "Adicionar";
        bt_Adicionar.UseVisualStyleBackColor = false;
        bt_Adicionar.Click += bt_Adicionar_Click;
        // 
        // dg_Contatos
        // 
        dg_Contatos.AllowUserToAddRows = false;
        dg_Contatos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dg_Contatos.BackgroundColor = SystemColors.Control;
        dg_Contatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dg_Contatos.Columns.AddRange(new DataGridViewColumn[] { col_ID, col_Nome, col_Email, col_Telefone });
        dg_Contatos.Location = new Point(7, 66);
        dg_Contatos.MultiSelect = false;
        dg_Contatos.Name = "dg_Contatos";
        dg_Contatos.RowHeadersVisible = false;
        dataGridViewCellStyle20.SelectionBackColor = SystemColors.Highlight;
        dg_Contatos.RowsDefaultCellStyle = dataGridViewCellStyle20;
        dg_Contatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dg_Contatos.Size = new Size(889, 390);
        dg_Contatos.TabIndex = 7;
        dg_Contatos.Text = "dataGridView1";
        dg_Contatos.CellMouseDoubleClick += dg_Contatos_CellMouseDoubleClick;
        // 
        // col_ID
        // 
        col_ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        col_ID.DataPropertyName = "Id";
        dataGridViewCellStyle16.ForeColor = SystemColors.ControlText;
        col_ID.DefaultCellStyle = dataGridViewCellStyle16;
        col_ID.HeaderText = "CÓD.";
        col_ID.Name = "col_ID";
        col_ID.ReadOnly = true;
        col_ID.Width = 60;
        // 
        // col_Nome
        // 
        col_Nome.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        col_Nome.DataPropertyName = "Nome";
        dataGridViewCellStyle17.ForeColor = SystemColors.ControlText;
        col_Nome.DefaultCellStyle = dataGridViewCellStyle17;
        col_Nome.HeaderText = "NOME";
        col_Nome.Name = "col_Nome";
        col_Nome.ReadOnly = true;
        col_Nome.Width = 67;
        // 
        // col_Email
        // 
        col_Email.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        col_Email.DataPropertyName = "Email";
        dataGridViewCellStyle18.ForeColor = SystemColors.ControlText;
        col_Email.DefaultCellStyle = dataGridViewCellStyle18;
        col_Email.HeaderText = "E-MAIL";
        col_Email.Name = "col_Email";
        col_Email.ReadOnly = true;
        col_Email.Width = 71;
        // 
        // col_Telefone
        // 
        col_Telefone.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        col_Telefone.DataPropertyName = "Telefone";
        dataGridViewCellStyle19.ForeColor = SystemColors.ControlText;
        dataGridViewCellStyle19.NullValue = null;
        col_Telefone.DefaultCellStyle = dataGridViewCellStyle19;
        col_Telefone.HeaderText = "TELEFONE";
        col_Telefone.Name = "col_Telefone";
        col_Telefone.ReadOnly = true;
        col_Telefone.Width = 87;
        // 
        // bt_Excluir
        // 
        bt_Excluir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        bt_Excluir.BackColor = Color.Red;
        bt_Excluir.FlatAppearance.BorderColor = Color.Red;
        bt_Excluir.FlatStyle = FlatStyle.Flat;
        bt_Excluir.Location = new Point(730, 459);
        bt_Excluir.Name = "bt_Excluir";
        bt_Excluir.Size = new Size(80, 31);
        bt_Excluir.TabIndex = 9;
        bt_Excluir.TabStop = false;
        bt_Excluir.Text = "Excluir";
        bt_Excluir.UseVisualStyleBackColor = false;
        bt_Excluir.Click += bt_Excluir_Click;
        // 
        // bt_Pesquisar
        // 
        bt_Pesquisar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        bt_Pesquisar.BackColor = SystemColors.Highlight;
        bt_Pesquisar.FlatAppearance.BorderColor = SystemColors.Highlight;
        bt_Pesquisar.FlatStyle = FlatStyle.Flat;
        bt_Pesquisar.ForeColor = SystemColors.Window;
        bt_Pesquisar.Location = new Point(816, 459);
        bt_Pesquisar.Name = "bt_Pesquisar";
        bt_Pesquisar.Size = new Size(80, 31);
        bt_Pesquisar.TabIndex = 10;
        bt_Pesquisar.TabStop = false;
        bt_Pesquisar.Text = "Pesquisar";
        bt_Pesquisar.UseVisualStyleBackColor = false;
        bt_Pesquisar.Click += bt_Pesquisar_Click;
        // 
        // lb_Qtd_Registros
        // 
        lb_Qtd_Registros.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        lb_Qtd_Registros.AutoSize = true;
        lb_Qtd_Registros.ForeColor = SystemColors.ControlText;
        lb_Qtd_Registros.Location = new Point(7, 459);
        lb_Qtd_Registros.Name = "lb_Qtd_Registros";
        lb_Qtd_Registros.Size = new Size(136, 15);
        lb_Qtd_Registros.TabIndex = 11;
        lb_Qtd_Registros.Text = "Quantidade de registros:";
        // 
        // mk_Telefone
        // 
        mk_Telefone.BorderStyle = BorderStyle.FixedSingle;
        mk_Telefone.Location = new Point(712, 37);
        mk_Telefone.Mask = "(99) 0000-0000";
        mk_Telefone.Name = "mk_Telefone";
        mk_Telefone.Size = new Size(100, 23);
        mk_Telefone.TabIndex = 4;
        mk_Telefone.TextAlign = HorizontalAlignment.Center;
        // 
        // label4
        // 
        label4.ForeColor = SystemColors.ControlText;
        label4.Location = new Point(712, 22);
        label4.Name = "label4";
        label4.Size = new Size(62, 19);
        label4.TabIndex = 13;
        label4.Text = "Telefone";
        // 
        // label5
        // 
        label5.ForeColor = Color.DimGray;
        label5.Location = new Point(696, 4);
        label5.Name = "label5";
        label5.Size = new Size(114, 19);
        label5.TabIndex = 14;
        label5.Text = "F1 (Limpar campos)";
        // 
        // label6
        // 
        label6.ForeColor = SystemColors.Highlight;
        label6.Location = new Point(816, 4);
        label6.Name = "label6";
        label6.Size = new Size(81, 19);
        label6.TabIndex = 15;
        label6.Text = "F5 (Pesquisar)";
        // 
        // UI_Agenda
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(904, 492);
        Controls.Add(label6);
        Controls.Add(label5);
        Controls.Add(mk_Telefone);
        Controls.Add(lb_Qtd_Registros);
        Controls.Add(bt_Pesquisar);
        Controls.Add(bt_Excluir);
        Controls.Add(dg_Contatos);
        Controls.Add(bt_Adicionar);
        Controls.Add(txt_Email);
        Controls.Add(label3);
        Controls.Add(txt_Nome);
        Controls.Add(label2);
        Controls.Add(txt_ID);
        Controls.Add(label1);
        Controls.Add(label4);
        ForeColor = SystemColors.Window;
        KeyPreview = true;
        Name = "UI_Agenda";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "AGENDA";
        Load += UI_Agenda_Load;
        KeyDown += UI_Agenda_KeyDown;
        KeyPress += UI_Agenda_KeyPress;
        ((System.ComponentModel.ISupportInitialize)dg_Contatos).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button bt_Pesquisar;
    private System.Windows.Forms.Button bt_Excluir;

    private System.Windows.Forms.DataGridView dg_Contatos;

    private System.Windows.Forms.TextBox txt_ID;
    private System.Windows.Forms.TextBox txt_Nome;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txt_Email;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button bt_Adicionar;

    private System.Windows.Forms.Label label1;

#endregion
    private Label lb_Qtd_Registros;
    private MaskedTextBox mk_Telefone;
    private Label label4;
    private DataGridViewTextBoxColumn col_ID;
    private DataGridViewTextBoxColumn col_Nome;
    private DataGridViewTextBoxColumn col_Email;
    private DataGridViewTextBoxColumn col_Telefone;
    private Label label5;
    private Label label6;
}