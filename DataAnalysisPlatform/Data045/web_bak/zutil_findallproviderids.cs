/*
               File: ZUtil_FindAllProviderIDs
        Description: 根据当前登录的账号找到其所有的医院主键
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:35:45.93
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
   public class zutil_findallproviderids : GXProcedure
   {
      public zutil_findallproviderids( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public zutil_findallproviderids( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( out GxSimpleCollection<long> aP0_tJC_ProviderIDs )
      {
         this.AV11tJC_ProviderIDs = new GxSimpleCollection<long>() ;
         initialize();
         executePrivate();
         aP0_tJC_ProviderIDs=this.AV11tJC_ProviderIDs;
      }

      public GxSimpleCollection<long> executeUdp( )
      {
         this.AV11tJC_ProviderIDs = new GxSimpleCollection<long>() ;
         initialize();
         executePrivate();
         aP0_tJC_ProviderIDs=this.AV11tJC_ProviderIDs;
         return AV11tJC_ProviderIDs ;
      }

      public void executeSubmit( out GxSimpleCollection<long> aP0_tJC_ProviderIDs )
      {
         zutil_findallproviderids objzutil_findallproviderids;
         objzutil_findallproviderids = new zutil_findallproviderids();
         objzutil_findallproviderids.AV11tJC_ProviderIDs = new GxSimpleCollection<long>() ;
         objzutil_findallproviderids.context.SetSubmitInitialConfig(context);
         objzutil_findallproviderids.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objzutil_findallproviderids);
         aP0_tJC_ProviderIDs=this.AV11tJC_ProviderIDs;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((zutil_findallproviderids)stateInfo).executePrivate();
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
         GXt_SdtWWPContext1 = AV12WWPContext;
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  GXt_SdtWWPContext1) ;
         AV12WWPContext = GXt_SdtWWPContext1;
         AV11tJC_ProviderIDs.Clear();
         /* Using cursor P001Y2 */
         pr_default.execute(0, new Object[] {AV12WWPContext.gxTpr_Userid});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A6SecUserId = P001Y2_A6SecUserId[0];
            A87JC_ProviderID = P001Y2_A87JC_ProviderID[0];
            AV11tJC_ProviderIDs.Add(A87JC_ProviderID, 0);
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
         AV12WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         GXt_SdtWWPContext1 = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         scmdbuf = "";
         P001Y2_A6SecUserId = new short[1] ;
         P001Y2_A87JC_ProviderID = new long[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.zutil_findallproviderids__default(),
            new Object[][] {
                new Object[] {
               P001Y2_A6SecUserId, P001Y2_A87JC_ProviderID
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short A6SecUserId ;
      private long A87JC_ProviderID ;
      private String scmdbuf ;
      private GxSimpleCollection<long> AV11tJC_ProviderIDs ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] P001Y2_A6SecUserId ;
      private long[] P001Y2_A87JC_ProviderID ;
      private GxSimpleCollection<long> aP0_tJC_ProviderIDs ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV12WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext GXt_SdtWWPContext1 ;
   }

   public class zutil_findallproviderids__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP001Y2 ;
          prmP001Y2 = new Object[] {
          new Object[] {"@AV12WWPContext__Userid",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P001Y2", "SELECT [SecUserId], [JC_ProviderID] FROM [JC_ProviderSecUser] WITH (NOLOCK) WHERE [SecUserId] = @AV12WWPContext__Userid ORDER BY [SecUserId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP001Y2,100,0,false,false )
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
