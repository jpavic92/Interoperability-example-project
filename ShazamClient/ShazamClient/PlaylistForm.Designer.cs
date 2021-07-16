namespace ShazamClient
{
    partial class PlaylistForm
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
            this.lbPlaylist = new System.Windows.Forms.ListBox();
            this.tlpPlaylist = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // lbPlaylist
            // 
            this.lbPlaylist.FormattingEnabled = true;
            this.lbPlaylist.ItemHeight = 16;
            this.lbPlaylist.Location = new System.Drawing.Point(0, 0);
            this.lbPlaylist.Name = "lbPlaylist";
            this.lbPlaylist.Size = new System.Drawing.Size(330, 340);
            this.lbPlaylist.TabIndex = 0;
            // 
            // tlpPlaylist
            // 
            this.tlpPlaylist.AutoScroll = true;
            this.tlpPlaylist.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpPlaylist.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tlpPlaylist.ColumnCount = 2;
            this.tlpPlaylist.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpPlaylist.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.5F));
            this.tlpPlaylist.Location = new System.Drawing.Point(0, 0);
            this.tlpPlaylist.Name = "tlpPlaylist";
            this.tlpPlaylist.RowCount = 1;
            this.tlpPlaylist.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpPlaylist.Size = new System.Drawing.Size(330, 340);
            this.tlpPlaylist.TabIndex = 1;
            // 
            // PlaylistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(330, 342);
            this.Controls.Add(this.tlpPlaylist);
            this.Controls.Add(this.lbPlaylist);
            this.Name = "PlaylistForm";
            this.Text = "PlaylistForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbPlaylist;
        private System.Windows.Forms.TableLayoutPanel tlpPlaylist;
    }
}