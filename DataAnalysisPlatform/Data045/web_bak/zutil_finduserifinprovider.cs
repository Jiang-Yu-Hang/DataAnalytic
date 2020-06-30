/*
               File: ZUtil_FindUserIfInProvider
        Description: 查找这些分院下有什么人
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:35:21.65
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
   public class zutil_finduserifinprovider : GXProcedure
   {
      public zutil_finduserifinprovider( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public zutil_finduserifinprovider( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( GxSimpleCollection<long> aP0_iJC_ProviderIDs ,
                           out GxSimpleCollection<short> aP1_oSecUserIds )
      {
         this.AV8iJC_ProviderIDs = aP0_iJC_ProviderIDs;
         this.AV9oSecUserIds = new GxSimpleCollection<short>() ;
         initialize();
         executePrivate();
         aP1_oSecUserIds=this.AV9oSecUserIds;
      }

      public GxSimpleCollection<short> executeUdp( GxSimpleCollection<long> aP0_iJC_ProviderIDs )
      {
         this.AV8iJC_ProviderIDs = aP0_iJC_ProviderIDs;
         this.AV9oSecUserIds = new GxSimpleCollection<short>() ;
         initialize();
         executePrivate();
         aP1_oSecUserIds=this.AV9oSecUserIds;
         return AV9oSecUserIds ;
      }

      public void executeSubmit( GxSimpleCollection<long> aP0_iJC_ProviderIDs ,
                                 out GxSimpleCollection<short> aP1_oSecUserIds )
      {
         zutil_finduserifinprovider objzutil_finduserifinprovider;
         objzutil_finduserifinprovider = new zutil_finduserifinprovider();
         objzutil_finduserifinprovider.AV8iJC_ProviderIDs = aP0_iJC_ProviderIDs;
         objzutil_finduserifinprovider.AV9oSecUserIds = new GxSimpleCollection<short>() ;
         objzutil_finduserifinprovider.context.SetSubmitInitialConfig(context);
         objzutil_finduserifinprovider.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objzutil_finduserifinprovider);
         aP1_oSecUserIds=this.AV9oSecUserIds;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((zutil_finduserifinprovider)stateInfo).executePrivate();
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
         pr_default.dynParam(0, new Object[]{ new Object[]{
                                              A87JC_ProviderID ,
                                              AV8iJC_ProviderIDs } ,
                                              new int[]{
                                              TypeConstants.LONG
                                              }
         } ) ;
         /* Using cursor P00212 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A87JC_ProviderID = P00212_A87JC_ProviderID[0];
            A6SecUserId = P00212_A6SecUserId[0];
            AV9oSecUserIds.Add(A6SecUserId, 0);
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
         P00212_A87JC_ProviderID = new long[1] ;
         P00212_A6SecUserId = new short[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.zutil_finduserifinprovider__default(),
            new Object[][] {
                new Object[] {
               P00212_A87JC_ProviderID, P00212_A6SecUserId
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short A6SecUserId ;
      private long A87JC_ProviderID ;
      private String scmdbuf ;
      private GxSimpleCollection<short> AV9oSecUserIds ;
      private GxSimpleCollection<long> AV8iJC_ProviderIDs ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] P00212_A87JC_ProviderID ;
      private short[] P00212_A6SecUserId ;
      private GxSimpleCollection<short> aP1_oSecUserIds ;
   }

   public class zutil_finduserifinprovider__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_P00212( IGxContext context ,
                                             long A87JC_ProviderID ,
                                             GxSimpleCollection<long> AV8iJC_ProviderIDs )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         Object[] GXv_Object1 ;
         GXv_Object1 = new Object [2] ;
         scmdbuf = "SELECT [JC_ProviderID], [SecUserId] FROM [JC_ProviderSecUser] WITH (NOLOCK)";
         scmdbuf = scmdbuf + " WHERE (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV8iJC_ProviderIDs, "[JC_ProviderID] IN (", ")") + ")";
         scmdbuf = scmdbuf + sWhereString;
         scmdbuf = scmdbuf + " ORDER BY [SecUserId], [JC_ProviderID]";
         GXv_Object1[0] = scmdbuf;
         return GXv_Object1 ;
      }

      public override Object [] getDynamicStatement( int cursor ,
                                                     IGxContext context ,
                                                     Object [] dynConstraints )
      {
         switch ( cursor )
         {
               case 0 :
                     return conditional_P00212(context, (long)dynConstraints[0] , (GxSimpleCollection<long>)dynConstraints[1] );
         }
         return base.getDynamicStatement(cursor, context, dynConstraints);
      }

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
          Object[] prmP00212 ;
          prmP00212 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("P00212", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00212,100,0,false,false )
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
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                return;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       short sIdx ;
       switch ( cursor )
       {
       }
    }

 }

}
