﻿//---------------------------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated by T4Model template for T4 (https://github.com/linq2db/t4models).
//    Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
//---------------------------------------------------------------------------------------------------
using System;
using System.Linq;

using LinqToDB;
using LinqToDB.Mapping;

namespace DataModels
{
    /// <summary>
    /// Database       : gcmtsrv_demo
    /// Data Source    : 144.76.65.108
    /// Server Version : 5.6.11
    /// </summary>
    public partial class GcmtsrvDemoDB : LinqToDB.Data.DataConnection
    {
        public ITable<Mt4Config> Mt4Config { get { return this.GetTable<Mt4Config>(); } }
        public ITable<Mt4Prices> Mt4Prices { get { return this.GetTable<Mt4Prices>(); } }
        public ITable<Mt4Trades> Mt4Trades { get { return this.GetTable<Mt4Trades>(); } }
        public ITable<Mt4Users> Mt4Users { get { return this.GetTable<Mt4Users>(); } }

        public GcmtsrvDemoDB()
        {
            InitDataContext();
        }

        public GcmtsrvDemoDB(string configuration)
            : base(configuration)
        {
            InitDataContext();
        }

        partial void InitDataContext();
    }

    [Table("mt4_config")]
    public partial class Mt4Config
    {
        [Column(), PrimaryKey, NotNull] public int CONFIG { get; set; } // int(11)
        [Column(@"VALUE_INT"), Nullable] public int? VALUEINT { get; set; } // int(11)
        [Column(@"VALUE_STR"), Nullable] public string VALUESTR { get; set; } // char(255)
    }

    [Table("mt4_prices")]
    public partial class Mt4Prices
    {
        [Column(), PrimaryKey, NotNull] public string SYMBOL { get; set; } // char(16)
        [Column(), NotNull] public DateTime TIME { get; set; } // datetime
        [Column(), NotNull] public double BID { get; set; } // double
        [Column(), NotNull] public double ASK { get; set; } // double
        [Column(), NotNull] public double LOW { get; set; } // double
        [Column(), NotNull] public double HIGH { get; set; } // double
        [Column(), NotNull] public int DIRECTION { get; set; } // int(11)
        [Column(), NotNull] public int DIGITS { get; set; } // int(11)
        [Column(), NotNull] public int SPREAD { get; set; } // int(11)
        [Column(@"MODIFY_TIME"), NotNull] public DateTime MODIFYTIME { get; set; } // datetime
    }

    [Table("mt4_trades")]
    public partial class Mt4Trades
    {
        [Column(), PrimaryKey, NotNull] public int TICKET { get; set; } // int(11)
        [Column(), NotNull] public int LOGIN { get; set; } // int(11)
        [Column(), NotNull] public string SYMBOL { get; set; } // char(16)
        [Column(), NotNull] public int DIGITS { get; set; } // int(11)
        [Column(), NotNull] public int CMD { get; set; } // int(11)
        [Column(), NotNull] public int VOLUME { get; set; } // int(11)
        [Column(@"OPEN_TIME"), NotNull] public DateTime OPENTIME { get; set; } // datetime
        [Column(@"OPEN_PRICE"), NotNull] public double OPENPRICE { get; set; } // double
        [Column(), NotNull] public double SL { get; set; } // double
        [Column(), NotNull] public double TP { get; set; } // double
        [Column(@"CLOSE_TIME"), NotNull] public DateTime CLOSETIME { get; set; } // datetime
        [Column(), NotNull] public DateTime EXPIRATION { get; set; } // datetime
        [Column(@"CONV_RATE1"), NotNull] public double CONVRATE1 { get; set; } // double
        [Column(@"CONV_RATE2"), NotNull] public double CONVRATE2 { get; set; } // double
        [Column(), NotNull] public double COMMISSION { get; set; } // double
        [Column(@"COMMISSION_AGENT"), NotNull] public double COMMISSIONAGENT { get; set; } // double
        [Column(), NotNull] public double SWAPS { get; set; } // double
        [Column(@"CLOSE_PRICE"), NotNull] public double CLOSEPRICE { get; set; } // double
        [Column(), NotNull] public double PROFIT { get; set; } // double
        [Column(), NotNull] public double TAXES { get; set; } // double
        [Column(), NotNull] public string COMMENT { get; set; } // char(32)
        [Column(@"INTERNAL_ID"), NotNull] public int INTERNALID { get; set; } // int(11)
        [Column(@"MARGIN_RATE"), NotNull] public double MARGINRATE { get; set; } // double
        [Column(), NotNull] public int TIMESTAMP { get; set; } // int(11)
        [Column(@"MODIFY_TIME"), NotNull] public DateTime MODIFYTIME { get; set; } // datetime
    }

