/*
               File: WWPBaseObjects.SecFunctionalityHasChildren
        Description: Sec Functionality Has Children
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:5:52.18
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
namespace GeneXus.Programs.wwpbaseobjects {
   public class secfunctionalityhaschildren : GXProcedure
   {
      public secfunctionalityhaschildren( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public secfunctionalityhaschildren( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( long aP0_SecFunctionalityId ,
                           out bool aP1_HasChildren )
      {
         this.AV9SecFunctionalityId = aP0_SecFunctionalityId;
         this.AV8HasChildren = false ;
         initialize();
         executePrivate();
         aP1_HasChildren=this.AV8HasChildren;
      }

      public bool executeUdp( long aP0_SecFunctionalityId )
      {
         this.AV9SecFunctionalityId = aP0_SecFunctionalityId;
         this.AV8HasChildren = false ;
         initialize();
         executePrivate();
         aP1_HasChildren=this.AV8HasChildren;
         return AV8HasChildren ;
      }

      public void executeSubmit( long aP0_SecFunctionalityId ,
                                 out bool aP1_HasChildren )
      {
         secfunctionalityhaschildren objsecfunctionalityhaschildren;
         objsecfunctionalityhaschildren = new secfunctionalityhaschildren();
         objsecfunctionalityhaschildren.AV9SecFunctionalityId = aP0_SecFunctionalityId;
         objsecfunctionalityhaschildren.AV8HasChildren = false ;
         objsecfunctionalityhaschildren.context.SetSubmitInitialConfig(context);
         objsecfunctionalityhaschildren.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objsecfunctionalityhaschildren);
         aP1_HasChildren=this.AV8HasChildren;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((secfunctionalityhaschildren)stateInfo).executePrivate();
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
         AV8HasChildren = false;
         /* Using cursor P000V2 */
         pr_default.execute(0, new Object[] {AV9SecFunctionalityId});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A2SecParentFunctionalityId = P000V2_A2SecParentFunctionalityId[0];
            n2SecParentFunctionalityId = P000V2_n2SecParentFunctionalityId[0];
            A1SecFunctionalityId = P000V2_A1SecFunctionalityId[0];
            AV8HasChildren = true;
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
         P000V2_A2SecParentFunctionalityId = new long[1] ;
         P000V2_n2SecParentFunctionalityId = new bool[] {false} ;
         P000V2_A1SecFunctionalityId = new long[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.wwpbaseobjects.secfunctionalityhaschildren__default(),
            new Object[][] {
                new Object[] {
               P000V2_A2SecParentFunctionalityId, P000V2_n2SecParentFunctionalityId, P000V2_A1SecFunctionalityId
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private long AV9SecFunctionalityId ;
      private long A2SecParentFunctionalityId ;
      private long A1SecFunctionalityId ;
      private String scmdbuf ;
      private bool AV8HasChildren ;
      private bool n2SecParentFunctionalityId ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] P000V2_A2SecParentFunctionalityId ;
      private bool[] P000V2_n2SecParentFunctionalityId ;
      private long[] P000V2_A1SecFunctionalityId ;
      private bool aP1_HasChildren ;
   }

   public class secfunctionalityhaschildren__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP000V2 ;
          prmP000V2 = new Object[] {
          new Object[] {"@AV9SecFunctionalityId",SqlDbType.Decimal,10,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P000V2", "SELECT TOP 1 [SecParentFunctionalityId], [SecFunctionalityId] FROM [SecFunctionality] WITH (NOLOCK) WHERE [SecParentFunctionalityId] = @AV9SecFunctionalityId ORDER BY [SecParentFunctionalityId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000V2,1,0,false,true )
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
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((long[]) buf[2])[0] = rslt.getLong(2) ;
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
                stmt.SetParameter(1, (long)parms[0]);
                return;
       }
    }

 }

}
