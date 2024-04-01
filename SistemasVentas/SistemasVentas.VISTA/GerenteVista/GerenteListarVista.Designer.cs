namespace SistemasVentas.VISTA.GerenteVista
{
    partial class GerenteListarVista
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            panel3 = new Panel();
            button10 = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel1 = new Panel();
            label2 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 255, 192);
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(-1, 59);
            panel2.Name = "panel2";
            panel2.Size = new Size(803, 504);
            panel2.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = SystemColors.Info;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(153, 13);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(636, 476);
            dataGridView1.TabIndex = 20;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Khaki;
            panel3.Controls.Add(button10);
            panel3.Controls.Add(button9);
            panel3.Controls.Add(button8);
            panel3.Controls.Add(button7);
            panel3.Controls.Add(button6);
            panel3.Controls.Add(button5);
            panel3.Controls.Add(button4);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button1);
            panel3.Location = new Point(3, 13);
            panel3.Name = "panel3";
            panel3.Size = new Size(144, 476);
            panel3.TabIndex = 13;
            // 
            // button10
            // 
            button10.BackColor = Color.Black;
            button10.ForeColor = SystemColors.ControlLightLight;
            button10.Location = new Point(10, 424);
            button10.Name = "button10";
            button10.Size = new Size(113, 23);
            button10.TabIndex = 23;
            button10.Text = "TOP CLIENTES";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.Black;
            button9.ForeColor = SystemColors.ControlLightLight;
            button9.Location = new Point(10, 388);
            button9.Name = "button9";
            button9.Size = new Size(113, 23);
            button9.TabIndex = 22;
            button9.Text = "TIPO PRODUCTOS";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.Black;
            button8.ForeColor = SystemColors.ControlLightLight;
            button8.Location = new Point(10, 359);
            button8.Name = "button8";
            button8.Size = new Size(113, 23);
            button8.TabIndex = 21;
            button8.Text = "PROVEEDORES";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.Black;
            button7.ForeColor = SystemColors.ControlLightLight;
            button7.Location = new Point(10, 309);
            button7.Name = "button7";
            button7.Size = new Size(113, 44);
            button7.TabIndex = 20;
            button7.Text = "INGRESOS CLIENTES";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Black;
            button6.ForeColor = SystemColors.ControlLightLight;
            button6.Location = new Point(10, 265);
            button6.Name = "button6";
            button6.Size = new Size(113, 38);
            button6.TabIndex = 19;
            button6.Text = "PRODUCTOS VENDIDOS";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Black;
            button5.ForeColor = SystemColors.ControlLightLight;
            button5.Location = new Point(10, 205);
            button5.Name = "button5";
            button5.Size = new Size(110, 44);
            button5.TabIndex = 18;
            button5.Text = "VENCIMIENTO PRODUCTOS";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Black;
            button4.ForeColor = SystemColors.ControlLightLight;
            button4.Location = new Point(11, 147);
            button4.Name = "button4";
            button4.Size = new Size(113, 42);
            button4.TabIndex = 16;
            button4.Text = "TOTAL PRODUCTOS";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Black;
            button3.ForeColor = SystemColors.ControlLightLight;
            button3.Location = new Point(10, 98);
            button3.Name = "button3";
            button3.Size = new Size(113, 43);
            button3.TabIndex = 15;
            button3.Text = "MARCA MAS VENDIDA\r\n";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(11, 54);
            button2.Name = "button2";
            button2.Size = new Size(112, 38);
            button2.TabIndex = 14;
            button2.Text = "INGRESOS PROOVEDOR";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(10, 25);
            button1.Name = "button1";
            button1.Size = new Size(113, 23);
            button1.TabIndex = 13;
            button1.Text = "CLIENTES";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Khaki;
            panel1.Controls.Add(label2);
            panel1.Location = new Point(-1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(803, 65);
            panel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DarkGray;
            label2.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(173, 8);
            label2.Name = "label2";
            label2.Size = new Size(526, 45);
            label2.TabIndex = 12;
            label2.Text = "SISTEMA DE VENTAS EXAMEN 2";
            // 
            // GerenteListarVista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 560);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "GerenteListarVista";
            Text = "GerenteListarVista";
            Load += GerenteListarVista_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Panel panel1;
        private Label label2;
        private Panel panel3;
        private Button button10;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private DataGridView dataGridView1;
    }
}