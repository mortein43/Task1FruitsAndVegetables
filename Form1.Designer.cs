namespace Task1FruitsAndVegetables
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
            dataGridView1 = new DataGridView();
            radioAll = new RadioButton();
            allNames = new RadioButton();
            allColors = new RadioButton();
            maxCaloric = new RadioButton();
            minCaloric = new RadioButton();
            averageCalorie = new RadioButton();
            amountOfVegetables = new RadioButton();
            amountOfFruits = new RadioButton();
            colorInput = new ComboBox();
            sqliteCommand1 = new Microsoft.Data.Sqlite.SqliteCommand();
            allForColor = new RadioButton();
            amountForColors = new RadioButton();
            less = new RadioButton();
            caloriesInput = new ComboBox();
            more = new RadioButton();
            allOfGivenColor = new RadioButton();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            calorieRange = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 178);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(546, 317);
            dataGridView1.TabIndex = 0;
            // 
            // radioAll
            // 
            radioAll.AutoSize = true;
            radioAll.Checked = true;
            radioAll.Location = new Point(12, 56);
            radioAll.Name = "radioAll";
            radioAll.Size = new Size(63, 19);
            radioAll.TabIndex = 1;
            radioAll.TabStop = true;
            radioAll.Text = "All info";
            radioAll.UseVisualStyleBackColor = true;
            radioAll.CheckedChanged += RadioAll_CheckedChanged;
            // 
            // allNames
            // 
            allNames.AutoSize = true;
            allNames.Location = new Point(12, 81);
            allNames.Name = "allNames";
            allNames.Size = new Size(77, 19);
            allNames.TabIndex = 2;
            allNames.TabStop = true;
            allNames.Text = "All names";
            allNames.UseVisualStyleBackColor = true;
            allNames.CheckedChanged += AllNames_CheckedChanged;
            // 
            // allColors
            // 
            allColors.AutoSize = true;
            allColors.Location = new Point(12, 106);
            allColors.Name = "allColors";
            allColors.Size = new Size(76, 19);
            allColors.TabIndex = 3;
            allColors.TabStop = true;
            allColors.Text = "All Colors";
            allColors.UseVisualStyleBackColor = true;
            allColors.CheckedChanged += AllColors_CheckedChanged;
            // 
            // maxCaloric
            // 
            maxCaloric.AutoSize = true;
            maxCaloric.Location = new Point(112, 56);
            maxCaloric.Name = "maxCaloric";
            maxCaloric.Size = new Size(86, 19);
            maxCaloric.TabIndex = 4;
            maxCaloric.TabStop = true;
            maxCaloric.Text = "Max caloric";
            maxCaloric.UseVisualStyleBackColor = true;
            maxCaloric.CheckedChanged += MaxCaloric_CheckedChanged;
            // 
            // minCaloric
            // 
            minCaloric.AutoSize = true;
            minCaloric.Location = new Point(112, 81);
            minCaloric.Name = "minCaloric";
            minCaloric.Size = new Size(84, 19);
            minCaloric.TabIndex = 5;
            minCaloric.TabStop = true;
            minCaloric.Text = "Min caloric";
            minCaloric.UseVisualStyleBackColor = true;
            minCaloric.CheckedChanged += MinCaloric_CheckedChanged;
            // 
            // averageCalorie
            // 
            averageCalorie.AutoSize = true;
            averageCalorie.Location = new Point(112, 106);
            averageCalorie.Name = "averageCalorie";
            averageCalorie.Size = new Size(106, 19);
            averageCalorie.TabIndex = 6;
            averageCalorie.TabStop = true;
            averageCalorie.Text = "Average calorie";
            averageCalorie.UseVisualStyleBackColor = true;
            averageCalorie.CheckedChanged += AverageCalorie_CheckedChanged;
            // 
            // amountOfVegetables
            // 
            amountOfVegetables.AutoSize = true;
            amountOfVegetables.Location = new Point(263, 59);
            amountOfVegetables.Name = "amountOfVegetables";
            amountOfVegetables.Size = new Size(142, 19);
            amountOfVegetables.TabIndex = 7;
            amountOfVegetables.TabStop = true;
            amountOfVegetables.Text = "Amount of vegetables";
            amountOfVegetables.UseVisualStyleBackColor = true;
            amountOfVegetables.CheckedChanged += AmountOfVegetables_CheckedChanged;
            // 
            // amountOfFruits
            // 
            amountOfFruits.AutoSize = true;
            amountOfFruits.Location = new Point(263, 84);
            amountOfFruits.Name = "amountOfFruits";
            amountOfFruits.Size = new Size(115, 19);
            amountOfFruits.TabIndex = 8;
            amountOfFruits.TabStop = true;
            amountOfFruits.Text = "Amount of Fruits";
            amountOfFruits.UseVisualStyleBackColor = true;
            amountOfFruits.CheckedChanged += AmountOfFruits_CheckedChanged;
            // 
            // colorInput
            // 
            colorInput.FormattingEnabled = true;
            colorInput.Items.AddRange(new object[] { "Yellow", "Red", "Green", "Brown", "White" });
            colorInput.Location = new Point(263, 30);
            colorInput.Name = "colorInput";
            colorInput.Size = new Size(121, 23);
            colorInput.TabIndex = 9;
            colorInput.SelectedIndexChanged += AllOfGivenColor_CheckedChanged;
            // 
            // sqliteCommand1
            // 
            sqliteCommand1.CommandTimeout = 30;
            sqliteCommand1.Connection = null;
            sqliteCommand1.Transaction = null;
            sqliteCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // allForColor
            // 
            allForColor.AutoSize = true;
            allForColor.Location = new Point(263, 106);
            allForColor.Name = "allForColor";
            allForColor.Size = new Size(87, 19);
            allForColor.TabIndex = 10;
            allForColor.TabStop = true;
            allForColor.Text = "All for color";
            allForColor.UseVisualStyleBackColor = true;
            allForColor.CheckedChanged += AllForColor_CheckedChanged;
            // 
            // amountForColors
            // 
            amountForColors.AutoSize = true;
            amountForColors.Location = new Point(262, 131);
            amountForColors.Name = "amountForColors";
            amountForColors.Size = new Size(122, 19);
            amountForColors.TabIndex = 11;
            amountForColors.TabStop = true;
            amountForColors.Text = "Amount for colors";
            amountForColors.UseVisualStyleBackColor = true;
            amountForColors.CheckedChanged += AmountForColors_CheckedChanged;
            // 
            // less
            // 
            less.AutoSize = true;
            less.Location = new Point(411, 59);
            less.Name = "less";
            less.Size = new Size(47, 19);
            less.TabIndex = 12;
            less.TabStop = true;
            less.Text = "Less";
            less.UseVisualStyleBackColor = true;
            less.CheckedChanged += Less_CheckedChanged;
            // 
            // caloriesInput
            // 
            caloriesInput.FormattingEnabled = true;
            caloriesInput.Items.AddRange(new object[] { "10", "20", "30", "40", "50", "60", "70", "80", "90", "100" });
            caloriesInput.Location = new Point(411, 30);
            caloriesInput.Name = "caloriesInput";
            caloriesInput.Size = new Size(121, 23);
            caloriesInput.TabIndex = 13;
            caloriesInput.SelectedIndexChanged += Less_CheckedChanged;
            // 
            // more
            // 
            more.AutoSize = true;
            more.Location = new Point(411, 84);
            more.Name = "more";
            more.Size = new Size(53, 19);
            more.TabIndex = 14;
            more.TabStop = true;
            more.Text = "More";
            more.UseVisualStyleBackColor = true;
            more.CheckedChanged += More_CheckedChanged;
            // 
            // allOfGivenColor
            // 
            allOfGivenColor.AutoSize = true;
            allOfGivenColor.Location = new Point(263, 152);
            allOfGivenColor.Name = "allOfGivenColor";
            allOfGivenColor.Size = new Size(124, 19);
            allOfGivenColor.TabIndex = 15;
            allOfGivenColor.TabStop = true;
            allOfGivenColor.Text = "All of a given color";
            allOfGivenColor.UseVisualStyleBackColor = true;
            allOfGivenColor.CheckedChanged += AllOfGivenColor_CheckedChanged;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(16, 149);
            numericUpDown1.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(44, 23);
            numericUpDown1.TabIndex = 16;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.ValueChanged += RadioButton1_CheckedChanged;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(76, 149);
            numericUpDown2.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            numericUpDown2.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(44, 23);
            numericUpDown2.TabIndex = 17;
            numericUpDown2.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown2.ValueChanged += RadioButton1_CheckedChanged;
            // 
            // calorieRange
            // 
            calorieRange.AutoSize = true;
            calorieRange.Location = new Point(132, 151);
            calorieRange.Name = "calorieRange";
            calorieRange.Size = new Size(95, 19);
            calorieRange.TabIndex = 18;
            calorieRange.TabStop = true;
            calorieRange.Text = "Сalorie range";
            calorieRange.UseVisualStyleBackColor = true;
            calorieRange.CheckedChanged += RadioButton1_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(262, 9);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 19;
            label1.Text = "Colors:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(411, 9);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 20;
            label2.Text = "Calories:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(546, 495);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(calorieRange);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(allOfGivenColor);
            Controls.Add(more);
            Controls.Add(caloriesInput);
            Controls.Add(less);
            Controls.Add(amountForColors);
            Controls.Add(allForColor);
            Controls.Add(colorInput);
            Controls.Add(amountOfFruits);
            Controls.Add(amountOfVegetables);
            Controls.Add(averageCalorie);
            Controls.Add(minCaloric);
            Controls.Add(maxCaloric);
            Controls.Add(allColors);
            Controls.Add(allNames);
            Controls.Add(radioAll);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private RadioButton radioAll;
        private RadioButton allNames;
        private RadioButton allColors;
        private RadioButton maxCaloric;
        private RadioButton minCaloric;
        private RadioButton averageCalorie;
        private RadioButton amountOfVegetables;
        private RadioButton amountOfFruits;
        private ComboBox colorInput;
        private Microsoft.Data.Sqlite.SqliteCommand sqliteCommand1;
        private RadioButton allForColor;
        private RadioButton amountForColors;
        private RadioButton less;
        private ComboBox caloriesInput;
        private RadioButton more;
        private RadioButton allOfGivenColor;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private RadioButton calorieRange;
        private Label label1;
        private Label label2;
    }
}
