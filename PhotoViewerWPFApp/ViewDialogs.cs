using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PhotoViewerWPFApp
{
    internal class ViewDialogs
    {
        public string GetPathToPicture()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Obrazy JPG|*.jpg |Obrazy JPEG|*.jpeg |Obrazy PNG|*.png";

            if (openFileDialog.ShowDialog() == true)
            {
                return openFileDialog.FileName;
            }
            else
            {
                MessageBox.Show("Nie wybrano pliku!");
                return null;
            }
        }
    }
}
