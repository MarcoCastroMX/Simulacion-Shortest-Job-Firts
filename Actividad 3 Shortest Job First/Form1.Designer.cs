namespace Shortest_Job_First
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LbNombre = new System.Windows.Forms.Label();
            this.LbTiempo = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.BtnAñadir = new System.Windows.Forms.Button();
            this.BtnIniciar = new System.Windows.Forms.Button();
            this.Grafica = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Tabla = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Grafica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Proceso:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tiempo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Proceso Actual:";
            // 
            // LbNombre
            // 
            this.LbNombre.AutoSize = true;
            this.LbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbNombre.Location = new System.Drawing.Point(131, 129);
            this.LbNombre.Name = "LbNombre";
            this.LbNombre.Size = new System.Drawing.Size(0, 31);
            this.LbNombre.TabIndex = 5;
            // 
            // LbTiempo
            // 
            this.LbTiempo.AutoSize = true;
            this.LbTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTiempo.Location = new System.Drawing.Point(131, 184);
            this.LbTiempo.Name = "LbTiempo";
            this.LbTiempo.Size = new System.Drawing.Size(0, 31);
            this.LbTiempo.TabIndex = 6;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(192, 27);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(100, 29);
            this.TxtNombre.TabIndex = 9;
            // 
            // BtnAñadir
            // 
            this.BtnAñadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAñadir.Location = new System.Drawing.Point(317, 22);
            this.BtnAñadir.Name = "BtnAñadir";
            this.BtnAñadir.Size = new System.Drawing.Size(46, 38);
            this.BtnAñadir.TabIndex = 12;
            this.BtnAñadir.Text = "+";
            this.BtnAñadir.UseVisualStyleBackColor = true;
            this.BtnAñadir.Click += new System.EventHandler(this.BtnAñadir_Click);
            // 
            // BtnIniciar
            // 
            this.BtnIniciar.Enabled = false;
            this.BtnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIniciar.Location = new System.Drawing.Point(614, 22);
            this.BtnIniciar.Name = "BtnIniciar";
            this.BtnIniciar.Size = new System.Drawing.Size(200, 38);
            this.BtnIniciar.TabIndex = 13;
            this.BtnIniciar.Text = "Iniciar";
            this.BtnIniciar.UseVisualStyleBackColor = true;
            this.BtnIniciar.Click += new System.EventHandler(this.BtnIniciar_Click);
            // 
            // Grafica
            // 
            chartArea3.Name = "ChartArea1";
            this.Grafica.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.Grafica.Legends.Add(legend3);
            this.Grafica.Location = new System.Drawing.Point(241, 80);
            this.Grafica.Name = "Grafica";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Procesos";
            this.Grafica.Series.Add(series3);
            this.Grafica.Size = new System.Drawing.Size(388, 348);
            this.Grafica.TabIndex = 14;
            // 
            // Tabla
            // 
            this.Tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre});
            this.Tabla.Location = new System.Drawing.Point(636, 80);
            this.Tabla.Name = "Tabla";
            this.Tabla.Size = new System.Drawing.Size(213, 348);
            this.Tabla.TabIndex = 15;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Procesos Finalizados:";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 451);
            this.Controls.Add(this.Tabla);
            this.Controls.Add(this.Grafica);
            this.Controls.Add(this.BtnIniciar);
            this.Controls.Add(this.BtnAñadir);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.LbTiempo);
            this.Controls.Add(this.LbNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Proyecto_3";
            ((System.ComponentModel.ISupportInitialize)(this.Grafica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LbNombre;
        private System.Windows.Forms.Label LbTiempo;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Button BtnAñadir;
        private System.Windows.Forms.Button BtnIniciar;
        private System.Windows.Forms.DataVisualization.Charting.Chart Grafica;
        private System.Windows.Forms.DataGridView Tabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
    }
}

