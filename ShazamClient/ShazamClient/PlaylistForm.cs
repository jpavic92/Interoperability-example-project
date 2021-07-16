using ShazamClient.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShazamClient
{
    public partial class PlaylistForm : Form
    {
        private PlaylistTrack[] playlist;
        public PlaylistForm(PlaylistTrack[] playlist)
        {
            InitializeComponent();
            this.playlist = playlist;
            //lbPlaylist.Items.AddRange(playlist);

            for (int i = 0; i < playlist.Length; i++)
            {
                tlpPlaylist.Controls.Add(new Label { Text = (i + 1).ToString()}, 0, i);
                tlpPlaylist.Controls.Add(new Label { Text = playlist[i].ToString(), Anchor = AnchorStyles.Left,  AutoSize = true }, 1, i);
            }
        }
    }
}
