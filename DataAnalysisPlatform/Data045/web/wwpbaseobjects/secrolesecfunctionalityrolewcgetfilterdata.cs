/*
               File: WWPBaseObjects.SecRoleSecFunctionalityRoleWCGetFilterData
        Description: Sec Role Sec Functionality Role WCGet Filter Data
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:5:52.96
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
namespace GeneXus.Programs.wwpbaseobjects {
   public class secrolesecfunctionalityrolewcgetfilterdata : GXProcedure
   {
      public secrolesecfunctionalityrolewcgetfilterdata( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public secrolesecfunctionalityrolewcgetfilterdata( IGxContext context )
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
         this.AV19DDOName = aP0_DDOName;
         this.AV17SearchTxt = aP1_SearchTxt;
         this.AV18SearchTxtTo = aP2_SearchTxtTo;
         this.AV23OptionsJson = "" ;
         this.AV26OptionsDescJson = "" ;
         this.AV28OptionIndexesJson = "" ;
         initialize();
         executePrivate();
         aP3_OptionsJson=this.AV23OptionsJson;
         aP4_OptionsDescJson=this.AV26OptionsDescJson;
         aP5_OptionIndexesJson=this.AV28OptionIndexesJson;
      }

      public String executeUdp( String aP0_DDOName ,
                                String aP1_SearchTxt ,
                                String aP2_SearchTxtTo ,
                                out String aP3_OptionsJson ,
                                out String aP4_OptionsDescJson )
      {
         this.AV19DDOName = aP0_DDOName;
         this.AV17SearchTxt = aP1_SearchTxt;
         this.AV18SearchTxtTo = aP2_SearchTxtTo;
         this.AV23OptionsJson = "" ;
         this.AV26OptionsDescJson = "" ;
         this.AV28OptionIndexesJson = "" ;
         initialize();
         executePrivate();
         aP3_OptionsJson=this.AV23OptionsJson;
         aP4_OptionsDescJson=this.AV26OptionsDescJson;
         aP5_OptionIndexesJson=this.AV28OptionIndexesJson;
         return AV28OptionIndexesJson ;
      }

      public void executeSubmit( String aP0_DDOName ,
                                 String aP1_SearchTxt ,
                                 String aP2_SearchTxtTo ,
                                 out String aP3_OptionsJson ,
                                 out String aP4_OptionsDescJson ,
                                 out String aP5_OptionIndexesJson )
      {
         secrolesecfunctionalityrolewcgetfilterdata objsecrolesecfunctionalityrolewcgetfilterdata;
         objsecrolesecfunctionalityrolewcgetfilterdata = new secrolesecfunctionalityrolewcgetfilterdata();
         objsecrolesecfunctionalityrolewcgetfilterdata.AV19DDOName = aP0_DDOName;
         objsecrolesecfunctionalityrolewcgetfilterdata.AV17SearchTxt = aP1_SearchTxt;
         objsecrolesecfunctionalityrolewcgetfilterdata.AV18SearchTxtTo = aP2_SearchTxtTo;
         objsecrolesecfunctionalityrolewcgetfilterdata.AV23OptionsJson = "" ;
         objsecrolesecfunctionalityrolewcgetfilterdata.AV26OptionsDescJson = "" ;
         objsecrolesecfunctionalityrolewcgetfilterdata.AV28OptionIndexesJson = "" ;
         objsecrolesecfunctionalityrolewcgetfilterdata.context.SetSubmitInitialConfig(context);
         objsecrolesecfunctionalityrolewcgetfilterdata.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objsecrolesecfunctionalityrolewcgetfilterdata);
         aP3_OptionsJson=this.AV23OptionsJson;
         aP4_OptionsDescJson=this.AV26OptionsDescJson;
         aP5_OptionIndexesJson=this.AV28OptionIndexesJson;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((secrolesecfunctionalityrolewcgetfilterdata)stateInfo).executePrivate();
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
         AV22Options = (GxSimpleCollection<String>)(new GxSimpleCollection<String>());
         AV25OptionsDesc = (GxSimpleCollection<String>)(new GxSimpleCollection<String>());
         AV27OptionIndexes = (GxSimpleCollection<String>)(new GxSimpleCollection<String>());
         GXt_boolean1 = AV8IsAuthorized;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "WWSecRole", out  GXt_boolean1) ;
         AV8IsAuthorized = GXt_boolean1;
         if ( AV8IsAuthorized )
         {
            new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV51WWPContext) ;
            /* Execute user subroutine: 'LOADGRIDSTATE' */
            S111 ();
            if ( returnInSub )
            {
               this.cleanup();
               if (true) return;
            }
            if ( StringUtil.StrCmp(StringUtil.Upper( AV19DDOName), "DDO_SECFUNCTIONALITYKEY") == 0 )
            {
               /* Execute user subroutine: 'LOADSECFUNCTIONALITYKEYOPTIONS' */
               S121 ();
               if ( returnInSub )
               {
                  this.cleanup();
                  if (true) return;
               }
            }
         }
         AV23OptionsJson = AV22Options.ToJSonString(false);
         AV26OptionsDescJson = AV25OptionsDesc.ToJSonString(false);
         AV28OptionIndexesJson = AV27OptionIndexes.ToJSonString(false);
         this.cleanup();
      }

      protected void S111( )
      {
         /* 'LOADGRIDSTATE' Routine */
         if ( StringUtil.StrCmp(AV30Session.Get("WWPBaseObjects.SecRoleSecFunctionalityRoleWCGridState"), "") == 0 )
         {
            AV32GridState.FromXml(new GeneXus.Programs.wwpbaseobjects.loadgridstate(context).executeUdp(  "WWPBaseObjects.SecRoleSecFunctionalityRoleWCGridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         else
         {
            AV32GridState.FromXml(AV30Session.Get("WWPBaseObjects.SecRoleSecFunctionalityRoleWCGridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         AV57GXV1 = 1;
         while ( AV57GXV1 <= AV32GridState.gxTpr_Filtervalues.Count )
         {
            AV33GridStateFilterValue = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue)AV32GridState.gxTpr_Filtervalues.Item(AV57GXV1));
            if ( StringUtil.StrCmp(AV33GridStateFilterValue.gxTpr_Name, "SECFUNCTIONALITYKEY") == 0 )
            {
               AV54SecFunctionalityKey = AV33GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV33GridStateFilterValue.gxTpr_Name, "TFSECFUNCTIONALITYKEY") == 0 )
            {
               AV10TFSecFunctionalityKey = AV33GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV33GridStateFilterValue.gxTpr_Name, "TFSECFUNCTIONALITYKEY_SEL") == 0 )
            {
               AV11TFSecFunctionalityKey_Sel = AV33GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV33GridStateFilterValue.gxTpr_Name, "PARM_&SECROLEID") == 0 )
            {
               AV50SecRoleId = (short)(NumberUtil.Val( AV33GridStateFilterValue.gxTpr_Value, "."));
            }
            AV57GXV1 = (int)(AV57GXV1+1);
         }
      }

      protected void S121( )
      {
         /* 'LOADSECFUNCTIONALITYKEYOPTIONS' Routine */
         AV10TFSecFunctionalityKey = AV17SearchTxt;
         AV11TFSecFunctionalityKey_Sel = "";
         pr_default.dynParam(0, new Object[]{ new Object[]{
                                              AV54SecFunctionalityKey ,
                                              AV11TFSecFunctionalityKey_Sel ,
                                              AV10TFSecFunctionalityKey ,
                                              A3SecFunctionalityKey ,
                                              AV50SecRoleId ,
                                              A4SecRoleId } ,
                                              new int[]{
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.SHORT
                                              }
         } ) ;
         lV54SecFunctionalityKey = StringUtil.Concat( StringUtil.RTrim( AV54SecFunctionalityKey), "%", "");
         lV10TFSecFunctionalityKey = StringUtil.Concat( StringUtil.RTrim( AV10TFSecFunctionalityKey), "%", "");
         /* Using cursor P00132 */
         pr_default.execute(0, new Object[] {AV50SecRoleId, lV54SecFunctionalityKey, lV10TFSecFunctionalityKey, AV11TFSecFunctionalityKey_Sel});
         while ( (pr_default.getStatus(0) != 101) )
         {
            BRK132 = false;
            A1SecFunctionalityId = P00132_A1SecFunctionalityId[0];
            A4SecRoleId = P00132_A4SecRoleId[0];
            A3SecFunctionalityKey = P00132_A3SecFunctionalityKey[0];
            A3SecFunctionalityKey = P00132_A3SecFunctionalityKey[0];
            AV29count = 0;
            while ( (pr_default.getStatus(0) != 101) && ( P00132_A4SecRoleId[0] == A4SecRoleId ) && ( StringUtil.StrCmp(P00132_A3SecFunctionalityKey[0], A3SecFunctionalityKey) == 0 ) )
            {
               BRK132 = false;
               A1SecFunctionalityId = P00132_A1SecFunctionalityId[0];
               AV29count = (long)(AV29count+1);
               BRK132 = true;
               pr_default.readNext(0);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A3SecFunctionalityKey)) )
            {
               AV21Option = A3SecFunctionalityKey;
               AV22Options.Add(AV21Option, 0);
               AV27OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV29count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV22Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK132 )
            {
               BRK132 = true;
               pr_default.readNext(0);
            }
         }
         pr_default.close(0);
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
         AV22Options = new GxSimpleCollection<String>();
         AV25OptionsDesc = new GxSimpleCollection<String>();
         AV27OptionIndexes = new GxSimpleCollection<String>();
         AV51WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV30Session = context.GetSession();
         AV32GridState = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState(context);
         AV33GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
         AV54SecFunctionalityKey = "";
         AV10TFSecFunctionalityKey = "";
         AV11TFSecFunctionalityKey_Sel = "";
         scmdbuf = "";
         lV54SecFunctionalityKey = "";
         lV10TFSecFunctionalityKey = "";
         A3SecFunctionalityKey = "";
         P00132_A1SecFunctionalityId = new long[1] ;
         P00132_A4SecRoleId = new short[1] ;
         P00132_A3SecFunctionalityKey = new String[] {""} ;
         AV21Option = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.wwpbaseobjects.secrolesecfunctionalityrolewcgetfilterdata__default(),
            new Object[][] {
                new Object[] {
               P00132_A1SecFunctionalityId, P00132_A4SecRoleId, P00132_A3SecFunctionalityKey
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV50SecRoleId ;
      private short A4SecRoleId ;
      private int AV57GXV1 ;
      private long A1SecFunctionalityId ;
      private long AV29count ;
      private String scmdbuf ;
      private bool AV8IsAuthorized ;
      private bool GXt_boolean1 ;
      private bool returnInSub ;
      private bool BRK132 ;
      private String AV28OptionIndexesJson ;
      private String AV23OptionsJson ;
      private String AV26OptionsDescJson ;
      private String AV19DDOName ;
      private String AV17SearchTxt ;
      private String AV18SearchTxtTo ;
      private String AV54SecFunctionalityKey ;
      private String AV10TFSecFunctionalityKey ;
      private String AV11TFSecFunctionalityKey_Sel ;
      private String lV54SecFunctionalityKey ;
      private String lV10TFSecFunctionalityKey ;
      private String A3SecFunctionalityKey ;
      private String AV21Option ;
      private IGxSession AV30Session ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] P00132_A1SecFunctionalityId ;
      private short[] P00132_A4SecRoleId ;
      private String[] P00132_A3SecFunctionalityKey ;
      private String aP3_OptionsJson ;
      private String aP4_OptionsDescJson ;
      private String aP5_OptionIndexesJson ;
      private GxSimpleCollection<String> AV22Options ;
      private GxSimpleCollection<String> AV25OptionsDesc ;
      private GxSimpleCollection<String> AV27OptionIndexes ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState AV32GridState ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue AV33GridStateFilterValue ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV51WWPContext ;
   }

   public class secrolesecfunctionalityrolewcgetfilterdata__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_P00132( IGxContext context ,
                                             String AV54SecFunctionalityKey ,
                                             String AV11TFSecFunctionalityKey_Sel ,
                                             String AV10TFSecFunctionalityKey ,
                                             String A3SecFunctionalityKey ,
                                             short AV50SecRoleId ,
                                             short A4SecRoleId )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int2 ;
         GXv_int2 = new short [4] ;
         Object[] GXv_Object3 ;
         GXv_Object3 = new Object [2] ;
         scmdbuf = "SELECT T1.[SecFunctionalityId], T1.[SecRoleId], T2.[SecFunctionalityKey] FROM ([SecFunctionalityRole] T1 WITH (NOLOCK) INNER JOIN [SecFunctionality] T2 WITH (NOLOCK) ON T2.[SecFunctionalityId] = T1.[SecFunctionalityId])";
         scmdbuf = scmdbuf + " WHERE (T1.[SecRoleId] = @AV50SecRoleId)";
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV54SecFunctionalityKey)) )
         {
            sWhereString = sWhereString + " and (T2.[SecFunctionalityKey] like '%' + @lV54SecFunctionalityKey + '%')";
         }
         else
         {
            GXv_int2[1] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV11TFSecFunctionalityKey_Sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV10TFSecFunctionalityKey)) ) )
         {
            sWhereString = sWhereString + " and (T2.[SecFunctionalityKey] like @lV10TFSecFunctionalityKey)";
         }
         else
         {
            GXv_int2[2] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV11TFSecFunctionalityKey_Sel)) )
         {
            sWhereString = sWhereString + " and (T2.[SecFunctionalityKey] = @AV11TFSecFunctionalityKey_Sel)";
         }
         else
         {
            GXv_int2[3] = 1;
         }
         scmdbuf = scmdbuf + sWhereString;
         scmdbuf = scmdbuf + " ORDER BY T1.[SecRoleId], T2.[SecFunctionalityKey]";
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
                     return conditional_P00132(context, (String)dynConstraints[0] , (String)dynConstraints[1] , (String)dynConstraints[2] , (String)dynConstraints[3] , (short)dynConstraints[4] , (short)dynConstraints[5] );
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
          Object[] prmP00132 ;
          prmP00132 = new Object[] {
          new Object[] {"@AV50SecRoleId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@lV54SecFunctionalityKey",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV10TFSecFunctionalityKey",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV11TFSecFunctionalityKey_Sel",SqlDbType.NVarChar,100,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00132", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00132,100,0,true,false )
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
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
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
                   stmt.SetParameter(sIdx, (short)parms[4]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[5]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[6]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[7]);
                }
                return;
       }
    }

 }

 [ServiceContract(Namespace = "GeneXus.Programs.wwpbaseobjects.secrolesecfunctionalityrolewcgetfilterdata_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class secrolesecfunctionalityrolewcgetfilterdata_services : GxRestService
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
          if ( ! ProcessHeaders("secrolesecfunctionalityrolewcgetfilterdata") )
          {
             return  ;
          }
          secrolesecfunctionalityrolewcgetfilterdata worker = new secrolesecfunctionalityrolewcgetfilterdata(context) ;
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
