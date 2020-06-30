/*
               File: ZBR_FindProviderId
        Description: 找到一个默认的当前用户的医院ID
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 11:55:2.62
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
   public class zbr_findproviderid : GXProcedure
   {
      public zbr_findproviderid( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public zbr_findproviderid( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( out long aP0_oJC_ProviderID )
      {
         this.AV9oJC_ProviderID = 0 ;
         initialize();
         executePrivate();
         aP0_oJC_ProviderID=this.AV9oJC_ProviderID;
      }

      public long executeUdp( )
      {
         this.AV9oJC_ProviderID = 0 ;
         initialize();
         executePrivate();
         aP0_oJC_ProviderID=this.AV9oJC_ProviderID;
         return AV9oJC_ProviderID ;
      }

      public void executeSubmit( out long aP0_oJC_ProviderID )
      {
         zbr_findproviderid objzbr_findproviderid;
         objzbr_findproviderid = new zbr_findproviderid();
         objzbr_findproviderid.AV9oJC_ProviderID = 0 ;
         objzbr_findproviderid.context.SetSubmitInitialConfig(context);
         objzbr_findproviderid.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objzbr_findproviderid);
         aP0_oJC_ProviderID=this.AV9oJC_ProviderID;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((zbr_findproviderid)stateInfo).executePrivate();
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
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV8WWPContext) ;
         /* Using cursor P00252 */
         pr_default.execute(0, new Object[] {AV8WWPContext.gxTpr_Userid});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A6SecUserId = P00252_A6SecUserId[0];
            A87JC_ProviderID = P00252_A87JC_ProviderID[0];
            AV9oJC_ProviderID = A87JC_ProviderID;
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
         AV8WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         scmdbuf = "";
         P00252_A6SecUserId = new short[1] ;
         P00252_A87JC_ProviderID = new long[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.zbr_findproviderid__default(),
            new Object[][] {
                new Object[] {
               P00252_A6SecUserId, P00252_A87JC_ProviderID
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short A6SecUserId ;
      private long AV9oJC_ProviderID ;
      private long A87JC_ProviderID ;
      private String scmdbuf ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] P00252_A6SecUserId ;
      private long[] P00252_A87JC_ProviderID ;
      private long aP0_oJC_ProviderID ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV8WWPContext ;
   }

   public class zbr_findproviderid__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP00252 ;
          prmP00252 = new Object[] {
          new Object[] {"@AV8WWPContext__Userid",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00252", "SELECT TOP 1 [SecUserId], [JC_ProviderID] FROM [JC_ProviderSecUser] WITH (NOLOCK) WHERE [SecUserId] = @AV8WWPContext__Userid ORDER BY [SecUserId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00252,1,0,false,true )
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
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((long[]) buf[1])[0] = rslt.getLong(2) ;
                return;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
             case 0 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
       }
    }

 }

}
