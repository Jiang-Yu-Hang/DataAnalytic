/*
               File: ZUtil_FindTargetCode
        Description: 查找对应的definecode
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:6:7.74
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
   public class zutil_findtargetcode : GXProcedure
   {
      public zutil_findtargetcode( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public zutil_findtargetcode( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( long aP0_iXT_DefindcodeTypeID ,
                           String aP1_iXT_DefineCodeName ,
                           out String aP2_oXT_TypeCode )
      {
         this.AV8iXT_DefindcodeTypeID = aP0_iXT_DefindcodeTypeID;
         this.AV9iXT_DefineCodeName = aP1_iXT_DefineCodeName;
         this.AV10oXT_TypeCode = "" ;
         initialize();
         executePrivate();
         aP2_oXT_TypeCode=this.AV10oXT_TypeCode;
      }

      public String executeUdp( long aP0_iXT_DefindcodeTypeID ,
                                String aP1_iXT_DefineCodeName )
      {
         this.AV8iXT_DefindcodeTypeID = aP0_iXT_DefindcodeTypeID;
         this.AV9iXT_DefineCodeName = aP1_iXT_DefineCodeName;
         this.AV10oXT_TypeCode = "" ;
         initialize();
         executePrivate();
         aP2_oXT_TypeCode=this.AV10oXT_TypeCode;
         return AV10oXT_TypeCode ;
      }

      public void executeSubmit( long aP0_iXT_DefindcodeTypeID ,
                                 String aP1_iXT_DefineCodeName ,
                                 out String aP2_oXT_TypeCode )
      {
         zutil_findtargetcode objzutil_findtargetcode;
         objzutil_findtargetcode = new zutil_findtargetcode();
         objzutil_findtargetcode.AV8iXT_DefindcodeTypeID = aP0_iXT_DefindcodeTypeID;
         objzutil_findtargetcode.AV9iXT_DefineCodeName = aP1_iXT_DefineCodeName;
         objzutil_findtargetcode.AV10oXT_TypeCode = "" ;
         objzutil_findtargetcode.context.SetSubmitInitialConfig(context);
         objzutil_findtargetcode.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objzutil_findtargetcode);
         aP2_oXT_TypeCode=this.AV10oXT_TypeCode;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((zutil_findtargetcode)stateInfo).executePrivate();
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
         AV13GXLvl1 = 0;
         /* Using cursor P003M2 */
         pr_default.execute(0, new Object[] {AV8iXT_DefindcodeTypeID, AV9iXT_DefineCodeName});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A168XT_DefineCodeName = P003M2_A168XT_DefineCodeName[0];
            n168XT_DefineCodeName = P003M2_n168XT_DefineCodeName[0];
            A165XT_DefindcodeTypeID = P003M2_A165XT_DefindcodeTypeID[0];
            A431XT_TypeCode = P003M2_A431XT_TypeCode[0];
            n431XT_TypeCode = P003M2_n431XT_TypeCode[0];
            A167XT_DefineCodeID = P003M2_A167XT_DefineCodeID[0];
            AV13GXLvl1 = 1;
            AV10oXT_TypeCode = StringUtil.Trim( A431XT_TypeCode);
            pr_default.readNext(0);
         }
         pr_default.close(0);
         if ( AV13GXLvl1 == 0 )
         {
            AV10oXT_TypeCode = "";
         }
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
         P003M2_A168XT_DefineCodeName = new String[] {""} ;
         P003M2_n168XT_DefineCodeName = new bool[] {false} ;
         P003M2_A165XT_DefindcodeTypeID = new long[1] ;
         P003M2_A431XT_TypeCode = new String[] {""} ;
         P003M2_n431XT_TypeCode = new bool[] {false} ;
         P003M2_A167XT_DefineCodeID = new long[1] ;
         A168XT_DefineCodeName = "";
         A431XT_TypeCode = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.zutil_findtargetcode__default(),
            new Object[][] {
                new Object[] {
               P003M2_A168XT_DefineCodeName, P003M2_n168XT_DefineCodeName, P003M2_A165XT_DefindcodeTypeID, P003M2_A431XT_TypeCode, P003M2_n431XT_TypeCode, P003M2_A167XT_DefineCodeID
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV13GXLvl1 ;
      private long AV8iXT_DefindcodeTypeID ;
      private long A165XT_DefindcodeTypeID ;
      private long A167XT_DefineCodeID ;
      private String scmdbuf ;
      private bool n168XT_DefineCodeName ;
      private bool n431XT_TypeCode ;
      private String AV9iXT_DefineCodeName ;
      private String AV10oXT_TypeCode ;
      private String A168XT_DefineCodeName ;
      private String A431XT_TypeCode ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] P003M2_A168XT_DefineCodeName ;
      private bool[] P003M2_n168XT_DefineCodeName ;
      private long[] P003M2_A165XT_DefindcodeTypeID ;
      private String[] P003M2_A431XT_TypeCode ;
      private bool[] P003M2_n431XT_TypeCode ;
      private long[] P003M2_A167XT_DefineCodeID ;
      private String aP2_oXT_TypeCode ;
   }

   public class zutil_findtargetcode__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP003M2 ;
          prmP003M2 = new Object[] {
          new Object[] {"@AV8iXT_DefindcodeTypeID",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV9iXT_DefineCodeName",SqlDbType.NVarChar,100,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P003M2", "SELECT [XT_DefineCodeName], [XT_DefindcodeTypeID], [XT_TypeCode], [XT_DefineCodeID] FROM [XT_DefineCode] WITH (NOLOCK) WHERE ([XT_DefindcodeTypeID] = @AV8iXT_DefindcodeTypeID) AND ([XT_DefineCodeName] = RTRIM(LTRIM(@AV9iXT_DefineCodeName))) ORDER BY [XT_DefindcodeTypeID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP003M2,100,0,false,false )
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
                ((long[]) buf[2])[0] = rslt.getLong(2) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((long[]) buf[5])[0] = rslt.getLong(4) ;
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
