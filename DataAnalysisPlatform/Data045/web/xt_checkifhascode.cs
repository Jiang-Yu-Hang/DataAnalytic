/*
               File: XT_CheckIfHasCode
        Description: 检查数据字典是否有code
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:6:8.79
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
   public class xt_checkifhascode : GXProcedure
   {
      public xt_checkifhascode( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public xt_checkifhascode( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( long aP0_iXT_DefineCodeID ,
                           String aP1_iCurrentCode ,
                           out bool aP2_oFlag )
      {
         this.AV8iXT_DefineCodeID = aP0_iXT_DefineCodeID;
         this.AV9iCurrentCode = aP1_iCurrentCode;
         this.AV10oFlag = false ;
         initialize();
         executePrivate();
         aP2_oFlag=this.AV10oFlag;
      }

      public bool executeUdp( long aP0_iXT_DefineCodeID ,
                              String aP1_iCurrentCode )
      {
         this.AV8iXT_DefineCodeID = aP0_iXT_DefineCodeID;
         this.AV9iCurrentCode = aP1_iCurrentCode;
         this.AV10oFlag = false ;
         initialize();
         executePrivate();
         aP2_oFlag=this.AV10oFlag;
         return AV10oFlag ;
      }

      public void executeSubmit( long aP0_iXT_DefineCodeID ,
                                 String aP1_iCurrentCode ,
                                 out bool aP2_oFlag )
      {
         xt_checkifhascode objxt_checkifhascode;
         objxt_checkifhascode = new xt_checkifhascode();
         objxt_checkifhascode.AV8iXT_DefineCodeID = aP0_iXT_DefineCodeID;
         objxt_checkifhascode.AV9iCurrentCode = aP1_iCurrentCode;
         objxt_checkifhascode.AV10oFlag = false ;
         objxt_checkifhascode.context.SetSubmitInitialConfig(context);
         objxt_checkifhascode.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objxt_checkifhascode);
         aP2_oFlag=this.AV10oFlag;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((xt_checkifhascode)stateInfo).executePrivate();
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
         AV10oFlag = false;
         /* Using cursor P00482 */
         pr_default.execute(0, new Object[] {AV8iXT_DefineCodeID, AV9iCurrentCode});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A167XT_DefineCodeID = P00482_A167XT_DefineCodeID[0];
            A432XT_TenantCode = P00482_A432XT_TenantCode[0];
            n432XT_TenantCode = P00482_n432XT_TenantCode[0];
            A431XT_TypeCode = P00482_A431XT_TypeCode[0];
            n431XT_TypeCode = P00482_n431XT_TypeCode[0];
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A431XT_TypeCode)) )
            {
               AV10oFlag = true;
            }
            /* Exiting from a For First loop. */
            if (true) break;
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
         P00482_A167XT_DefineCodeID = new long[1] ;
         P00482_A432XT_TenantCode = new String[] {""} ;
         P00482_n432XT_TenantCode = new bool[] {false} ;
         P00482_A431XT_TypeCode = new String[] {""} ;
         P00482_n431XT_TypeCode = new bool[] {false} ;
         A432XT_TenantCode = "";
         A431XT_TypeCode = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.xt_checkifhascode__default(),
            new Object[][] {
                new Object[] {
               P00482_A167XT_DefineCodeID, P00482_A432XT_TenantCode, P00482_n432XT_TenantCode, P00482_A431XT_TypeCode, P00482_n431XT_TypeCode
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private long AV8iXT_DefineCodeID ;
      private long A167XT_DefineCodeID ;
      private String scmdbuf ;
      private bool AV10oFlag ;
      private bool n432XT_TenantCode ;
      private bool n431XT_TypeCode ;
      private String AV9iCurrentCode ;
      private String A432XT_TenantCode ;
      private String A431XT_TypeCode ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] P00482_A167XT_DefineCodeID ;
      private String[] P00482_A432XT_TenantCode ;
      private bool[] P00482_n432XT_TenantCode ;
      private String[] P00482_A431XT_TypeCode ;
      private bool[] P00482_n431XT_TypeCode ;
      private bool aP2_oFlag ;
   }

   public class xt_checkifhascode__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP00482 ;
          prmP00482 = new Object[] {
          new Object[] {"@AV8iXT_DefineCodeID",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV9iCurrentCode",SqlDbType.NVarChar,40,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00482", "SELECT [XT_DefineCodeID], [XT_TenantCode], [XT_TypeCode] FROM [XT_DefineCode] WITH (NOLOCK) WHERE ([XT_DefineCodeID] = @AV8iXT_DefineCodeID) AND ([XT_TenantCode] = @AV9iCurrentCode) ORDER BY [XT_DefineCodeID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00482,1,0,false,true )
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
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
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
                stmt.SetParameter(2, (String)parms[1]);
                return;
       }
    }

 }

}
