namespace Menu_Burmeister
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
            this.burgerCheckBox = new System.Windows.Forms.CheckBox();
            this.fryCheckBox = new System.Windows.Forms.CheckBox();
            this.drinksCheckBox = new System.Windows.Forms.CheckBox();
            this.burgerGroupBox = new System.Windows.Forms.GroupBox();
            this.bothRadioButton = new System.Windows.Forms.RadioButton();
            this.baconRadioButton = new System.Windows.Forms.RadioButton();
            this.cheeseRadioButton = new System.Windows.Forms.RadioButton();
            this.regularRadioButton = new System.Windows.Forms.RadioButton();
            this.friesGroupBox = new System.Windows.Forms.GroupBox();
            this.largeRadioButton = new System.Windows.Forms.RadioButton();
            this.mediumRadioButton = new System.Windows.Forms.RadioButton();
            this.smallRadioButton = new System.Windows.Forms.RadioButton();
            this.drinkGroupBox = new System.Windows.Forms.GroupBox();
            this.waterRadioButton = new System.Windows.Forms.RadioButton();
            this.sodaRadioButton = new System.Windows.Forms.RadioButton();
            this.costButton = new System.Windows.Forms.Button();
            this.drinkLabel = new System.Windows.Forms.Label();
            this.friesLabel = new System.Windows.Forms.Label();
            this.burgerLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.costLabel = new System.Windows.Forms.Label();
            this.burgerGroupBox.SuspendLayout();
            this.friesGroupBox.SuspendLayout();
            this.drinkGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // burgerCheckBox
            // 
            this.burgerCheckBox.AutoSize = true;
            this.burgerCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.burgerCheckBox.Location = new System.Drawing.Point(38, 23);
            this.burgerCheckBox.Name = "burgerCheckBox";
            this.burgerCheckBox.Size = new System.Drawing.Size(84, 24);
            this.burgerCheckBox.TabIndex = 0;
            this.burgerCheckBox.Text = "Burgers";
            this.burgerCheckBox.UseVisualStyleBackColor = true;
            this.burgerCheckBox.CheckedChanged += new System.EventHandler(this.burgerCheckBox_CheckedChanged);
            // 
            // fryCheckBox
            // 
            this.fryCheckBox.AutoSize = true;
            this.fryCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fryCheckBox.Location = new System.Drawing.Point(38, 138);
            this.fryCheckBox.Name = "fryCheckBox";
            this.fryCheckBox.Size = new System.Drawing.Size(63, 24);
            this.fryCheckBox.TabIndex = 1;
            this.fryCheckBox.Text = "Fries";
            this.fryCheckBox.UseVisualStyleBackColor = true;
            this.fryCheckBox.CheckedChanged += new System.EventHandler(this.fryCheckBox_CheckedChanged);
            // 
            // drinksCheckBox
            // 
            this.drinksCheckBox.AutoSize = true;
            this.drinksCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinksCheckBox.Location = new System.Drawing.Point(38, 240);
            this.drinksCheckBox.Name = "drinksCheckBox";
            this.drinksCheckBox.Size = new System.Drawing.Size(73, 24);
            this.drinksCheckBox.TabIndex = 2;
            this.drinksCheckBox.Text = "Drinks";
            this.drinksCheckBox.UseVisualStyleBackColor = true;
            this.drinksCheckBox.CheckedChanged += new System.EventHandler(this.drinksCheckBox_CheckedChanged);
            // 
            // burgerGroupBox
            // 
            this.burgerGroupBox.Controls.Add(this.bothRadioButton);
            this.burgerGroupBox.Controls.Add(this.baconRadioButton);
            this.burgerGroupBox.Controls.Add(this.cheeseRadioButton);
            this.burgerGroupBox.Controls.Add(this.regularRadioButton);
            this.burgerGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.burgerGroupBox.Location = new System.Drawing.Point(185, 47);
            this.burgerGroupBox.Name = "burgerGroupBox";
            this.burgerGroupBox.Size = new System.Drawing.Size(216, 92);
            this.burgerGroupBox.TabIndex = 3;
            this.burgerGroupBox.TabStop = false;
            this.burgerGroupBox.Text = "groupBox1";
            this.burgerGroupBox.Visible = false;
            // 
            // bothRadioButton
            // 
            this.bothRadioButton.AutoSize = true;
            this.bothRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bothRadioButton.Location = new System.Drawing.Point(0, 68);
            this.bothRadioButton.Name = "bothRadioButton";
            this.bothRadioButton.Size = new System.Drawing.Size(218, 24);
            this.bothRadioButton.TabIndex = 3;
            this.bothRadioButton.TabStop = true;
            this.bothRadioButton.Text = "w/ bacon and cheese(5.39)";
            this.bothRadioButton.UseVisualStyleBackColor = true;
            // 
            // baconRadioButton
            // 
            this.baconRadioButton.AutoSize = true;
            this.baconRadioButton.Location = new System.Drawing.Point(0, 45);
            this.baconRadioButton.Name = "baconRadioButton";
            this.baconRadioButton.Size = new System.Drawing.Size(131, 24);
            this.baconRadioButton.TabIndex = 2;
            this.baconRadioButton.TabStop = true;
            this.baconRadioButton.Text = "w/ bacon(4.79)";
            this.baconRadioButton.UseVisualStyleBackColor = true;
            // 
            // cheeseRadioButton
            // 
            this.cheeseRadioButton.AutoSize = true;
            this.cheeseRadioButton.Location = new System.Drawing.Point(0, 22);
            this.cheeseRadioButton.Name = "cheeseRadioButton";
            this.cheeseRadioButton.Size = new System.Drawing.Size(139, 24);
            this.cheeseRadioButton.TabIndex = 1;
            this.cheeseRadioButton.TabStop = true;
            this.cheeseRadioButton.Text = "w/ cheese(4.79)";
            this.cheeseRadioButton.UseVisualStyleBackColor = true;
            // 
            // regularRadioButton
            // 
            this.regularRadioButton.AutoSize = true;
            this.regularRadioButton.Location = new System.Drawing.Point(0, 0);
            this.regularRadioButton.Name = "regularRadioButton";
            this.regularRadioButton.Size = new System.Drawing.Size(124, 24);
            this.regularRadioButton.TabIndex = 0;
            this.regularRadioButton.TabStop = true;
            this.regularRadioButton.Text = "Regular(4.19)";
            this.regularRadioButton.UseVisualStyleBackColor = true;
            // 
            // friesGroupBox
            // 
            this.friesGroupBox.Controls.Add(this.largeRadioButton);
            this.friesGroupBox.Controls.Add(this.mediumRadioButton);
            this.friesGroupBox.Controls.Add(this.smallRadioButton);
            this.friesGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.friesGroupBox.Location = new System.Drawing.Point(185, 162);
            this.friesGroupBox.Name = "friesGroupBox";
            this.friesGroupBox.Size = new System.Drawing.Size(139, 88);
            this.friesGroupBox.TabIndex = 4;
            this.friesGroupBox.TabStop = false;
            this.friesGroupBox.Text = "groupBox2";
            this.friesGroupBox.Visible = false;
            // 
            // largeRadioButton
            // 
            this.largeRadioButton.AutoSize = true;
            this.largeRadioButton.Location = new System.Drawing.Point(1, 53);
            this.largeRadioButton.Name = "largeRadioButton";
            this.largeRadioButton.Size = new System.Drawing.Size(109, 24);
            this.largeRadioButton.TabIndex = 3;
            this.largeRadioButton.TabStop = true;
            this.largeRadioButton.Text = "Large(4.99)";
            this.largeRadioButton.UseVisualStyleBackColor = true;
            // 
            // mediumRadioButton
            // 
            this.mediumRadioButton.AutoSize = true;
            this.mediumRadioButton.Location = new System.Drawing.Point(0, 25);
            this.mediumRadioButton.Name = "mediumRadioButton";
            this.mediumRadioButton.Size = new System.Drawing.Size(124, 24);
            this.mediumRadioButton.TabIndex = 2;
            this.mediumRadioButton.TabStop = true;
            this.mediumRadioButton.Text = "Medium(3.09)";
            this.mediumRadioButton.UseVisualStyleBackColor = true;
            // 
            // smallRadioButton
            // 
            this.smallRadioButton.AutoSize = true;
            this.smallRadioButton.Location = new System.Drawing.Point(0, 0);
            this.smallRadioButton.Name = "smallRadioButton";
            this.smallRadioButton.Size = new System.Drawing.Size(107, 24);
            this.smallRadioButton.TabIndex = 1;
            this.smallRadioButton.TabStop = true;
            this.smallRadioButton.Text = "Small(2.39)";
            this.smallRadioButton.UseVisualStyleBackColor = true;
            // 
            // drinkGroupBox
            // 
            this.drinkGroupBox.Controls.Add(this.waterRadioButton);
            this.drinkGroupBox.Controls.Add(this.sodaRadioButton);
            this.drinkGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinkGroupBox.Location = new System.Drawing.Point(185, 263);
            this.drinkGroupBox.Name = "drinkGroupBox";
            this.drinkGroupBox.Size = new System.Drawing.Size(161, 60);
            this.drinkGroupBox.TabIndex = 5;
            this.drinkGroupBox.TabStop = false;
            this.drinkGroupBox.Text = "groupBox3";
            this.drinkGroupBox.Visible = false;
            // 
            // waterRadioButton
            // 
            this.waterRadioButton.AutoSize = true;
            this.waterRadioButton.Location = new System.Drawing.Point(0, 26);
            this.waterRadioButton.Name = "waterRadioButton";
            this.waterRadioButton.Size = new System.Drawing.Size(166, 24);
            this.waterRadioButton.TabIndex = 1;
            this.waterRadioButton.TabStop = true;
            this.waterRadioButton.Text = "Bottled Water(1.49)";
            this.waterRadioButton.UseVisualStyleBackColor = true;
            // 
            // sodaRadioButton
            // 
            this.sodaRadioButton.AutoSize = true;
            this.sodaRadioButton.Location = new System.Drawing.Point(0, -4);
            this.sodaRadioButton.Name = "sodaRadioButton";
            this.sodaRadioButton.Size = new System.Drawing.Size(106, 24);
            this.sodaRadioButton.TabIndex = 0;
            this.sodaRadioButton.TabStop = true;
            this.sodaRadioButton.Text = "Soda(1.69)";
            this.sodaRadioButton.UseVisualStyleBackColor = true;
            // 
            // costButton
            // 
            this.costButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costButton.Location = new System.Drawing.Point(376, 224);
            this.costButton.Name = "costButton";
            this.costButton.Size = new System.Drawing.Size(107, 55);
            this.costButton.TabIndex = 6;
            this.costButton.Text = "Compute Cost of Meal";
            this.costButton.UseVisualStyleBackColor = true;
            this.costButton.Click += new System.EventHandler(this.costButton_Click);
            // 
            // drinkLabel
            // 
            this.drinkLabel.AutoSize = true;
            this.drinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinkLabel.Location = new System.Drawing.Point(156, 241);
            this.drinkLabel.Name = "drinkLabel";
            this.drinkLabel.Size = new System.Drawing.Size(130, 20);
            this.drinkLabel.TabIndex = 0;
            this.drinkLabel.Text = "Choice for Drinks";
            this.drinkLabel.Visible = false;
            // 
            // friesLabel
            // 
            this.friesLabel.AutoSize = true;
            this.friesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.friesLabel.Location = new System.Drawing.Point(156, 139);
            this.friesLabel.Name = "friesLabel";
            this.friesLabel.Size = new System.Drawing.Size(120, 20);
            this.friesLabel.TabIndex = 0;
            this.friesLabel.Text = "Choice for Fries";
            this.friesLabel.Visible = false;
            // 
            // burgerLabel
            // 
            this.burgerLabel.AutoSize = true;
            this.burgerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.burgerLabel.Location = new System.Drawing.Point(156, 24);
            this.burgerLabel.Name = "burgerLabel";
            this.burgerLabel.Size = new System.Drawing.Size(141, 20);
            this.burgerLabel.TabIndex = 7;
            this.burgerLabel.Text = "Choice for Burgers";
            this.burgerLabel.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(375, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cost of meal:";
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costLabel.Location = new System.Drawing.Point(477, 286);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(0, 20);
            this.costLabel.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 321);
            this.Controls.Add(this.friesLabel);
            this.Controls.Add(this.drinkLabel);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.burgerLabel);
            this.Controls.Add(this.costButton);
            this.Controls.Add(this.drinkGroupBox);
            this.Controls.Add(this.friesGroupBox);
            this.Controls.Add(this.burgerGroupBox);
            this.Controls.Add(this.drinksCheckBox);
            this.Controls.Add(this.fryCheckBox);
            this.Controls.Add(this.burgerCheckBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.burgerGroupBox.ResumeLayout(false);
            this.burgerGroupBox.PerformLayout();
            this.friesGroupBox.ResumeLayout(false);
            this.friesGroupBox.PerformLayout();
            this.drinkGroupBox.ResumeLayout(false);
            this.drinkGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox burgerCheckBox;
        private System.Windows.Forms.CheckBox fryCheckBox;
        private System.Windows.Forms.CheckBox drinksCheckBox;
        private System.Windows.Forms.GroupBox burgerGroupBox;
        private System.Windows.Forms.RadioButton bothRadioButton;
        private System.Windows.Forms.RadioButton baconRadioButton;
        private System.Windows.Forms.RadioButton cheeseRadioButton;
        private System.Windows.Forms.RadioButton regularRadioButton;
        private System.Windows.Forms.GroupBox friesGroupBox;
        private System.Windows.Forms.RadioButton largeRadioButton;
        private System.Windows.Forms.RadioButton mediumRadioButton;
        private System.Windows.Forms.RadioButton smallRadioButton;
        private System.Windows.Forms.GroupBox drinkGroupBox;
        private System.Windows.Forms.RadioButton waterRadioButton;
        private System.Windows.Forms.RadioButton sodaRadioButton;
        private System.Windows.Forms.Button costButton;
        private System.Windows.Forms.Label drinkLabel;
        private System.Windows.Forms.Label friesLabel;
        private System.Windows.Forms.Label burgerLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label costLabel;
    }
}

