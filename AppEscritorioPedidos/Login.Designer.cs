namespace AppEscritorioPedidos
{
    partial class Login
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
            Contraseña = new TextBox();
            IdUsuario = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Ingresar = new Button();
            Recu_Contra = new LinkLabel();
            SuspendLayout();
            // 
            // Contraseña
            // 
            Contraseña.Location = new Point(358, 366);
            Contraseña.Name = "Contraseña";
            Contraseña.Size = new Size(267, 23);
            Contraseña.TabIndex = 1;
            
            // 
            // IdUsuario
            // 
            IdUsuario.Anchor = AnchorStyles.None;
            IdUsuario.Location = new Point(358, 231);
            IdUsuario.Name = "IdUsuario";
            IdUsuario.Size = new Size(267, 23);
            IdUsuario.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(412, 102);
            label1.Name = "label1";
            label1.Size = new Size(147, 15);
            label1.TabIndex = 2;
            label1.Text = "INGRESAR A PEDIDOS APP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(462, 192);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 3;
            label2.Text = "Usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(448, 334);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 4;
            label3.Text = "Contraseña ";
            // 
            // Ingresar
            // 
            Ingresar.Location = new Point(358, 535);
            Ingresar.Name = "Ingresar";
            Ingresar.Size = new Size(267, 40);
            Ingresar.TabIndex = 5;
            Ingresar.Text = "Ingresar";
            Ingresar.UseVisualStyleBackColor = true;
            Ingresar.Click += BtonIngresar;
            // 
            // Recu_Contra
            // 
            Recu_Contra.AutoSize = true;
            Recu_Contra.Location = new Point(358, 451);
            Recu_Contra.Name = "Recu_Contra";
            Recu_Contra.Size = new Size(123, 15);
            Recu_Contra.TabIndex = 6;
            Recu_Contra.TabStop = true;
            Recu_Contra.Text = "Recuperar Contraseña";
            Recu_Contra.LinkClicked += linkRecupera_contra;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 729);
            Controls.Add(Recu_Contra);
            Controls.Add(Ingresar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Contraseña);
            Controls.Add(IdUsuario);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MaximumSize = new Size(1024, 768);
            MinimumSize = new Size(1024, 768);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox IdUsuario;
        private TextBox Contraseña;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button Ingresar;
        private LinkLabel Recu_Contra;
        private Button button1;
    }
}
