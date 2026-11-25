using DevExpress.Xpo;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout;
using MOHASEB.Classes;
using MOHASEB.Model;
using MOHASEB.Views.PublicCompounent;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOHASEB.Views.Components.InventoryManagment.SysInitial
{
    public partial class ctrl_Groups : Control_Master
    {

        MOHASEB_DBEntities db;


        EntityOperation.Operation operation;

        int id = 0;
        tbl_Relation_Groups_AccountsSet table;
        tbl_Groups group;
            List<tbl_Relation_Groups_AccountsSet> acc_group_list = new List<tbl_Relation_Groups_AccountsSet>();
        public ctrl_Groups()
        {
            InitializeComponent();
            RefreshData();
            table = new tbl_Relation_Groups_AccountsSet();
            group = new tbl_Groups();
        }
        public override async void RefreshData()
        {
            base.RefreshData();
            db = new MOHASEB_DBEntities();
            // fill ComboBox
            var group_list = await Task.Run(() => db.tbl_Groups.ToList());
           

            if (group_list != null)
            {
                txt_group_name.Properties.DataSource = group_list;

            }


        }
        public override bool IsValidData()
        {

            bool isvalid = false;

            foreach (var item in layoutControl3.Controls)
            {
                if (item is TextEdit)
                {
                    isvalid = (item as TextEdit).ValidatingData();
                }

            }

            if (!isvalid)
                return false;
            else
                return base.IsValidData();
        }
        


        public override void ClearFields(bool enable)
        {
            foreach (var text in layoutControl3.Controls)
            {
                if (text is TextEdit)
                {
                    (text as TextEdit).Text = string.Empty;
                }
            }

            base.ClearFields(enable);
        }
        public override void EnableFields(bool enable)
        {
            // Enable Texts Boxes
            foreach (var text in layoutControl3.Controls)
            {
                if (text is TextEdit)
                {
                    (text as TextEdit).Enabled = enable;
                }
            }

            foreach (var text in layoutControl1.Controls)
            {
                if (text is TextEdit)
                {
                    (text as TextEdit).Enabled = enable;
                }
            }

            base.EnableFields(enable);
        }


        public override void Save()
        {

            if (operation == EntityOperation.Operation.Delete)
            {
                EntityOperation.SqlOperationAsync<tbl_Groups>(new tbl_Groups { G_No = id }, EntityOperation.Operation.Delete);
            }
            else
            {
                SetData();
                EntityOperation.SqlOperationAsync<tbl_Groups>(group, operation);
            }

           base.Save();
        }
        public override void SetData()
        {
            List<tbl_Relation_Groups_AccountsSet> acc_group_list = new List<tbl_Relation_Groups_AccountsSet>();


            acc_group_list.Add(new tbl_Relation_Groups_AccountsSet
            {
                AccGroup_Name = "حساب المبيعات",
                tbl_GroupsG_No = id ,
                tbl_AccountAcc_No = int.Parse(txt_acc_sale_no.Text),
            });
            acc_group_list.Add(new tbl_Relation_Groups_AccountsSet
            {
                AccGroup_Name = "مردود المبيعات",
                tbl_GroupsG_No = id,
                tbl_AccountAcc_No = int.Parse(txt_acc_rt_sale_no.Text),
            });
            acc_group_list.Add(new tbl_Relation_Groups_AccountsSet
            {
                AccGroup_Name = "تكلفة المبيعات",
                tbl_GroupsG_No = id,
                tbl_AccountAcc_No = int.Parse(txt_acc_cost_sale_no.Text),
            });
            acc_group_list.Add(new tbl_Relation_Groups_AccountsSet
            {
                AccGroup_Name = "مشتريات الكميات",
                tbl_GroupsG_No = id,
                tbl_AccountAcc_No = int.Parse(txt_acc_quant_buy_no.Text),
            });
            acc_group_list.Add(new tbl_Relation_Groups_AccountsSet
            {
                AccGroup_Name = "مردود السنوات السابقة",
                tbl_GroupsG_No = id,
                tbl_AccountAcc_No = int.Parse(txt_acc_rt_lastyear_no.Text),
            });
            acc_group_list.Add(new tbl_Relation_Groups_AccountsSet
            {
                AccGroup_Name = "الخصم المكتسب ",
                tbl_GroupsG_No = id,
                tbl_AccountAcc_No = int.Parse(txt_acc_gain_discount_no.Text),
            });
            acc_group_list.Add(new tbl_Relation_Groups_AccountsSet
            {
                AccGroup_Name = "حساب المخزون",
                tbl_GroupsG_No = id,
                tbl_AccountAcc_No = int.Parse(txt_acc_stock_no.Text),
            });

            //acc_group_list.Add(new tbl_Relation_Groups_AccountsSet
            //{
            //    AccGroup_Name = "حساب الخصم المسموح به",
            //tbl_GroupsG_No = int.Parse(txt_group_no.Text),
            //    tbl_AccountAcc_No = int.Parse(layoutControlItem41.Text),
            //});
            //acc_group_list.Add(new tbl_Relation_Groups_AccountsSet
            //{
            //    AccGroup_Name = "تكلفة مردود السنوات السابقه ",
            //tbl_GroupsG_No = int.Parse(txt_group_no.Text),
            //    tbl_AccountAcc_No = int.Parse(txt_acc_cost_rt_lastyear_no.Text),
            //});
            //acc_group_list.Add(new tbl_Relation_Groups_AccountsSet
            //{
            //    AccGroup_Name = "فارق مردودات ",
            //tbl_GroupsG_No = int.Parse(txt_group_no.Text),
            //    tbl_AccountAcc_No = int.Parse(txt_acc_diff_rt_no.Text),
            //});
       


            group = new tbl_Groups();


            //if (operation == EntityOperation.Operation.Delete)
            //{
            //    group.G_No = id;
            //}

            if (operation == EntityOperation.Operation.Update)
            {
                group.G_No = id;
                
                var items = db.tbl_Relation_Groups_AccountsSet.Where(x => x.tbl_GroupsG_No == id).ToList();

                if (items.Count > 0)
                {
                    db.tbl_Relation_Groups_AccountsSet.RemoveRange(items);
                    db.SaveChanges();
                }

                db.tbl_Relation_Groups_AccountsSet.AddRange(acc_group_list);
                    db.SaveChanges();
            }


           
            group.G_Ar_Name = txt_group_name.Text;
            group.G_En_Name = txt_group_en_name.Text;
            group.tbl_Cost_Calculation_TypeId = Convert.ToInt32(txt_Cost_Way_Name.Text);

            base.SetData();
        }

        public override void New()
        {
            operation = EntityOperation.Operation.Add;
            txt_group_no.Focus();
            base.New();
        }

        public override void Edit()
        {
            if (group == null)
            {
                new frm_Notification().ShowAlert("لا بيانات لتعديلها", frm_Notification.AlertType.Error);
                return;
            }
            txt_group_name.Focus();
            operation = EntityOperation.Operation.Update;
            EnableFields(true);
            base.Edit();
        }

        public override void Delete()
        {
            //group = new tbl_Groups();
            if (group == null)
            {
                new frm_Notification().ShowAlert("لا بيانات لحذفها", frm_Notification.AlertType.Error);
                return;
            }
            txt_group_name.Focus(); 
            EnableFields(true);
            operation = EntityOperation.Operation.Delete;
            base.Delete();
        }

        
      
        public override async void GetData()
        {

          

            txt_group_no.Text = Convert.ToString(txt_group_name.EditValue);

            txt_Cost_Way_Name.Text = await db.tbl_Groups
                             .Where(x => x.G_No.ToString() == txt_group_no.Text)
                             .Select(x => x.tbl_Cost_Calculation_TypeId.ToString())
                             .FirstOrDefaultAsync();

            txt_group_en_name.Text= await db.tbl_Groups
                              .Where(x => x.G_No.ToString() == txt_group_no.Text)
                              .Select(x => x.G_En_Name.ToString())
                              .FirstOrDefaultAsync();

            txt_acc_cost_sale_no.Text= await db.tbl_Relation_Groups_AccountsSet
                               .Where(x => x.tbl_GroupsG_No.ToString() == txt_group_no.Text && x.AccGroup_Name == "تكلفة المبيعات")
                               .Select(x => x.tbl_AccountAcc_No.ToString())
                               .FirstOrDefaultAsync();

            txt_acc_sale_no.Text = await db.tbl_Relation_Groups_AccountsSet
                               .Where(x => x.tbl_GroupsG_No.ToString() == txt_group_no.Text && x.AccGroup_Name == "حساب المبيعات")
                               .Select(x => x.tbl_AccountAcc_No.ToString())
                               .FirstOrDefaultAsync();
            txt_acc_stock_no.Text = await db.tbl_Relation_Groups_AccountsSet
                              .Where(x => x.tbl_GroupsG_No.ToString() == txt_group_no.Text && x.AccGroup_Name == "حساب المخزون")
                              .Select(x => x.tbl_AccountAcc_No.ToString())
                              .FirstOrDefaultAsync();
            txt_acc_gain_discount_no.Text = await db.tbl_Relation_Groups_AccountsSet
                              .Where(x => x.tbl_GroupsG_No.ToString() == txt_group_no.Text && x.AccGroup_Name == "الخصم المكتسب ")
                              .Select(x => x.tbl_AccountAcc_No.ToString())
                              .FirstOrDefaultAsync();
            txt_acc_quant_buy_no.Text = await db.tbl_Relation_Groups_AccountsSet
                              .Where(x => x.tbl_GroupsG_No.ToString() == txt_group_no.Text && x.AccGroup_Name == "مشتريات الكميات")
                              .Select(x => x.tbl_AccountAcc_No.ToString())
                              .FirstOrDefaultAsync();
            txt_acc_rt_sale_no.Text = await db.tbl_Relation_Groups_AccountsSet
                              .Where(x => x.tbl_GroupsG_No.ToString() == txt_group_no.Text && x.AccGroup_Name == "مردود المبيعات")
                              .Select(x => x.tbl_AccountAcc_No.ToString())
                              .FirstOrDefaultAsync();
            txt_acc_rt_lastyear_no.Text = await db.tbl_Relation_Groups_AccountsSet
                              .Where(x => x.tbl_GroupsG_No.ToString() == txt_group_no.Text && x.AccGroup_Name == "مردود السنوات السابقة")
                              .Select(x => x.tbl_AccountAcc_No.ToString())
                              .FirstOrDefaultAsync();
            //txt_acc_sale_no.Text = await db.tbl_Relation_Groups_AccountsSet
            //                  .Where(x => x.tbl_GroupsG_No.ToString() == txt_group_no.Text && x.AccGroup_Name == "حساب الخصم المسموح به")
            //                  .Select(x => x.tbl_AccountAcc_No.ToString())
            //                  .FirstOrDefaultAsync();
            //txt_acc_sale_no.Text = await db.tbl_Relation_Groups_AccountsSet
            //                  .Where(x => x.tbl_GroupsG_No.ToString() == txt_group_no.Text && x.AccGroup_Name == "تكلفة مردود السنوات السابقه")
            //                  .Select(x => x.tbl_AccountAcc_No.ToString())
            //                  .FirstOrDefaultAsync();
            //txt_acc_sale_no.Text = await db.tbl_Relation_Groups_AccountsSet
            //                  .Where(x => x.tbl_GroupsG_No.ToString() == txt_group_no.Text && x.AccGroup_Name == "فارق مردودات")
            //                  .Select(x => x.tbl_AccountAcc_No.ToString())
            //                  .FirstOrDefaultAsync();

            //}
            base.GetData();

        }

    
        private void txt_group_name_EditValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_group_name.EditValue.ToString()))
                GetData();
            if (!string.IsNullOrWhiteSpace(txt_group_no.Text))
                id = Convert.ToInt32(txt_group_no.Text);
        }












        //private async void btn_save_click(object sender, EventArgs e)
        //{


        //    List<tbl_Relation_Groups_AccountsSet> acc_group_list = new List<tbl_Relation_Groups_AccountsSet>();




        //    // add
        //    if (operation == EntityOperation.Operation.Add)
        //    {
        //        foreach (var item in layoutControl1.Controls)
        //        {
        //            var acc = item as LayoutControlItem;
        //            if (item is LayoutControlItem)
        //            {
        //                MessageBox.Show(acc.Control.Text + "::::" + acc.Text);
        //                acc_group_list.Add(new tbl_Relation_Groups_AccountsSet
        //                {
        //                    AccGroup_Name = acc.Text,
        //                    tbl_GroupsG_No = int.Parse(txt_group_no.Text),
        //                    tbl_AccountAcc_No = int.Parse(acc.Control.Text),
        //                });
        //            }
        //        }


        //        foreach (var item in acc_group_list)
        //        {
        //            MessageBox.Show(item.AccGroup_Name + " : " + item.tbl_AccountAcc_No.ToString());
        //        }


        //        group = new tbl_Groups
        //        {
        //            G_No = int.Parse(txt_group_no.Text),
        //            G_Ar_Name = txt_group_name.Text,
        //            G_En_Name = txt_group_en_name.Text,
        //            tbl_Cost_Calculation_TypeId = Convert.ToInt32(txt_Cost_Way_Name.Text),
        //            tbl_Relation_Groups_AccountsSet = acc_group_list,
        //        };
        //        await EntityOperation.SqlOperationAsync<tbl_Groups>(group, operation);

        //        //foreach (var item in layoutControl1.Controls)
        //        //{
        //        //    if (item is LayoutControlItem)
        //        //    {
        //        //        var acc = item as LayoutControlItem;
        //        //        acc_group_list.Add(new tbl_Relation_Groups_AccountsSet
        //        //        {
        //        //            AccGroup_Name = acc.Text,
        //        //            tbl_GroupsG_No =1,
        //        //            tbl_AccountAcc_No = int.Parse(acc.Control.Text),
        //        //        });
        //        //    }
        //        //}


        //        //foreach (var item in acc_group_list)
        //        //{
        //        //    XtraMessageBox.Show(item.AccGroup_Name + " : " + item.tbl_AccountAcc_No.ToString());
        //        //}
        //    }
        //    else // edit
        //    {
        //        // foreach (var item in layoutControl1.Controls)
        //        //{
        //        //    var acc = item as LayoutControlItem;
        //        //    if (item is LayoutControlItem)
        //        //    {
        //        //        MessageBox.Show(acc.Control.Text + "::::" + acc.Text);
        //        //        acc_group_list.Add(new tbl_Relation_Groups_AccountsSet
        //        //        {
        //        //            AccGroup_Name = acc.Text,
        //        //            tbl_GroupsG_No = int.Parse(txt_group_no.Text),
        //        //            tbl_AccountAcc_No = int.Parse(acc.Control.Text),
        //        //        });
        //        //    }
        //        //}


        //        acc_group_list.Add(new tbl_Relation_Groups_AccountsSet
        //        {
        //            AccGroup_Name = "حساب المبيعات",
        //            tbl_GroupsG_No = int.Parse(txt_group_no.Text),
        //            tbl_AccountAcc_No = int.Parse(txt_acc_sale_no.Text),
        //        });
        //        //acc_group_list.Add(new tbl_Relation_Groups_AccountsSet
        //        //{
        //        //    AccGroup_Name = "مردود المبيعات",
        //        // tbl_GroupsG_No = int.Parse(txt_group_no.Text),
        //        //    tbl_AccountAcc_No = int.Parse(txt_acc_rt_sale_no.Text),
        //        //});
        //        acc_group_list.Add(new tbl_Relation_Groups_AccountsSet
        //        {
        //            AccGroup_Name = "تكلفة المبيعات",
        //            tbl_GroupsG_No = int.Parse(txt_group_no.Text),
        //            tbl_AccountAcc_No = int.Parse(txt_acc_cost_sale_no.Text),
        //        });
        //        acc_group_list.Add(new tbl_Relation_Groups_AccountsSet
        //        {
        //            AccGroup_Name = "مشتريات الكميات",
        //            tbl_GroupsG_No = int.Parse(txt_group_no.Text),
        //            tbl_AccountAcc_No = int.Parse(txt_acc_quant_buy_no.Text),
        //        });
        //        //acc_group_list.Add(new tbl_Relation_Groups_AccountsSet
        //        //{
        //        //    AccGroup_Name = "مردود السنوات السابقة",
        //        //tbl_GroupsG_No = int.Parse(txt_group_no.Text),
        //        //    tbl_AccountAcc_No = int.Parse(layoutControlItem40.Text),
        //        //});
        //        //acc_group_list.Add(new tbl_Relation_Groups_AccountsSet
        //        //{
        //        //    AccGroup_Name = "حساب الخصم المسموح به",
        //        //tbl_GroupsG_No = int.Parse(txt_group_no.Text),
        //        //    tbl_AccountAcc_No = int.Parse(layoutControlItem41.Text),
        //        //});
        //        //acc_group_list.Add(new tbl_Relation_Groups_AccountsSet
        //        //{
        //        //    AccGroup_Name = "تكلفة مردود السنوات السابقه ",
        //        //tbl_GroupsG_No = int.Parse(txt_group_no.Text),
        //        //    tbl_AccountAcc_No = int.Parse(txt_acc_cost_rt_lastyear_no.Text),
        //        //});
        //        //acc_group_list.Add(new tbl_Relation_Groups_AccountsSet
        //        //{
        //        //    AccGroup_Name = "فارق مردودات ",
        //        //tbl_GroupsG_No = int.Parse(txt_group_no.Text),
        //        //    tbl_AccountAcc_No = int.Parse(txt_acc_diff_rt_no.Text),
        //        //});
        //        acc_group_list.Add(new tbl_Relation_Groups_AccountsSet
        //        {
        //            AccGroup_Name = "الخصم المكتسب ",
        //            tbl_GroupsG_No = int.Parse(txt_group_no.Text),
        //            tbl_AccountAcc_No = int.Parse(txt_acc_gain_discount_no.Text),
        //        });
        //        acc_group_list.Add(new tbl_Relation_Groups_AccountsSet
        //        {
        //            AccGroup_Name = "حساب المخزون",
        //            tbl_GroupsG_No = int.Parse(txt_group_no.Text),
        //            tbl_AccountAcc_No = int.Parse(txt_acc_stock_no.Text),
        //        });

        //        foreach (var item in acc_group_list)
        //        {
        //            MessageBox.Show(item.AccGroup_Name + " : " + item.tbl_AccountAcc_No.ToString());
        //        }


        //        group = new tbl_Groups
        //        {
        //            G_No = int.Parse(txt_group_no.Text),
        //            G_Ar_Name = txt_group_name.Text,
        //            G_En_Name = txt_group_en_name.Text,
        //            tbl_Cost_Calculation_TypeId = Convert.ToInt32(txt_Cost_Way_Name.Text),
        //            tbl_Relation_Groups_AccountsSet = acc_group_list,
        //        };
        //        await EntityOperation.SqlOperationAsync<tbl_Groups>(group, operation);

        //    }
        //}
    }
}