    [Table("mt4_users")]
    public partial class Mt4Users
    {
        [Column(), PrimaryKey, NotNull] public int LOGIN { get; set; } // int(11)
        [Column(), NotNull] public string GROUP { get; set; } // char(16)
        [Column(), NotNull] public int ENABLE { get; set; } // int(11)
        [Column(@"ENABLE_CHANGE_PASS"), NotNull] public int ENABLECHANGEPASS { get; set; } // int(11)
        [Column(@"ENABLE_READONLY"), NotNull] public int ENABLEREADONLY { get; set; } // int(11)
        [Column(@"PASSWORD_PHONE"), NotNull] public string PASSWORDPHONE { get; set; } // char(32)
        [Column(), NotNull] public string NAME { get; set; } // char(128)
        [Column(), NotNull] public string COUNTRY { get; set; } // char(32)
        [Column(), NotNull] public string CITY { get; set; } // char(32)
        [Column(), NotNull] public string STATE { get; set; } // char(32)
        [Column(), NotNull] public string ZIPCODE { get; set; } // char(16)
        [Column(), NotNull] public string ADDRESS { get; set; } // char(128)
        [Column(), NotNull] public string PHONE { get; set; } // char(32)
        [Column(), NotNull] public string EMAIL { get; set; } // char(48)
        [Column(), NotNull] public string COMMENT { get; set; } // char(64)
        [Column(), NotNull] public string ID { get; set; } // char(32)
        [Column(), NotNull] public string STATUS { get; set; } // char(16)
        [Column(), NotNull] public DateTime REGDATE { get; set; } // datetime
        [Column(), NotNull] public DateTime LASTDATE { get; set; } // datetime
        [Column(), NotNull] public int LEVERAGE { get; set; } // int(11)
        [Column(@"AGENT_ACCOUNT"), NotNull] public int AGENTACCOUNT { get; set; } // int(11)
        [Column(), NotNull] public int TIMESTAMP { get; set; } // int(11)
        [Column(), NotNull] public double BALANCE { get; set; } // double
        [Column(), NotNull] public double PREVMONTHBALANCE { get; set; } // double
        [Column(), NotNull] public double PREVBALANCE { get; set; } // double
        [Column(), NotNull] public double CREDIT { get; set; } // double
        [Column(), NotNull] public double INTERESTRATE { get; set; } // double
        [Column(), NotNull] public double TAXES { get; set; } // double
        [Column(@"SEND_REPORTS"), NotNull] public int SENDREPORTS { get; set; } // int(11)
        [Column(@"USER_COLOR"), NotNull] public int USERCOLOR { get; set; } // int(11)
        [Column(), NotNull] public double EQUITY { get; set; } // double
        [Column(), NotNull] public double MARGIN { get; set; } // double
        [Column(@"MARGIN_LEVEL"), NotNull] public double MARGINLEVEL { get; set; } // double
        [Column(@"MARGIN_FREE"), NotNull] public double MARGINFREE { get; set; } // double
        [Column(@"API_DATA"), Nullable] public byte[] APIDATA { get; set; } // blob
        [Column(@"MODIFY_TIME"), NotNull] public DateTime MODIFYTIME { get; set; } // datetime
    }

    public static partial class TableExtensions
    {
        public static Mt4Config Find(this ITable<Mt4Config> table, int CONFIG)
        {
            return table.FirstOrDefault(t =>
                t.CONFIG == CONFIG);
        }

        public static Mt4Prices Find(this ITable<Mt4Prices> table, string SYMBOL)
        {
            return table.FirstOrDefault(t =>
                t.SYMBOL == SYMBOL);
        }

        public static Mt4Trades Find(this ITable<Mt4Trades> table, int TICKET)
        {
            return table.FirstOrDefault(t =>
                t.TICKET == TICKET);
        }

        public static Mt4Users Find(this ITable<Mt4Users> table, int LOGIN)
        {
            return table.FirstOrDefault(t =>
                t.LOGIN == LOGIN);
        }
    }
}
