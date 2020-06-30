/*
               File: XT_IntialDefineCodeGetFilterData
        Description: XT_Intial Define Code Get Filter Data
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:35:41.29
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
using System.ServiceModel.Web;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class xt_intialdefinecodegetfilterdata : GXProcedure
   {
      public xt_intialdefinecodegetfilterdata( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public xt_intialdefinecodegetfilterdata( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( String aP0_DDOName ,
                           String aP1_SearchTxt ,
                           String aP2_SearchTxtTo ,
                           out String aP3_OptionsJson ,
                           out String aP4_OptionsDescJson ,
                           out String aP5_OptionIndexesJson )
      {
         this.AV15DDOName = aP0_DDOName;
         this.AV13SearchTxt = aP1_SearchTxt;
         this.AV14SearchTxtTo = aP2_SearchTxtTo;
         this.AV19OptionsJson = "" ;
         this.AV22OptionsDescJson = "" ;
         this.AV24OptionIndexesJson = "" ;
         initialize();
         executePrivate();
         aP3_OptionsJson=this.AV19OptionsJson;
         aP4_OptionsDescJson=this.AV22OptionsDescJson;
         aP5_OptionIndexesJson=this.AV24OptionIndexesJson;
      }

      public String executeUdp( String aP0_DDOName ,
                                String aP1_SearchTxt ,
                                String aP2_SearchTxtTo ,
                                out String aP3_OptionsJson ,
                                out String aP4_OptionsDescJson )
      {
         this.AV15DDOName = aP0_DDOName;
         this.AV13SearchTxt = aP1_SearchTxt;
         this.AV14SearchTxtTo = aP2_SearchTxtTo;
         this.AV19OptionsJson = "" ;
         this.AV22OptionsDescJson = "" ;
         this.AV24OptionIndexesJson = "" ;
         initialize();
         executePrivate();
         aP3_OptionsJson=this.AV19OptionsJson;
         aP4_OptionsDescJson=this.AV22OptionsDescJson;
         aP5_OptionIndexesJson=this.AV24OptionIndexesJson;
         return AV24OptionIndexesJson ;
      }

      public void executeSubmit( String aP0_DDOName ,
                                 String aP1_SearchTxt ,
                                 String aP2_SearchTxtTo ,
                                 out String aP3_OptionsJson ,
                                 out String aP4_OptionsDescJson ,
                                 out String aP5_OptionIndexesJson )
      {
         xt_intialdefinecodegetfilterdata objxt_intialdefinecodegetfilterdata;
         objxt_intialdefinecodegetfilterdata = new xt_intialdefinecodegetfilterdata();
         objxt_intialdefinecodegetfilterdata.AV15DDOName = aP0_DDOName;
         objxt_intialdefinecodegetfilterdata.AV13SearchTxt = aP1_SearchTxt;
         objxt_intialdefinecodegetfilterdata.AV14SearchTxtTo = aP2_SearchTxtTo;
         objxt_intialdefinecodegetfilterdata.AV19OptionsJson = "" ;
         objxt_intialdefinecodegetfilterdata.AV22OptionsDescJson = "" ;
         objxt_intialdefinecodegetfilterdata.AV24OptionIndexesJson = "" ;
         objxt_intialdefinecodegetfilterdata.context.SetSubmitInitialConfig(context);
         objxt_intialdefinecodegetfilterdata.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objxt_intialdefinecodegetfilterdata);
         aP3_OptionsJson=this.AV19OptionsJson;
         aP4_OptionsDescJson=this.AV22OptionsDescJson;
         aP5_OptionIndexesJson=this.AV24OptionIndexesJson;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((xt_intialdefinecodegetfilterdata)stateInfo).executePrivate();
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
         AV18Options = (GxSimpleCollection<String>)(new GxSimpleCollection<String>());
         AV21OptionsDesc = (GxSimpleCollection<String>)(new GxSimpleCollection<String>());
         AV23OptionIndexes = (GxSimpleCollection<String>)(new GxSimpleCollection<String>());
         GXt_boolean1 = AV8IsAuthorized;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Check_DefindcodeType", out  GXt_boolean1) ;
         AV8IsAuthorized = GXt_boolean1;
         if ( AV8IsAuthorized )
         {
            new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV9WWPContext) ;
            /* Execute user subroutine: 'LOADGRIDSTATE' */
            S111 ();
            if ( returnInSub )
            {
               this.cleanup();
               if (true) return;
            }
            if ( StringUtil.StrCmp(StringUtil.Upper( AV15DDOName), "DDO_BAS_TENANTTENANTCODE") == 0 )
            {
               /* Execute user subroutine: 'LOADBAS_TENANTTENANTCODEOPTIONS' */
               S121 ();
               if ( returnInSub )
               {
                  this.cleanup();
                  if (true) return;
               }
            }
         }
         AV19OptionsJson = AV18Options.ToJSonString(false);
         AV22OptionsDescJson = AV21OptionsDesc.ToJSonString(false);
         AV24OptionIndexesJson = AV23OptionIndexes.ToJSonString(false);
         this.cleanup();
      }

      protected void S111( )
      {
         /* 'LOADGRIDSTATE' Routine */
         if ( StringUtil.StrCmp(AV26Session.Get("XT_IntialDefineCodeGridState"), "") == 0 )
         {
            AV28GridState.FromXml(new GeneXus.Programs.wwpbaseobjects.loadgridstate(context).executeUdp(  "XT_IntialDefineCodeGridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         else
         {
            AV28GridState.FromXml(AV26Session.Get("XT_IntialDefineCodeGridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         AV33GXV1 = 1;
         while ( AV33GXV1 <= AV28GridState.gxTpr_Filtervalues.Count )
         {
            AV29GridStateFilterValue = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue)AV28GridState.gxTpr_Filtervalues.Item(AV33GXV1));
            if ( StringUtil.StrCmp(AV29GridStateFilterValue.gxTpr_Name, "TFBAS_TENANTTENANTCODE") == 0 )
            {
               AV11TFBAS_TenantTenantCode = AV29GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV29GridStateFilterValue.gxTpr_Name, "TFBAS_TENANTTENANTCODE_SEL") == 0 )
            {
               AV12TFBAS_TenantTenantCode_Sel = AV29GridStateFilterValue.gxTpr_Value;
            }
            AV33GXV1 = (int)(AV33GXV1+1);
         }
      }

      protected void S121( )
      {
         /* 'LOADBAS_TENANTTENANTCODEOPTIONS' Routine */
         AV11TFBAS_TenantTenantCode = AV13SearchTxt;
         AV12TFBAS_TenantTenantCode_Sel = "";
         pr_datastore1.dynParam(0, new Object[]{ new Object[]{
                                              AV12TFBAS_TenantTenantCode_Sel ,
                                              AV11TFBAS_TenantTenantCode ,
                                              A360BAS_TenantTenantCode ,
                                              A401BAS_TenantIsDeleted } ,
                                              new int[]{
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.SHORT
                                              }
         } ) ;
         lV11TFBAS_TenantTenantCode = StringUtil.Concat( StringUtil.RTrim( AV11TFBAS_TenantTenantCode), "%", "");
         /* Using cursor P003Z2 */
         pr_datastore1.execute(0, new Object[] {lV11TFBAS_TenantTenantCode, AV12TFBAS_TenantTenantCode_Sel});
         while ( (pr_datastore1.getStatus(0) != 101) )
         {
            A401BAS_TenantIsDeleted = P003Z2_A401BAS_TenantIsDeleted[0];
            A360BAS_TenantTenantCode = P003Z2_A360BAS_TenantTenantCode[0];
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A360BAS_TenantTenantCode)) )
            {
               AV17Option = A360BAS_TenantTenantCode;
               AV18Options.Add(AV17Option, 0);
            }
            if ( AV18Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            pr_datastore1.readNext(0);
         }
         pr_datastore1.close(0);
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
         AV18Options = new GxSimpleCollection<String>();
         AV21OptionsDesc = new GxSimpleCollection<String>();
         AV23OptionIndexes = new GxSimpleCollection<String>();
         AV9WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV26Session = context.GetSession();
         AV28GridState = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState(context);
         AV29GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
         AV11TFBAS_TenantTenantCode = "";
         AV12TFBAS_TenantTenantCode_Sel = "";
         scmdbuf = "";
         lV11TFBAS_TenantTenantCode = "";
         A360BAS_TenantTenantCode = "";
         P003Z2_A401BAS_TenantIsDeleted = new short[1] ;
         P003Z2_A360BAS_TenantTenantCode = new String[] {""} ;
         AV17Option = "";
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.xt_intialdefinecodegetfilterdata__datastore1(),
            new Object[][] {
                new Object[] {
               P003Z2_A401BAS_TenantIsDeleted, P003Z2_A360BAS_TenantTenantCode
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short A401BAS_TenantIsDeleted ;
      private int AV33GXV1 ;
      private String scmdbuf ;
      private bool AV8IsAuthorized ;
      private bool GXt_boolean1 ;
      private bool returnInSub ;
      private String AV24OptionIndexesJson ;
      private String AV19OptionsJson ;
      private String AV22OptionsDescJson ;
      private String AV15DDOName ;
      private String AV13SearchTxt ;
      private String AV14SearchTxtTo ;
      private String AV11TFBAS_TenantTenantCode ;
      private String AV12TFBAS_TenantTenantCode_Sel ;
      private String lV11TFBAS_TenantTenantCode ;
      private String A360BAS_TenantTenantCode ;
      private String AV17Option ;
      private IGxSession AV26Session ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_datastore1 ;
      private short[] P003Z2_A401BAS_TenantIsDeleted ;
      private String[] P003Z2_A360BAS_TenantTenantCode ;
      private String aP3_OptionsJson ;
      private String aP4_OptionsDescJson ;
      private String aP5_OptionIndexesJson ;
      private GxSimpleCollection<String> AV18Options ;
      private GxSimpleCollection<String> AV21OptionsDesc ;
      private GxSimpleCollection<String> AV23OptionIndexes ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV9WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState AV28GridState ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue AV29GridStateFilterValue ;
   }

   public class xt_intialdefinecodegetfilterdata__datastore1 : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_P003Z2( IGxContext context ,
                                             String AV12TFBAS_TenantTenantCode_Sel ,
                                             String AV11TFBAS_TenantTenantCode ,
                                             String A360BAS_TenantTenantCode ,
                                             short A401BAS_TenantIsDeleted )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int2 ;
         GXv_int2 = new short [2] ;
         Object[] GXv_Object3 ;
         GXv_Object3 = new Object [2] ;
         scmdbuf = "SELECT DISTINCT NULL AS [IsDeleted], [TenantCode] FROM ( SELECT TOP(100) PERCENT [IsDeleted], [TenantCode] FROM dbo.[BAS_Tenant] WITH (NOLOCK)";
         scmdbuf = scmdbuf + " WHERE ([IsDeleted] = 0)";
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV12TFBAS_TenantTenantCode_Sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV11TFBAS_TenantTenantCode)) ) )
         {
            sWhereString = sWhereString + " and ([TenantCode] like @lV11TFBAS_TenantTenantCode)";
         }
         else
         {
            GXv_int2[0] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV12TFBAS_TenantTenantCode_Sel)) )
         {
            sWhereString = sWhereString + " and ([TenantCode] = @AV12TFBAS_TenantTenantCode_Sel)";
         }
         else
         {
            GXv_int2[1] = 1;
         }
         scmdbuf = scmdbuf + sWhereString;
         scmdbuf = scmdbuf + " ORDER BY [TenantCode]";
         scmdbuf = scmdbuf + ") DistinctT";
         GXv_Object3[0] = scmdbuf;
         GXv_Object3[1] = GXv_int2;
         return GXv_Object3 ;
      }

      public override Object [] getDynamicStatement( int cursor ,
                                                     IGxContext context ,
                                                     Object [] dynConstraints )
      {
         switch ( cursor )
         {
               case 0 :
                     return conditional_P003Z2(context, (String)dynConstraints[0] , (String)dynConstraints[1] , (String)dynConstraints[2] , (short)dynConstraints[3] );
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
          Object[] prmP003Z2 ;
          prmP003Z2 = new Object[] {
          new Object[] {"@lV11TFBAS_TenantTenantCode",SqlDbType.NVarChar,20,0} ,
          new Object[] {"@AV12TFBAS_TenantTenantCode_Sel",SqlDbType.NVarChar,20,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P003Z2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP003Z2,100,0,false,false )
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
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
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
             case 0 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[2]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[3]);
                }
                return;
       }
    }

    public String getDataStoreName( )
    {
       return "DATASTORE1";
    }

 }

 [ServiceContract(Namespace = "GeneXus.Programs.xt_intialdefinecodegetfilterdata_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class xt_intialdefinecodegetfilterdata_services : GxRestService
 {
    [OperationContract]
    [WebInvoke(Method =  "POST" ,
    	BodyStyle =  WebMessageBodyStyle.Wrapped  ,
    	ResponseFormat = WebMessageFormat.Json,
    	UriTemplate = "/")]
    public void execute( String DDOName ,
                         String SearchTxt ,
                         String SearchTxtTo ,
                         out String OptionsJson ,
                         out String OptionsDescJson ,
                         out String OptionIndexesJson )
    {
       OptionsJson = "" ;
       OptionsDescJson = "" ;
       OptionIndexesJson = "" ;
       try
       {
          if ( ! ProcessHeaders("xt_intialdefinecodegetfilterdata") )
          {
             return  ;
          }
          xt_intialdefinecodegetfilterdata worker = new xt_intialdefinecodegetfilterdata(context) ;
          worker.IsMain = RunAsMain ;
          worker.execute(DDOName,SearchTxt,SearchTxtTo,out OptionsJson,out OptionsDescJson,out OptionIndexesJson );
          worker.cleanup( );
       }
       catch ( Exception e )
       {
          WebException(e);
       }
       finally
       {
          Cleanup();
       }
    }

 }

}
