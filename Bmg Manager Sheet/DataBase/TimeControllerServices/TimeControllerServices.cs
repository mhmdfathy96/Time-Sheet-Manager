using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BmgManagerSheet.Models;
using Google.Cloud.Firestore;

namespace BmgManagerSheet.DataBase.TimeControllerServices
{
    class TimeControllerServices:AttendanceServices
    {
        public async Task<dynamic> SetSettings(TimeController timeController)
        {
            try
            {
               DocumentReference docRef= db.Collection("Controller").Document("Settings");
                await docRef.SetAsync(TimeControllertoJson(timeController));
            }
            catch {
             //   MessageBox.Show(e.Message);
            }
            return "";
        }

        public async Task<dynamic> UpdateSettings(TimeController timeController)
        {
            try
            {
                DocumentReference docRef = db.Collection("Controller").Document("Settings");
                await docRef.UpdateAsync(TimeControllertoJson(timeController));
            }
            catch 
            {
                //MessageBox.Show(e.Message);
            }
            return "";
        }

        public async Task<dynamic> GetSettings() {
            TimeController timeController = null;
            try
            {
                DocumentReference docRef = db.Collection("Controller").Document("Settings");
               DocumentSnapshot docSnap= await docRef.GetSnapshotAsync();
                timeController = TimeControllerfromJson(docSnap);
            }
            catch
            {
          //      MessageBox.Show(e.Message);
            }
            return timeController;
        }
    }
}
