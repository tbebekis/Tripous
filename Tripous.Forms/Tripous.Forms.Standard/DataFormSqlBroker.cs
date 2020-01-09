using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tripous.Data;
using Tripous.Model;

namespace Tripous.Forms.Standard
{
    /// <summary>
    /// A data form that uses an <see cref="SqlBroker"/>
    /// </summary>
    public partial class DataFormSqlBroker : DataFormStandard
    {
        protected SqlBroker Broker;
        protected SelectSql MainSelectSql;
        

        /// <summary>
        /// Processes the form options
        /// </summary>
        protected override void ProcessFormOptions()
        {
            base.ProcessFormOptions();

            PrepareBroker();
        }
        protected override void ListSelect()
        {
            if (MainSelectSql.Table.Columns.Count == 0)
            {
                Broker.SelectBrowser(MainSelectSql.Table, MainSelectSql.Text);
                MainSelectSql.SetupTable(MainSelectSql.Table);
                this.gridList.DataSource = MainSelectSql.Table;
                this.gridList.SetupGridColumns(MainSelectSql.Table);
                this.gridList.InitializeReadOnly();

                if (MainSelectSql.Table.Rows.Count <= 2500)
                    this.gridList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
 
            }         

        }
        protected virtual void PrepareBroker()
        {
            if (Options != null)
            {
                BrokerDescriptor BrokerDes = null;
                Broker = Options.Params.ValueOf("Broker", (SqlBroker)null);
                if (Broker == null)
                { 
                    BrokerDes = Options.Params.ValueOf("BrokerDescriptor", (BrokerDescriptor)null);

                    if (BrokerDes == null && !string.IsNullOrWhiteSpace(Options.BrokerName))
                    {
                        BrokerDes = Registry.Brokers.Find(Options.BrokerName);
                    }

                    if (BrokerDes != null)
                    {
                        Broker = Tripous.Model.Broker.Create(BrokerDes, true, IsListForm) as SqlBroker;
                    }
                }
            }
 
            if (Broker != null)
            {
                Broker.Owner = this;
                Options.Params["Broker"] = Broker;
            }
            else
            {
                Sys.Error("Can not create broker");
            }

            SelectSql SS = Broker.Descriptor.SelectList.Find(Sys.MainSelect);
            MainSelectSql = SS.CloneObject();
            MainSelectSql.Table = new MemTable();
        }


        /* construction */
        /// <summary>
        /// Constructor
        /// </summary>
        public DataFormSqlBroker()
        {
            InitializeComponent();
        }
    }
}
