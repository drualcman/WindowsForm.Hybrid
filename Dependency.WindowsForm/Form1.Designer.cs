﻿namespace Dependency.WindowsForm;

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
        label1 = new Label();
        txtProductId = new TextBox();
        btnSearch = new Button();
        lblResult = new Label();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(34, 23);
        label1.Name = "label1";
        label1.Size = new Size(18, 15);
        label1.TabIndex = 0;
        label1.Text = "ID";
        // 
        // txtProductId
        // 
        txtProductId.Location = new Point(91, 15);
        txtProductId.Name = "txtProductId";
        txtProductId.Size = new Size(100, 23);
        txtProductId.TabIndex = 1;
        // 
        // btnSearch
        // 
        btnSearch.Location = new Point(197, 14);
        btnSearch.Name = "btnSearch";
        btnSearch.Size = new Size(178, 23);
        btnSearch.TabIndex = 2;
        btnSearch.Text = "Buscar Product";
        btnSearch.UseVisualStyleBackColor = true;
        btnSearch.Click += btnSearch_Click;
        // 
        // lblResult
        // 
        lblResult.AutoSize = true;
        lblResult.Location = new Point(34, 48);
        lblResult.Name = "lblResult";
        lblResult.Size = new Size(0, 15);
        lblResult.TabIndex = 3;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(lblResult);
        Controls.Add(btnSearch);
        Controls.Add(txtProductId);
        Controls.Add(label1);
        Name = "Form1";
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private TextBox txtProductId;
    private Button btnSearch;
    private Label lblResult;
}
