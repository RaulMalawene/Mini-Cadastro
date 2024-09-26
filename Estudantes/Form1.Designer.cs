namespace Estudantes
{
    partial class Form1
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lstvEstudantes = new ListView();
            codigo = new ColumnHeader();
            Nome = new ColumnHeader();
            Nota1 = new ColumnHeader();
            Nota2 = new ColumnHeader();
            Media = new ColumnHeader();
            label1 = new Label();
            cd = new TextBox();
            nt1 = new TextBox();
            label2 = new Label();
            nt2 = new TextBox();
            label3 = new Label();
            nm = new TextBox();
            label4 = new Label();
            adicionar = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // lstvEstudantes
            // 
            lstvEstudantes.Columns.AddRange(new ColumnHeader[] { codigo, Nome, Nota1, Nota2, Media });
            lstvEstudantes.GridLines = true;
            lstvEstudantes.Location = new Point(45, 219);
            lstvEstudantes.Name = "lstvEstudantes";
            lstvEstudantes.Size = new Size(724, 211);
            lstvEstudantes.TabIndex = 0;
            lstvEstudantes.UseCompatibleStateImageBehavior = false;
            lstvEstudantes.View = View.Details;
            // 
            // codigo
            // 
            codigo.Text = "codigo";
            codigo.Width = 80;
            // 
            // Nome
            // 
            Nome.Text = "nome";
            Nome.Width = 400;
            // 
            // Nota1
            // 
            Nota1.Text = "nota1";
            Nota1.Width = 80;
            // 
            // Nota2
            // 
            Nota2.Text = "nota2";
            Nota2.Width = 80;
            // 
            // Media
            // 
            Media.Text = "media";
            Media.Width = 80;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 46);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "label1";
            label1.Click += label1_Click;
            // 
            // cd
            // 
            cd.Location = new Point(45, 64);
            cd.Name = "cd";
            cd.Size = new Size(156, 23);
            cd.TabIndex = 2;
            // 
            // nt1
            // 
            nt1.Location = new Point(45, 133);
            nt1.Name = "nt1";
            nt1.Size = new Size(156, 23);
            nt1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 115);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 3;
            label2.Text = "label2";
            // 
            // nt2
            // 
            nt2.Location = new Point(318, 133);
            nt2.Name = "nt2";
            nt2.Size = new Size(156, 23);
            nt2.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(318, 115);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 7;
            label3.Text = "label3";
            // 
            // nm
            // 
            nm.Location = new Point(318, 64);
            nm.Name = "nm";
            nm.Size = new Size(156, 23);
            nm.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(318, 46);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 5;
            label4.Text = "label4";
            // 
            // adicionar
            // 
            adicionar.Location = new Point(581, 59);
            adicionar.Name = "adicionar";
            adicionar.Size = new Size(139, 28);
            adicionar.TabIndex = 9;
            adicionar.Text = "button1";
            adicionar.UseVisualStyleBackColor = true;
            adicionar.Click += adicionar_Click;
            // 
            // button2
            // 
            button2.Location = new Point(581, 133);
            button2.Name = "button2";
            button2.Size = new Size(139, 28);
            button2.TabIndex = 10;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(adicionar);
            Controls.Add(nt2);
            Controls.Add(label3);
            Controls.Add(nm);
            Controls.Add(label4);
            Controls.Add(nt1);
            Controls.Add(label2);
            Controls.Add(cd);
            Controls.Add(label1);
            Controls.Add(lstvEstudantes);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lstvEstudantes;
        private ColumnHeader codigo;
        private ColumnHeader Nome;
        private ColumnHeader Nota1;
        private ColumnHeader Nota2;
        private ColumnHeader Media;
        private Label label1;
        private TextBox cd;
        private TextBox nt1;
        private Label label2;
        private TextBox nt2;
        private Label label3;
        private TextBox nm;
        private Label label4;
        private Button adicionar;
        private Button button2;
    }
}
