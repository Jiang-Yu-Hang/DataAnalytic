/*
               File: ZXT_GetSystemConfig
        Description: 获得当前系统的配置信息
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 11:55:15.33
       Program type: Callable routine
          Main DBMS: SQL Server
*/
using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using GeneXus.Cryptography;
using System.Data;
using GeneXus.Data;
using com.genexus;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using GeneXus.WebControls;
using GeneXus.Http;
using GeneXus.Procedure;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Threading;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class zxt_getsystemconfig : GXProcedure
   {
      public zxt_getsystemconfig( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public zxt_getsystemconfig( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( out String aP0_oIpAddress )
      {
         this.AV8oIpAddress = "" ;
         initialize();
         executePrivate();
         aP0_oIpAddress=this.AV8oIpAddress;
      }

      public String executeUdp( )
      {
         this.AV8oIpAddress = "" ;
         initialize();
         executePrivate();
         aP0_oIpAddress=this.AV8oIpAddress;
         return AV8oIpAddress ;
      }

      public void executeSubmit( out String aP0_oIpAddress )
      {
         zxt_getsystemconfig objzxt_getsystemconfig;
         objzxt_getsystemconfig = new zxt_getsystemconfig();
         objzxt_getsystemconfig.AV8oIpAddress = "" ;
         objzxt_getsystemconfig.context.SetSubmitInitialConfig(context);
         objzxt_getsystemconfig.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objzxt_getsystemconfig);
         aP0_oIpAddress=this.AV8oIpAddress;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((zxt_getsystemconfig)stateInfo).executePrivate();
         }
         catch ( Exception e )
         {
            GXUtil.SaveToEventLog( "VersionAssociateWMicro", e);
            throw e ;
         }
      }

      void executePrivate( )
      {
         /* GeneXus formulas */
         /* Output device settings */
         /* Using cursor P00362 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A196XT_ConfigKey = P00362_A196XT_ConfigKey[0];
            n196XT_ConfigKey = P00362_n196XT_ConfigKey[0];
            A197XT_ConfigValue1 = P00362_A197XT_ConfigValue1[0];
            n197XT_ConfigValue1 = P00362_n197XT_ConfigValue1[0];
            A195XT_ConfigID = P00362_A195XT_ConfigID[0];
            AV8oIpAddress = A197XT_ConfigValue1;
            /* Exit For each command. Update data (if necessary), close cursors & exit. */
            if (true) break;
            pr_default.readNext(0);
         }
         pr_default.close(0);
         this.cleanup();
      }

      public override void cleanup( )
      {
         CloseOpenCursors();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
         exitApplication();
      }

      protected void CloseOpenCursors( )
      {
      }

      public override void initialize( )
      {
         scmdbuf = "";
         P00362_A196XT_ConfigKey = new String[] {""} ;
         P00362_n196XT_ConfigKey = new bool[] {false} ;
         P00362_A197XT_ConfigValue1 = new String[] {""} ;
         P00362_n197XT_ConfigValue1 = new bool[] {false} ;
         P00362_A195XT_ConfigID = new long[1] ;
         A196XT_ConfigKey = "";
         A197XT_ConfigValue1 = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.zxt_getsystemconfig__default(),
            new Object[][] {
                new Object[] {
               P00362_A196XT_ConfigKey, P00362_n196XT_ConfigKey, P00362_A197XT_ConfigValue1, P00362_n197XT_ConfigValue1, P00362_A195XT_ConfigID
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private long A195XT_ConfigID ;
      private String scmdbuf ;
      private bool n196XT_ConfigKey ;
      private bool n197XT_ConfigValue1 ;
      private String AV8oIpAddress ;
      private String A196XT_ConfigKey ;
      private String A197XT_ConfigValue1 ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] P00362_A196XT_ConfigKey ;
      private bool[] P00362_n196XT_ConfigKey ;
      private String[] P00362_A197XT_ConfigValue1 ;
      private bool[] P00362_n197XT_ConfigValue1 ;
      private long[] P00362_A195XT_ConfigID ;
      private String aP0_oIpAddress ;
   }

   public class zxt_getsystemconfig__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP00362 ;
          prmP00362 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("P00362", "SELECT TOP 1 [XT_ConfigKey], [XT_ConfigValue1], [XT_ConfigID] FROM [XT_Config] WITH (NOLOCK) WHERE [XT_ConfigKey] = '系统IP地址' ORDER BY [XT_ConfigID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00362,1,0,false,true )
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
             case 0 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((long[]) buf[4])[0] = rslt.getLong(3) ;
                return;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
       }
    }

 }

}
