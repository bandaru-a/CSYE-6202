﻿namespace Airline_Reservation
{
    partial class PassengersWin
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
            this.dgPassengers = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgPassengers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgPassengers
            // 
            this.dgPassengers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPassengers.Location = new System.Drawing.Point(12, 76);
            this.dgPassengers.Name = "dgPassengers";
            this.dgPassengers.RowTemplate.Height = 24;
            this.dgPassengers.Size = new System.Drawing.Size(631, 367);
            this.dgPassengers.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(228, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Passengers List";
            // 
            // PassengersWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(655, 455);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgPassengers);
            this.Name = "PassengersWin";
            this.Text = "PassengersWin";
            this.Load += new System.EventHandler(this.PassengersWin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPassengers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgPassengers;
        private System.Windows.Forms.Label label1;
    }
}