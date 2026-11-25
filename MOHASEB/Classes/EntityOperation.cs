using ComponentFactory.Krypton.Toolkit;
using MOHASEB.Model;
using MOHASEB.Views.PublicCompounent;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOHASEB.Classes
{
    public static class EntityOperation
    {
        public static bool state = false;

        /// <summary>
        /// نوع العملية (إظافة - تعديل - حذف ) التي ستطبق على الجدول 
        /// </summary>
        public enum Operation
        {
            Add,
            Update,
            Delete,
            Search,
            Nothing
        }

        /// <summary>
        /// الدالة التي ستطبق العملية على الجدول
        /// </summary>
        /// <typeparam name="Table"> نوع الجدول الذي ستنفذ العملية علية </typeparam>
        /// <param name="table"> المتغير الذي يحتوي على الببانات </param>
        /// <param name="operation"> نوع العملية (إظافة - تعديل - حذف ) التي ستطبق على الجدول  </param>
        public static async Task SqlOperationAsync<Table>(Table table, Operation operation)
        {
            try
            {
                    switch (operation)
                    {
                        case Operation.Add:
                            await Task.Run(() => Session.DB.Entry(table).State = EntityState.Added);
                            state = true;
                            break;
                        case Operation.Update:
                            await Task.Run(() => Session.DB.Entry(table).State = EntityState.Modified);
                            state = true;
                            break;
                        case Operation.Delete:
                            await Task.Run(() => Session.DB.Entry(table).State = EntityState.Deleted);
                            state = true;
                            break;
                        default:
                            break;
                    }

                    await Session.DB.SaveChangesAsync();


                if (state == true)
                {
                    new frm_Notification().ShowAlert("تمت العملية بنجاح", frm_Notification.AlertType.success);
                }
                else
                {
                    new frm_Notification().ShowAlert("هناك مشكلة في في إجراء العملية", frm_Notification.AlertType.Warning);
                }
            }
            catch
            {
                //MessageBox.Show(ex.InnerException.ToString());
                new frm_Notification().ShowAlert("هناك مشكلة في الإتصال بالسيرفر", frm_Notification.AlertType.Warning);
            }

        }  
        

    }
}
