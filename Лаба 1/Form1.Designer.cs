namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.TextAnnotation textAnnotation1 = new System.Windows.Forms.DataVisualization.Charting.TextAnnotation();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.LKRATable = new System.Windows.Forms.DataGridView();
            this.PKRATable = new System.Windows.Forms.DataGridView();
            this.LeftBorderField = new System.Windows.Forms.TextBox();
            this.StepField = new System.Windows.Forms.TextBox();
            this.RightBorderField = new System.Windows.Forms.TextBox();
            this.SolutionButton = new System.Windows.Forms.Button();
            this.LeftBorderLabel = new System.Windows.Forms.Label();
            this.RightBorderLabel = new System.Windows.Forms.Label();
            this.StepLabel = new System.Windows.Forms.Label();
            this.GraphLabel = new System.Windows.Forms.Label();
            this.LKRALabel = new System.Windows.Forms.Label();
            this.CKRATable = new System.Windows.Forms.DataGridView();
            this.CKRA2Table = new System.Windows.Forms.DataGridView();
            this.FunctionTable = new System.Windows.Forms.DataGridView();
            this.PKRALabel = new System.Windows.Forms.Label();
            this.CKRALabel = new System.Windows.Forms.Label();
            this.CKRA2Label = new System.Windows.Forms.Label();
            this.FunctionLabel = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.X_Func = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y_Func = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.X_Der = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y_Der = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LKRATable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PKRATable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CKRATable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CKRA2Table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FunctionTable)).BeginInit();
            this.SuspendLayout();
            // 
            // Chart
            // 
            textAnnotation1.AnchorAlignment = System.Drawing.ContentAlignment.BottomRight;
            textAnnotation1.AnchorX = 500D;
            textAnnotation1.AnchorY = 500D;
            textAnnotation1.AxisXName = "ChartArea1\\rX";
            textAnnotation1.Name = "TextAnnotation1";
            textAnnotation1.Text = "X";
            textAnnotation1.YAxisName = "ChartArea1\\rY2";
            this.Chart.Annotations.Add(textAnnotation1);
            this.Chart.BorderlineColor = System.Drawing.Color.Black;
            this.Chart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.BorderWidth = 3;
            chartArea1.Name = "ChartArea1";
            this.Chart.ChartAreas.Add(chartArea1);
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.MaximumAutoSize = 20F;
            legend1.Name = "Legend1";
            this.Chart.Legends.Add(legend1);
            this.Chart.Location = new System.Drawing.Point(12, 131);
            this.Chart.Name = "Chart";
            this.Chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.YValuesPerPoint = 2;
            this.Chart.Series.Add(series1);
            this.Chart.Size = new System.Drawing.Size(450, 450);
            this.Chart.TabIndex = 0;
            this.Chart.Text = "Chart";
            // 
            // LKRATable
            // 
            this.LKRATable.AllowUserToAddRows = false;
            this.LKRATable.AllowUserToDeleteRows = false;
            this.LKRATable.AllowUserToResizeColumns = false;
            this.LKRATable.AllowUserToResizeRows = false;
            this.LKRATable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.LKRATable.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.LKRATable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.LKRATable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X_Der,
            this.Y_Der});
            this.LKRATable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.LKRATable.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LKRATable.Location = new System.Drawing.Point(1042, 27);
            this.LKRATable.MultiSelect = false;
            this.LKRATable.Name = "LKRATable";
            this.LKRATable.ReadOnly = true;
            this.LKRATable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.LKRATable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.ColumnHeaderSelect;
            this.LKRATable.ShowCellErrors = false;
            this.LKRATable.ShowCellToolTips = false;
            this.LKRATable.ShowEditingIcon = false;
            this.LKRATable.ShowRowErrors = false;
            this.LKRATable.Size = new System.Drawing.Size(270, 250);
            this.LKRATable.TabIndex = 2;
            // 
            // PKRATable
            // 
            this.PKRATable.AllowUserToAddRows = false;
            this.PKRATable.AllowUserToDeleteRows = false;
            this.PKRATable.AllowUserToResizeColumns = false;
            this.PKRATable.AllowUserToResizeRows = false;
            this.PKRATable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.PKRATable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X_Func,
            this.Y_Func});
            this.PKRATable.Location = new System.Drawing.Point(490, 27);
            this.PKRATable.Name = "PKRATable";
            this.PKRATable.ReadOnly = true;
            this.PKRATable.Size = new System.Drawing.Size(270, 250);
            this.PKRATable.TabIndex = 3;
            // 
            // LeftBorderField
            // 
            this.LeftBorderField.Enabled = false;
            this.LeftBorderField.Location = new System.Drawing.Point(110, 27);
            this.LeftBorderField.Name = "LeftBorderField";
            this.LeftBorderField.Size = new System.Drawing.Size(100, 20);
            this.LeftBorderField.TabIndex = 4;
            this.LeftBorderField.Text = "0";
            // 
            // StepField
            // 
            this.StepField.Location = new System.Drawing.Point(110, 79);
            this.StepField.Name = "StepField";
            this.StepField.Size = new System.Drawing.Size(100, 20);
            this.StepField.TabIndex = 5;
            // 
            // RightBorderField
            // 
            this.RightBorderField.Enabled = false;
            this.RightBorderField.Location = new System.Drawing.Point(110, 53);
            this.RightBorderField.Name = "RightBorderField";
            this.RightBorderField.Size = new System.Drawing.Size(100, 20);
            this.RightBorderField.TabIndex = 6;
            this.RightBorderField.Text = "1";
            // 
            // SolutionButton
            // 
            this.SolutionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SolutionButton.Location = new System.Drawing.Point(216, 37);
            this.SolutionButton.Name = "SolutionButton";
            this.SolutionButton.Size = new System.Drawing.Size(125, 46);
            this.SolutionButton.TabIndex = 8;
            this.SolutionButton.Text = "Рассчитать";
            this.SolutionButton.UseVisualStyleBackColor = true;
            this.SolutionButton.Click += new System.EventHandler(this.SolutionButtonClick);
            // 
            // LeftBorderLabel
            // 
            this.LeftBorderLabel.AutoSize = true;
            this.LeftBorderLabel.Location = new System.Drawing.Point(21, 30);
            this.LeftBorderLabel.Name = "LeftBorderLabel";
            this.LeftBorderLabel.Size = new System.Drawing.Size(83, 13);
            this.LeftBorderLabel.TabIndex = 9;
            this.LeftBorderLabel.Text = "Левая граница";
            // 
            // RightBorderLabel
            // 
            this.RightBorderLabel.AutoSize = true;
            this.RightBorderLabel.Location = new System.Drawing.Point(15, 56);
            this.RightBorderLabel.Name = "RightBorderLabel";
            this.RightBorderLabel.Size = new System.Drawing.Size(89, 13);
            this.RightBorderLabel.TabIndex = 10;
            this.RightBorderLabel.Text = "Правая граница";
            // 
            // StepLabel
            // 
            this.StepLabel.AutoSize = true;
            this.StepLabel.Location = new System.Drawing.Point(77, 82);
            this.StepLabel.Name = "StepLabel";
            this.StepLabel.Size = new System.Drawing.Size(27, 13);
            this.StepLabel.TabIndex = 11;
            this.StepLabel.Text = "Шаг";
            // 
            // GraphLabel
            // 
            this.GraphLabel.AutoSize = true;
            this.GraphLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GraphLabel.Location = new System.Drawing.Point(9, 104);
            this.GraphLabel.Name = "GraphLabel";
            this.GraphLabel.Size = new System.Drawing.Size(76, 24);
            this.GraphLabel.TabIndex = 13;
            this.GraphLabel.Text = "График";
            // 
            // LKRALabel
            // 
            this.LKRALabel.AutoSize = true;
            this.LKRALabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LKRALabel.Location = new System.Drawing.Point(1038, 0);
            this.LKRALabel.Name = "LKRALabel";
            this.LKRALabel.Size = new System.Drawing.Size(59, 24);
            this.LKRALabel.TabIndex = 14;
            this.LKRALabel.Text = "ЛКРА";
            // 
            // CKRATable
            // 
            this.CKRATable.AllowUserToAddRows = false;
            this.CKRATable.AllowUserToDeleteRows = false;
            this.CKRATable.AllowUserToResizeColumns = false;
            this.CKRATable.AllowUserToResizeRows = false;
            this.CKRATable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.CKRATable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.CKRATable.Location = new System.Drawing.Point(766, 27);
            this.CKRATable.Name = "CKRATable";
            this.CKRATable.ReadOnly = true;
            this.CKRATable.Size = new System.Drawing.Size(270, 250);
            this.CKRATable.TabIndex = 15;
            // 
            // CKRA2Table
            // 
            this.CKRA2Table.AllowUserToAddRows = false;
            this.CKRA2Table.AllowUserToDeleteRows = false;
            this.CKRA2Table.AllowUserToResizeColumns = false;
            this.CKRA2Table.AllowUserToResizeRows = false;
            this.CKRA2Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.CKRA2Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.CKRA2Table.Location = new System.Drawing.Point(490, 331);
            this.CKRA2Table.Name = "CKRA2Table";
            this.CKRA2Table.ReadOnly = true;
            this.CKRA2Table.Size = new System.Drawing.Size(270, 250);
            this.CKRA2Table.TabIndex = 16;
            // 
            // FunctionTable
            // 
            this.FunctionTable.AllowUserToAddRows = false;
            this.FunctionTable.AllowUserToDeleteRows = false;
            this.FunctionTable.AllowUserToResizeColumns = false;
            this.FunctionTable.AllowUserToResizeRows = false;
            this.FunctionTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.FunctionTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.FunctionTable.Location = new System.Drawing.Point(766, 331);
            this.FunctionTable.Name = "FunctionTable";
            this.FunctionTable.ReadOnly = true;
            this.FunctionTable.Size = new System.Drawing.Size(270, 250);
            this.FunctionTable.TabIndex = 17;
            // 
            // PKRALabel
            // 
            this.PKRALabel.AutoSize = true;
            this.PKRALabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PKRALabel.Location = new System.Drawing.Point(486, 0);
            this.PKRALabel.Name = "PKRALabel";
            this.PKRALabel.Size = new System.Drawing.Size(60, 24);
            this.PKRALabel.TabIndex = 18;
            this.PKRALabel.Text = "ПКРА";
            // 
            // CKRALabel
            // 
            this.CKRALabel.AutoSize = true;
            this.CKRALabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CKRALabel.Location = new System.Drawing.Point(762, 0);
            this.CKRALabel.Name = "CKRALabel";
            this.CKRALabel.Size = new System.Drawing.Size(59, 24);
            this.CKRALabel.TabIndex = 19;
            this.CKRALabel.Text = "ЦКРА";
            // 
            // CKRA2Label
            // 
            this.CKRA2Label.AutoSize = true;
            this.CKRA2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CKRA2Label.Location = new System.Drawing.Point(486, 304);
            this.CKRA2Label.Name = "CKRA2Label";
            this.CKRA2Label.Size = new System.Drawing.Size(64, 24);
            this.CKRA2Label.TabIndex = 20;
            this.CKRA2Label.Text = "ЦКРА²";
            // 
            // FunctionLabel
            // 
            this.FunctionLabel.AutoSize = true;
            this.FunctionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FunctionLabel.Location = new System.Drawing.Point(762, 304);
            this.FunctionLabel.Name = "FunctionLabel";
            this.FunctionLabel.Size = new System.Drawing.Size(87, 24);
            this.FunctionLabel.TabIndex = 21;
            this.FunctionLabel.Text = "Функция";
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearButton.Location = new System.Drawing.Point(347, 37);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(125, 46);
            this.ClearButton.TabIndex = 22;
            this.ClearButton.Text = "Очистить";
            this.ClearButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(1038, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 24);
            this.label1.TabIndex = 23;
            this.label1.Text = "Погрешности";
            // 
            // X_Func
            // 
            this.X_Func.DividerWidth = 1;
            this.X_Func.Frozen = true;
            this.X_Func.HeaderText = "X";
            this.X_Func.Name = "X_Func";
            this.X_Func.ReadOnly = true;
            this.X_Func.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Y_Func
            // 
            this.Y_Func.DividerWidth = 1;
            this.Y_Func.Frozen = true;
            this.Y_Func.HeaderText = "Y";
            this.Y_Func.Name = "Y_Func";
            this.Y_Func.ReadOnly = true;
            this.Y_Func.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Y_Func.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DividerWidth = 1;
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "X";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DividerWidth = 1;
            this.dataGridViewTextBoxColumn2.Frozen = true;
            this.dataGridViewTextBoxColumn2.HeaderText = "Y";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // X_Der
            // 
            this.X_Der.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.X_Der.DividerWidth = 1;
            this.X_Der.Frozen = true;
            this.X_Der.HeaderText = "X";
            this.X_Der.Name = "X_Der";
            this.X_Der.ReadOnly = true;
            this.X_Der.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.X_Der.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Y_Der
            // 
            this.Y_Der.DividerWidth = 1;
            this.Y_Der.Frozen = true;
            this.Y_Der.HeaderText = "Y";
            this.Y_Der.Name = "Y_Der";
            this.Y_Der.ReadOnly = true;
            this.Y_Der.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Y_Der.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DividerWidth = 1;
            this.dataGridViewTextBoxColumn3.Frozen = true;
            this.dataGridViewTextBoxColumn3.HeaderText = "X";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DividerWidth = 1;
            this.dataGridViewTextBoxColumn4.Frozen = true;
            this.dataGridViewTextBoxColumn4.HeaderText = "Y";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DividerWidth = 1;
            this.dataGridViewTextBoxColumn5.Frozen = true;
            this.dataGridViewTextBoxColumn5.HeaderText = "X";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DividerWidth = 1;
            this.dataGridViewTextBoxColumn6.Frozen = true;
            this.dataGridViewTextBoxColumn6.HeaderText = "Y";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 600);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.FunctionLabel);
            this.Controls.Add(this.CKRA2Label);
            this.Controls.Add(this.CKRALabel);
            this.Controls.Add(this.PKRALabel);
            this.Controls.Add(this.FunctionTable);
            this.Controls.Add(this.CKRA2Table);
            this.Controls.Add(this.CKRATable);
            this.Controls.Add(this.LKRALabel);
            this.Controls.Add(this.GraphLabel);
            this.Controls.Add(this.StepLabel);
            this.Controls.Add(this.RightBorderLabel);
            this.Controls.Add(this.LeftBorderLabel);
            this.Controls.Add(this.SolutionButton);
            this.Controls.Add(this.RightBorderField);
            this.Controls.Add(this.StepField);
            this.Controls.Add(this.LeftBorderField);
            this.Controls.Add(this.PKRATable);
            this.Controls.Add(this.LKRATable);
            this.Controls.Add(this.Chart);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LKRATable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PKRATable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CKRATable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CKRA2Table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FunctionTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Chart;
        private System.Windows.Forms.DataGridView LKRATable;
        private System.Windows.Forms.DataGridView PKRATable;
        private System.Windows.Forms.TextBox LeftBorderField;
        private System.Windows.Forms.TextBox StepField;
        private System.Windows.Forms.TextBox RightBorderField;
        private System.Windows.Forms.Button SolutionButton;
        private System.Windows.Forms.Label LeftBorderLabel;
        private System.Windows.Forms.Label RightBorderLabel;
        private System.Windows.Forms.Label StepLabel;
        private System.Windows.Forms.Label GraphLabel;
        private System.Windows.Forms.Label LKRALabel;
        private System.Windows.Forms.DataGridView CKRATable;
        private System.Windows.Forms.DataGridView CKRA2Table;
        private System.Windows.Forms.DataGridView FunctionTable;
        private System.Windows.Forms.Label PKRALabel;
        private System.Windows.Forms.Label CKRALabel;
        private System.Windows.Forms.Label CKRA2Label;
        private System.Windows.Forms.Label FunctionLabel;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn X_Der;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y_Der;
        private System.Windows.Forms.DataGridViewTextBoxColumn X_Func;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y_Func;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}

