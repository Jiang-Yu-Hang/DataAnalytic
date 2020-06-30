/*
               File: WWPBaseObjects.SecFunctionalitySecFunctionalityRoleWCGetFilterData
        Description: Sec Functionality Sec Functionality Role WCGet Filter Data
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:5:52.32
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
   public class secfunctionalitysecfunctionalityrolewcgetfilterdata : GXProcedure
   {
      public secfunctionalitysecfunctionalityrolewcgetfilterdata( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public secfunctionalitysecfunctionalityrolewcgetfilterdata( IGxContext context )
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
         this.AV16DDOName = aP0_DDOName;
         this.AV14SearchTxt = aP1_SearchTxt;
         this.AV15SearchTxtTo = aP2_SearchTxtTo;
         this.AV20OptionsJson = "" ;
         this.AV23OptionsDescJson = "" ;
         this.AV25OptionIndexesJson = "" ;
         initialize();
         executePrivate();
         aP3_OptionsJson=this.AV20OptionsJson;
         aP4_OptionsDescJson=this.AV23OptionsDescJson;
         aP5_OptionIndexesJson=this.AV25OptionIndexesJson;
      }

      public String executeUdp( String aP0_DDOName ,
                                String aP1_SearchTxt ,
                                String aP2_SearchTxtTo ,
                                out String aP3_OptionsJson ,
                                out String aP4_OptionsDescJson )
      {
         this.AV16DDOName = aP0_DDOName;
         this.AV14SearchTxt = aP1_SearchTxt;
         this.AV15SearchTxtTo = aP2_SearchTxtTo;
         this.AV20OptionsJson = "" ;
         this.AV23OptionsDescJson = "" ;
         this.AV25OptionIndexesJson = "" ;
         initialize();
         executePrivate();
         aP3_OptionsJson=this.AV20OptionsJson;
         aP4_OptionsDescJson=this.AV23OptionsDescJson;
         aP5_OptionIndexesJson=this.AV25OptionIndexesJson;
         return AV25OptionIndexesJson ;
      }

      public void executeSubmit( String aP0_DDOName ,
                                 String aP1_SearchTxt ,
                                 String aP2_SearchTxtTo ,
                                 out String aP3_OptionsJson ,
                                 out String aP4_OptionsDescJson ,
                                 out String aP5_OptionIndexesJson )
      {
         secfunctionalitysecfunctionalityrolewcgetfilterdata objsecfunctionalitysecfunctionalityrolewcgetfilterdata;
         objsecfunctionalitysecfunctionalityrolewcgetfilterdata = new secfunctionalitysecfunctionalityrolewcgetfilterdata();
         objsecfunctionalitysecfunctionalityrolewcgetfilterdata.AV16DDOName = aP0_DDOName;
         objsecfunctionalitysecfunctionalityrolewcgetfilterdata.AV14SearchTxt = aP1_SearchTxt;
         objsecfunctionalitysecfunctionalityrolewcgetfilterdata.AV15SearchTxtTo = aP2_SearchTxtTo;
         objsecfunctionalitysecfunctionalityrolewcgetfilterdata.AV20OptionsJson = "" ;
         objsecfunctionalitysecfunctionalityrolewcgetfilterdata.AV23OptionsDescJson = "" ;
         objsecfunctionalitysecfunctionalityrolewcgetfilterdata.AV25OptionIndexesJson = "" ;
         objsecfunctionalitysecfunctionalityrolewcgetfilterdata.context.SetSubmitInitialConfig(context);
         objsecfunctionalitysecfunctionalityrolewcgetfilterdata.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objsecfunctionalitysecfunctionalityrolewcgetfilterdata);
         aP3_OptionsJson=this.AV20OptionsJson;
         aP4_OptionsDescJson=this.AV23OptionsDescJson;
         aP5_OptionIndexesJson=this.AV25OptionIndexesJson;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((secfunctionalitysecfunctionalityrolewcgetfilterdata)stateInfo).executePrivate();
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
         AV19Options = (GxSimpleCollection<String>)(new GxSimpleCollection<String>());
         AV22OptionsDesc = (GxSimpleCollection<String>)(new GxSimpleCollection<String>());
         AV24OptionIndexes = (GxSimpleCollection<String>)(new GxSimpleCollection<String>());
         GXt_boolean1 = AV8IsAuthorized;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "WWSecFunctionality", out  GXt_boolean1) ;
         AV8IsAuthorized = GXt_boolean1;
         if ( AV8IsAuthorized )
         {
            new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV33WWPContext) ;
            /* Execute user subroutine: 'LOADGRIDSTATE' */
            S111 ();
            if ( returnInSub )
            {
               this.cleanup();
               if (true) return;
            }
            if ( StringUtil.StrCmp(StringUtil.Upper( AV16DDOName), "DDO_SECROLENAME") == 0 )
            {
               /* Execute user subroutine: 'LOADSECROLENAMEOPTIONS' */
               S121 ();
               if ( returnInSub )
               {
                  this.cleanup();
                  if (true) return;
               }
            }
            else if ( StringUtil.StrCmp(StringUtil.Upper( AV16DDOName), "DDO_SECROLEDESCRIPTION") == 0 )
            {
               /* Execute user subroutine: 'LOADSECROLEDESCRIPTIONOPTIONS' */
               S131 ();
               if ( returnInSub )
               {
                  this.cleanup();
                  if (true) return;
               }
            }
         }
         AV20OptionsJson = AV19Options.ToJSonString(false);
         AV23OptionsDescJson = AV22OptionsDesc.ToJSonString(false);
         AV25OptionIndexesJson = AV24OptionIndexes.ToJSonString(false);
         this.cleanup();
      }

      protected void S111( )
      {
         /* 'LOADGRIDSTATE' Routine */
         if ( StringUtil.StrCmp(AV27Session.Get("WWPBaseObjects.SecFunctionalitySecFunctionalityRoleWCGridState"), "") == 0 )
         {
            AV29GridState.FromXml(new GeneXus.Programs.wwpbaseobjects.loadgridstate(context).executeUdp(  "WWPBaseObjects.SecFunctionalitySecFunctionalityRoleWCGridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         else
         {
            AV29GridState.FromXml(AV27Session.Get("WWPBaseObjects.SecFunctionalitySecFunctionalityRoleWCGridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         AV37GXV1 = 1;
         while ( AV37GXV1 <= AV29GridState.gxTpr_Filtervalues.Count )
         {
            AV30GridStateFilterValue = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue)AV29GridState.gxTpr_Filtervalues.Item(AV37GXV1));
            if ( StringUtil.StrCmp(AV30GridStateFilterValue.gxTpr_Name, "SECROLENAME") == 0 )
            {
               AV34SecRoleName = AV30GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV30GridStateFilterValue.gxTpr_Name, "TFSECROLENAME") == 0 )
            {
               AV10TFSecRoleName = AV30GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV30GridStateFilterValue.gxTpr_Name, "TFSECROLENAME_SEL") == 0 )
            {
               AV11TFSecRoleName_Sel = AV30GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV30GridStateFilterValue.gxTpr_Name, "TFSECROLEDESCRIPTION") == 0 )
            {
               AV12TFSecRoleDescription = AV30GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV30GridStateFilterValue.gxTpr_Name, "TFSECROLEDESCRIPTION_SEL") == 0 )
            {
               AV13TFSecRoleDescription_Sel = AV30GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV30GridStateFilterValue.gxTpr_Name, "PARM_&SECFUNCTIONALITYID") == 0 )
            {
               AV32SecFunctionalityId = (long)(NumberUtil.Val( AV30GridStateFilterValue.gxTpr_Value, "."));
            }
            AV37GXV1 = (int)(AV37GXV1+1);
         }
      }

      protected void S121( )
      {
         /* 'LOADSECROLENAMEOPTIONS' Routine */
         AV10TFSecRoleName = AV14SearchTxt;
         AV11TFSecRoleName_Sel = "";
         pr_default.dynParam(0, new Object[]{ new Object[]{
                                              AV34SecRoleName ,
                                              AV11TFSecRoleName_Sel ,
                                              AV10TFSecRoleName ,
                                              AV13TFSecRoleDescription_Sel ,
                                              AV12TFSecRoleDescription ,
                                              A13SecRoleName ,
                                              A12SecRoleDescription ,
                                              AV32SecFunctionalityId ,
                                              A1SecFunctionalityId } ,
                                              new int[]{
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.LONG
                                              }
         } ) ;
         lV34SecRoleName = StringUtil.Concat( StringUtil.RTrim( AV34SecRoleName), "%", "");
         lV10TFSecRoleName = StringUtil.Concat( StringUtil.RTrim( AV10TFSecRoleName), "%", "");
         lV12TFSecRoleDescription = StringUtil.Concat( StringUtil.RTrim( AV12TFSecRoleDescription), "%", "");
         /* Using cursor P000W2 */
         pr_default.execute(0, new Object[] {AV32SecFunctionalityId, lV34SecRoleName, lV10TFSecRoleName, AV11TFSecRoleName_Sel, lV12TFSecRoleDescription, AV13TFSecRoleDescription_Sel});
         while ( (pr_default.getStatus(0) != 101) )
         {
            BRK0W2 = false;
            A4SecRoleId = P000W2_A4SecRoleId[0];
            A1SecFunctionalityId = P000W2_A1SecFunctionalityId[0];
            A13SecRoleName = P000W2_A13SecRoleName[0];
            A12SecRoleDescription = P000W2_A12SecRoleDescription[0];
            A13SecRoleName = P000W2_A13SecRoleName[0];
            A12SecRoleDescription = P000W2_A12SecRoleDescription[0];
            AV26count = 0;
            while ( (pr_default.getStatus(0) != 101) && ( P000W2_A1SecFunctionalityId[0] == A1SecFunctionalityId ) && ( StringUtil.StrCmp(P000W2_A13SecRoleName[0], A13SecRoleName) == 0 ) )
            {
               BRK0W2 = false;
               A4SecRoleId = P000W2_A4SecRoleId[0];
               AV26count = (long)(AV26count+1);
               BRK0W2 = true;
               pr_default.readNext(0);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A13SecRoleName)) )
            {
               AV18Option = A13SecRoleName;
               AV19Options.Add(AV18Option, 0);
               AV24OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV26count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV19Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK0W2 )
            {
               BRK0W2 = true;
               pr_default.readNext(0);
            }
         }
         pr_default.close(0);
      }

      protected void S131( )
      {
         /* 'LOADSECROLEDESCRIPTIONOPTIONS' Routine */
         AV12TFSecRoleDescription = AV14SearchTxt;
         AV13TFSecRoleDescription_Sel = "";
         pr_default.dynParam(1, new Object[]{ new Object[]{
                                              AV34SecRoleName ,
                                              AV11TFSecRoleName_Sel ,
                                              AV10TFSecRoleName ,
                                              AV13TFSecRoleDescription_Sel ,
                                              AV12TFSecRoleDescription ,
                                              A13SecRoleName ,
                                              A12SecRoleDescription ,
                                              AV32SecFunctionalityId ,
                                              A1SecFunctionalityId } ,
                                              new int[]{
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.LONG
                                              }
         } ) ;
         lV34SecRoleName = StringUtil.Concat( StringUtil.RTrim( AV34SecRoleName), "%", "");
         lV10TFSecRoleName = StringUtil.Concat( StringUtil.RTrim( AV10TFSecRoleName), "%", "");
         lV12TFSecRoleDescription = StringUtil.Concat( StringUtil.RTrim( AV12TFSecRoleDescription), "%", "");
         /* Using cursor P000W3 */
         pr_default.execute(1, new Object[] {AV32SecFunctionalityId, lV34SecRoleName, lV10TFSecRoleName, AV11TFSecRoleName_Sel, lV12TFSecRoleDescription, AV13TFSecRoleDescription_Sel});
         while ( (pr_default.getStatus(1) != 101) )
         {
            BRK0W4 = false;
            A4SecRoleId = P000W3_A4SecRoleId[0];
            A1SecFunctionalityId = P000W3_A1SecFunctionalityId[0];
            A12SecRoleDescription = P000W3_A12SecRoleDescription[0];
            A13SecRoleName = P000W3_A13SecRoleName[0];
            A12SecRoleDescription = P000W3_A12SecRoleDescription[0];
            A13SecRoleName = P000W3_A13SecRoleName[0];
            AV26count = 0;
            while ( (pr_default.getStatus(1) != 101) && ( P000W3_A1SecFunctionalityId[0] == A1SecFunctionalityId ) && ( StringUtil.StrCmp(P000W3_A12SecRoleDescription[0], A12SecRoleDescription) == 0 ) )
            {
               BRK0W4 = false;
               A4SecRoleId = P000W3_A4SecRoleId[0];
               AV26count = (long)(AV26count+1);
               BRK0W4 = true;
               pr_default.readNext(1);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A12SecRoleDescription)) )
            {
               AV18Option = A12SecRoleDescription;
               AV19Options.Add(AV18Option, 0);
               AV24OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV26count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV19Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK0W4 )
            {
               BRK0W4 = true;
               pr_default.readNext(1);
            }
         }
         pr_default.close(1);
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
         AV19Options = new GxSimpleCollection<String>();
         AV22OptionsDesc = new GxSimpleCollection<String>();
         AV24OptionIndexes = new GxSimpleCollection<String>();
         AV33WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV27Session = context.GetSession();
         AV29GridState = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState(context);
         AV30GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
         AV34SecRoleName = "";
         AV10TFSecRoleName = "";
         AV11TFSecRoleName_Sel = "";
         AV12TFSecRoleDescription = "";
         AV13TFSecRoleDescription_Sel = "";
         scmdbuf = "";
         lV34SecRoleName = "";
         lV10TFSecRoleName = "";
         lV12TFSecRoleDescription = "";
         A13SecRoleName = "";
         A12SecRoleDescription = "";
         P000W2_A4SecRoleId = new short[1] ;
         P000W2_A1SecFunctionalityId = new long[1] ;
         P000W2_A13SecRoleName = new String[] {""} ;
         P000W2_A12SecRoleDescription = new String[] {""} ;
         AV18Option = "";
         P000W3_A4SecRoleId = new short[1] ;
         P000W3_A1SecFunctionalityId = new long[1] ;
         P000W3_A12SecRoleDescription = new String[] {""} ;
         P000W3_A13SecRoleName = new String[] {""} ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.wwpbaseobjects.secfunctionalitysecfunctionalityrolewcgetfilterdata__default(),
            new Object[][] {
                new Object[] {
               P000W2_A4SecRoleId, P000W2_A1SecFunctionalityId, P000W2_A13SecRoleName, P000W2_A12SecRoleDescription
               }
               , new Object[] {
               P000W3_A4SecRoleId, P000W3_A1SecFunctionalityId, P000W3_A12SecRoleDescription, P000W3_A13SecRoleName
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short A4SecRoleId ;
      private int AV37GXV1 ;
      private long AV32SecFunctionalityId ;
      private long A1SecFunctionalityId ;
      private long AV26count ;
      private String scmdbuf ;
      private bool AV8IsAuthorized ;
      private bool GXt_boolean1 ;
      private bool returnInSub ;
      private bool BRK0W2 ;
      private bool BRK0W4 ;
      private String AV25OptionIndexesJson ;
      private String AV20OptionsJson ;
      private String AV23OptionsDescJson ;
      private String AV16DDOName ;
      private String AV14SearchTxt ;
      private String AV15SearchTxtTo ;
      private String AV34SecRoleName ;
      private String AV10TFSecRoleName ;
      private String AV11TFSecRoleName_Sel ;
      private String AV12TFSecRoleDescription ;
      private String AV13TFSecRoleDescription_Sel ;
      private String lV34SecRoleName ;
      private String lV10TFSecRoleName ;
      private String lV12TFSecRoleDescription ;
      private String A13SecRoleName ;
      private String A12SecRoleDescription ;
      private String AV18Option ;
      private IGxSession AV27Session ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] P000W2_A4SecRoleId ;
      private long[] P000W2_A1SecFunctionalityId ;
      private String[] P000W2_A13SecRoleName ;
      private String[] P000W2_A12SecRoleDescription ;
      private short[] P000W3_A4SecRoleId ;
      private long[] P000W3_A1SecFunctionalityId ;
      private String[] P000W3_A12SecRoleDescription ;
      private String[] P000W3_A13SecRoleName ;
      private String aP3_OptionsJson ;
      private String aP4_OptionsDescJson ;
      private String aP5_OptionIndexesJson ;
      private GxSimpleCollection<String> AV19Options ;
      private GxSimpleCollection<String> AV22OptionsDesc ;
      private GxSimpleCollection<String> AV24OptionIndexes ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState AV29GridState ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue AV30GridStateFilterValue ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV33WWPContext ;
   }

   public class secfunctionalitysecfunctionalityrolewcgetfilterdata__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_P000W2( IGxContext context ,
                                             String AV34SecRoleName ,
                                             String AV11TFSecRoleName_Sel ,
                                             String AV10TFSecRoleName ,
                                             String AV13TFSecRoleDescription_Sel ,
                                             String AV12TFSecRoleDescription ,
                                             String A13SecRoleName ,
                                             String A12SecRoleDescription ,
                                             long AV32SecFunctionalityId ,
                                             long A1SecFunctionalityId )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int2 ;
         GXv_int2 = new short [6] ;
         Object[] GXv_Object3 ;
         GXv_Object3 = new Object [2] ;
         scmdbuf = "SELECT T1.[SecRoleId], T1.[SecFunctionalityId], T2.[SecRoleName], T2.[SecRoleDescription] FROM ([SecFunctionalityRole] T1 WITH (NOLOCK) INNER JOIN [SecRole] T2 WITH (NOLOCK) ON T2.[SecRoleId] = T1.[SecRoleId])";
         scmdbuf = scmdbuf + " WHERE (T1.[SecFunctionalityId] = @AV32SecFunctionalityId)";
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV34SecRoleName)) )
         {
            sWhereString = sWhereString + " and (T2.[SecRoleName] like '%' + @lV34SecRoleName + '%')";
         }
         else
         {
            GXv_int2[1] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV11TFSecRoleName_Sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV10TFSecRoleName)) ) )
         {
            sWhereString = sWhereString + " and (T2.[SecRoleName] like @lV10TFSecRoleName)";
         }
         else
         {
            GXv_int2[2] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV11TFSecRoleName_Sel)) )
         {
            sWhereString = sWhereString + " and (T2.[SecRoleName] = @AV11TFSecRoleName_Sel)";
         }
         else
         {
            GXv_int2[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV13TFSecRoleDescription_Sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV12TFSecRoleDescription)) ) )
         {
            sWhereString = sWhereString + " and (T2.[SecRoleDescription] like @lV12TFSecRoleDescription)";
         }
         else
         {
            GXv_int2[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV13TFSecRoleDescription_Sel)) )
         {
            sWhereString = sWhereString + " and (T2.[SecRoleDescription] = @AV13TFSecRoleDescription_Sel)";
         }
         else
         {
            GXv_int2[5] = 1;
         }
         scmdbuf = scmdbuf + sWhereString;
         scmdbuf = scmdbuf + " ORDER BY T1.[SecFunctionalityId], T2.[SecRoleName]";
         GXv_Object3[0] = scmdbuf;
         GXv_Object3[1] = GXv_int2;
         return GXv_Object3 ;
      }

      protected Object[] conditional_P000W3( IGxContext context ,
                                             String AV34SecRoleName ,
                                             String AV11TFSecRoleName_Sel ,
                                             String AV10TFSecRoleName ,
                                             String AV13TFSecRoleDescription_Sel ,
                                             String AV12TFSecRoleDescription ,
                                             String A13SecRoleName ,
                                             String A12SecRoleDescription ,
                                             long AV32SecFunctionalityId ,
                                             long A1SecFunctionalityId )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int4 ;
         GXv_int4 = new short [6] ;
         Object[] GXv_Object5 ;
         GXv_Object5 = new Object [2] ;
         scmdbuf = "SELECT T1.[SecRoleId], T1.[SecFunctionalityId], T2.[SecRoleDescription], T2.[SecRoleName] FROM ([SecFunctionalityRole] T1 WITH (NOLOCK) INNER JOIN [SecRole] T2 WITH (NOLOCK) ON T2.[SecRoleId] = T1.[SecRoleId])";
         scmdbuf = scmdbuf + " WHERE (T1.[SecFunctionalityId] = @AV32SecFunctionalityId)";
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV34SecRoleName)) )
         {
            sWhereString = sWhereString + " and (T2.[SecRoleName] like '%' + @lV34SecRoleName + '%')";
         }
         else
         {
            GXv_int4[1] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV11TFSecRoleName_Sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV10TFSecRoleName)) ) )
         {
            sWhereString = sWhereString + " and (T2.[SecRoleName] like @lV10TFSecRoleName)";
         }
         else
         {
            GXv_int4[2] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV11TFSecRoleName_Sel)) )
         {
            sWhereString = sWhereString + " and (T2.[SecRoleName] = @AV11TFSecRoleName_Sel)";
         }
         else
         {
            GXv_int4[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV13TFSecRoleDescription_Sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV12TFSecRoleDescription)) ) )
         {
            sWhereString = sWhereString + " and (T2.[SecRoleDescription] like @lV12TFSecRoleDescription)";
         }
         else
         {
            GXv_int4[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV13TFSecRoleDescription_Sel)) )
         {
            sWhereString = sWhereString + " and (T2.[SecRoleDescription] = @AV13TFSecRoleDescription_Sel)";
         }
         else
         {
            GXv_int4[5] = 1;
         }
         scmdbuf = scmdbuf + sWhereString;
         scmdbuf = scmdbuf + " ORDER BY T1.[SecFunctionalityId], T2.[SecRoleDescription]";
         GXv_Object5[0] = scmdbuf;
         GXv_Object5[1] = GXv_int4;
         return GXv_Object5 ;
      }

      public override Object [] getDynamicStatement( int cursor ,
                                                     IGxContext context ,
                                                     Object [] dynConstraints )
      {
         switch ( cursor )
         {
               case 0 :
                     return conditional_P000W2(context, (String)dynConstraints[0] , (String)dynConstraints[1] , (String)dynConstraints[2] , (String)dynConstraints[3] , (String)dynConstraints[4] , (String)dynConstraints[5] , (String)dynConstraints[6] , (long)dynConstraints[7] , (long)dynConstraints[8] );
               case 1 :
                     return conditional_P000W3(context, (String)dynConstraints[0] , (String)dynConstraints[1] , (String)dynConstraints[2] , (String)dynConstraints[3] , (String)dynConstraints[4] , (String)dynConstraints[5] , (String)dynConstraints[6] , (long)dynConstraints[7] , (long)dynConstraints[8] );
         }
         return base.getDynamicStatement(cursor, context, dynConstraints);
      }

      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP000W2 ;
          prmP000W2 = new Object[] {
          new Object[] {"@AV32SecFunctionalityId",SqlDbType.Decimal,10,0} ,
          new Object[] {"@lV34SecRoleName",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV10TFSecRoleName",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV11TFSecRoleName_Sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV12TFSecRoleDescription",SqlDbType.NVarChar,120,0} ,
          new Object[] {"@AV13TFSecRoleDescription_Sel",SqlDbType.NVarChar,120,0}
          } ;
          Object[] prmP000W3 ;
          prmP000W3 = new Object[] {
          new Object[] {"@AV32SecFunctionalityId",SqlDbType.Decimal,10,0} ,
          new Object[] {"@lV34SecRoleName",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV10TFSecRoleName",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV11TFSecRoleName_Sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV12TFSecRoleDescription",SqlDbType.NVarChar,120,0} ,
          new Object[] {"@AV13TFSecRoleDescription_Sel",SqlDbType.NVarChar,120,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P000W2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000W2,100,0,true,false )
             ,new CursorDef("P000W3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000W3,100,0,true,false )
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
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((long[]) buf[1])[0] = rslt.getLong(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
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
                   stmt.SetParameter(sIdx, (long)parms[6]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[7]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[8]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[9]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[10]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[11]);
                }
                return;
             case 1 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[6]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[7]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[8]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[9]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[10]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[11]);
                }
                return;
       }
    }

 }

 [ServiceContract(Namespace = "GeneXus.Programs.wwpbaseobjects.secfunctionalitysecfunctionalityrolewcgetfilterdata_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class secfunctionalitysecfunctionalityrolewcgetfilterdata_services : GxRestService
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
          if ( ! ProcessHeaders("secfunctionalitysecfunctionalityrolewcgetfilterdata") )
          {
             return  ;
          }
          secfunctionalitysecfunctionalityrolewcgetfilterdata worker = new secfunctionalitysecfunctionalityrolewcgetfilterdata(context) ;
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
