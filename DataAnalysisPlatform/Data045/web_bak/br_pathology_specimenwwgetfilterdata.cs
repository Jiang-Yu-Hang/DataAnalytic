/*
               File: BR_Pathology_SpecimenWWGetFilterData
        Description: BR_Pathology_Specimen WWGet Filter Data
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:35:23.35
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
   public class br_pathology_specimenwwgetfilterdata : GXProcedure
   {
      public br_pathology_specimenwwgetfilterdata( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_pathology_specimenwwgetfilterdata( IGxContext context )
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
         br_pathology_specimenwwgetfilterdata objbr_pathology_specimenwwgetfilterdata;
         objbr_pathology_specimenwwgetfilterdata = new br_pathology_specimenwwgetfilterdata();
         objbr_pathology_specimenwwgetfilterdata.AV19DDOName = aP0_DDOName;
         objbr_pathology_specimenwwgetfilterdata.AV17SearchTxt = aP1_SearchTxt;
         objbr_pathology_specimenwwgetfilterdata.AV18SearchTxtTo = aP2_SearchTxtTo;
         objbr_pathology_specimenwwgetfilterdata.AV23OptionsJson = "" ;
         objbr_pathology_specimenwwgetfilterdata.AV26OptionsDescJson = "" ;
         objbr_pathology_specimenwwgetfilterdata.AV28OptionIndexesJson = "" ;
         objbr_pathology_specimenwwgetfilterdata.context.SetSubmitInitialConfig(context);
         objbr_pathology_specimenwwgetfilterdata.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objbr_pathology_specimenwwgetfilterdata);
         aP3_OptionsJson=this.AV23OptionsJson;
         aP4_OptionsDescJson=this.AV26OptionsDescJson;
         aP5_OptionIndexesJson=this.AV28OptionIndexesJson;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((br_pathology_specimenwwgetfilterdata)stateInfo).executePrivate();
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
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Pathology_Specimen", out  GXt_boolean1) ;
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
            if ( StringUtil.StrCmp(StringUtil.Upper( AV19DDOName), "DDO_BR_PATHOLOGY_SPECIMEN_NAME") == 0 )
            {
               /* Execute user subroutine: 'LOADBR_PATHOLOGY_SPECIMEN_NAMEOPTIONS' */
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
         if ( StringUtil.StrCmp(AV30Session.Get("BR_Pathology_SpecimenWWGridState"), "") == 0 )
         {
            AV32GridState.FromXml(new GeneXus.Programs.wwpbaseobjects.loadgridstate(context).executeUdp(  "BR_Pathology_SpecimenWWGridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         else
         {
            AV32GridState.FromXml(AV30Session.Get("BR_Pathology_SpecimenWWGridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         AV37GXV1 = 1;
         while ( AV37GXV1 <= AV32GridState.gxTpr_Filtervalues.Count )
         {
            AV33GridStateFilterValue = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue)AV32GridState.gxTpr_Filtervalues.Item(AV37GXV1));
            if ( StringUtil.StrCmp(AV33GridStateFilterValue.gxTpr_Name, "TFBR_PATHOLOGY_SPECIMENID") == 0 )
            {
               AV11TFBR_Pathology_SpecimenID = (long)(NumberUtil.Val( AV33GridStateFilterValue.gxTpr_Value, "."));
               AV12TFBR_Pathology_SpecimenID_To = (long)(NumberUtil.Val( AV33GridStateFilterValue.gxTpr_Valueto, "."));
            }
            else if ( StringUtil.StrCmp(AV33GridStateFilterValue.gxTpr_Name, "TFBR_PATHOLOGYID") == 0 )
            {
               AV13TFBR_PathologyID = (long)(NumberUtil.Val( AV33GridStateFilterValue.gxTpr_Value, "."));
               AV14TFBR_PathologyID_To = (long)(NumberUtil.Val( AV33GridStateFilterValue.gxTpr_Valueto, "."));
            }
            else if ( StringUtil.StrCmp(AV33GridStateFilterValue.gxTpr_Name, "TFBR_PATHOLOGY_SPECIMEN_NAME") == 0 )
            {
               AV15TFBR_Pathology_Specimen_Name = AV33GridStateFilterValue.gxTpr_Value;
            }
            else if ( StringUtil.StrCmp(AV33GridStateFilterValue.gxTpr_Name, "TFBR_PATHOLOGY_SPECIMEN_NAME_SEL") == 0 )
            {
               AV16TFBR_Pathology_Specimen_Name_Sel = AV33GridStateFilterValue.gxTpr_Value;
            }
            AV37GXV1 = (int)(AV37GXV1+1);
         }
      }

      protected void S121( )
      {
         /* 'LOADBR_PATHOLOGY_SPECIMEN_NAMEOPTIONS' Routine */
         AV15TFBR_Pathology_Specimen_Name = AV17SearchTxt;
         AV16TFBR_Pathology_Specimen_Name_Sel = "";
         AV39BR_Pathology_SpecimenWWDS_1_Tfbr_pathology_specimenid = AV11TFBR_Pathology_SpecimenID;
         AV40BR_Pathology_SpecimenWWDS_2_Tfbr_pathology_specimenid_to = AV12TFBR_Pathology_SpecimenID_To;
         AV41BR_Pathology_SpecimenWWDS_3_Tfbr_pathologyid = AV13TFBR_PathologyID;
         AV42BR_Pathology_SpecimenWWDS_4_Tfbr_pathologyid_to = AV14TFBR_PathologyID_To;
         AV43BR_Pathology_SpecimenWWDS_5_Tfbr_pathology_specimen_name = AV15TFBR_Pathology_Specimen_Name;
         AV44BR_Pathology_SpecimenWWDS_6_Tfbr_pathology_specimen_name_sel = AV16TFBR_Pathology_Specimen_Name_Sel;
         pr_default.dynParam(0, new Object[]{ new Object[]{
                                              AV39BR_Pathology_SpecimenWWDS_1_Tfbr_pathology_specimenid ,
                                              AV40BR_Pathology_SpecimenWWDS_2_Tfbr_pathology_specimenid_to ,
                                              AV41BR_Pathology_SpecimenWWDS_3_Tfbr_pathologyid ,
                                              AV42BR_Pathology_SpecimenWWDS_4_Tfbr_pathologyid_to ,
                                              AV44BR_Pathology_SpecimenWWDS_6_Tfbr_pathology_specimen_name_sel ,
                                              AV43BR_Pathology_SpecimenWWDS_5_Tfbr_pathology_specimen_name ,
                                              A274BR_Pathology_SpecimenID ,
                                              A226BR_PathologyID ,
                                              A275BR_Pathology_Specimen_Name } ,
                                              new int[]{
                                              TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.BOOLEAN, TypeConstants.STRING,
                                              TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV43BR_Pathology_SpecimenWWDS_5_Tfbr_pathology_specimen_name = StringUtil.Concat( StringUtil.RTrim( AV43BR_Pathology_SpecimenWWDS_5_Tfbr_pathology_specimen_name), "%", "");
         /* Using cursor P002M2 */
         pr_default.execute(0, new Object[] {AV39BR_Pathology_SpecimenWWDS_1_Tfbr_pathology_specimenid, AV40BR_Pathology_SpecimenWWDS_2_Tfbr_pathology_specimenid_to, AV41BR_Pathology_SpecimenWWDS_3_Tfbr_pathologyid, AV42BR_Pathology_SpecimenWWDS_4_Tfbr_pathologyid_to, lV43BR_Pathology_SpecimenWWDS_5_Tfbr_pathology_specimen_name, AV44BR_Pathology_SpecimenWWDS_6_Tfbr_pathology_specimen_name_sel});
         while ( (pr_default.getStatus(0) != 101) )
         {
            BRK2M2 = false;
            A275BR_Pathology_Specimen_Name = P002M2_A275BR_Pathology_Specimen_Name[0];
            n275BR_Pathology_Specimen_Name = P002M2_n275BR_Pathology_Specimen_Name[0];
            A226BR_PathologyID = P002M2_A226BR_PathologyID[0];
            n226BR_PathologyID = P002M2_n226BR_PathologyID[0];
            A274BR_Pathology_SpecimenID = P002M2_A274BR_Pathology_SpecimenID[0];
            AV29count = 0;
            while ( (pr_default.getStatus(0) != 101) && ( StringUtil.StrCmp(P002M2_A275BR_Pathology_Specimen_Name[0], A275BR_Pathology_Specimen_Name) == 0 ) )
            {
               BRK2M2 = false;
               A274BR_Pathology_SpecimenID = P002M2_A274BR_Pathology_SpecimenID[0];
               AV29count = (long)(AV29count+1);
               BRK2M2 = true;
               pr_default.readNext(0);
            }
            if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A275BR_Pathology_Specimen_Name)) )
            {
               AV21Option = A275BR_Pathology_Specimen_Name;
               AV22Options.Add(AV21Option, 0);
               AV27OptionIndexes.Add(StringUtil.Trim( context.localUtil.Format( (decimal)(AV29count), "Z,ZZZ,ZZZ,ZZ9")), 0);
            }
            if ( AV22Options.Count == 50 )
            {
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
            }
            if ( ! BRK2M2 )
            {
               BRK2M2 = true;
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
         AV9WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV30Session = context.GetSession();
         AV32GridState = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState(context);
         AV33GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
         AV15TFBR_Pathology_Specimen_Name = "";
         AV16TFBR_Pathology_Specimen_Name_Sel = "";
         AV43BR_Pathology_SpecimenWWDS_5_Tfbr_pathology_specimen_name = "";
         AV44BR_Pathology_SpecimenWWDS_6_Tfbr_pathology_specimen_name_sel = "";
         scmdbuf = "";
         lV43BR_Pathology_SpecimenWWDS_5_Tfbr_pathology_specimen_name = "";
         A275BR_Pathology_Specimen_Name = "";
         P002M2_A275BR_Pathology_Specimen_Name = new String[] {""} ;
         P002M2_n275BR_Pathology_Specimen_Name = new bool[] {false} ;
         P002M2_A226BR_PathologyID = new long[1] ;
         P002M2_n226BR_PathologyID = new bool[] {false} ;
         P002M2_A274BR_Pathology_SpecimenID = new long[1] ;
         AV21Option = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_pathology_specimenwwgetfilterdata__default(),
            new Object[][] {
                new Object[] {
               P002M2_A275BR_Pathology_Specimen_Name, P002M2_n275BR_Pathology_Specimen_Name, P002M2_A226BR_PathologyID, P002M2_n226BR_PathologyID, P002M2_A274BR_Pathology_SpecimenID
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private int AV37GXV1 ;
      private long AV11TFBR_Pathology_SpecimenID ;
      private long AV12TFBR_Pathology_SpecimenID_To ;
      private long AV13TFBR_PathologyID ;
      private long AV14TFBR_PathologyID_To ;
      private long AV39BR_Pathology_SpecimenWWDS_1_Tfbr_pathology_specimenid ;
      private long AV40BR_Pathology_SpecimenWWDS_2_Tfbr_pathology_specimenid_to ;
      private long AV41BR_Pathology_SpecimenWWDS_3_Tfbr_pathologyid ;
      private long AV42BR_Pathology_SpecimenWWDS_4_Tfbr_pathologyid_to ;
      private long A274BR_Pathology_SpecimenID ;
      private long A226BR_PathologyID ;
      private long AV29count ;
      private String scmdbuf ;
      private bool AV8IsAuthorized ;
      private bool GXt_boolean1 ;
      private bool returnInSub ;
      private bool BRK2M2 ;
      private bool n275BR_Pathology_Specimen_Name ;
      private bool n226BR_PathologyID ;
      private String AV28OptionIndexesJson ;
      private String AV23OptionsJson ;
      private String AV26OptionsDescJson ;
      private String AV19DDOName ;
      private String AV17SearchTxt ;
      private String AV18SearchTxtTo ;
      private String AV15TFBR_Pathology_Specimen_Name ;
      private String AV16TFBR_Pathology_Specimen_Name_Sel ;
      private String AV43BR_Pathology_SpecimenWWDS_5_Tfbr_pathology_specimen_name ;
      private String AV44BR_Pathology_SpecimenWWDS_6_Tfbr_pathology_specimen_name_sel ;
      private String lV43BR_Pathology_SpecimenWWDS_5_Tfbr_pathology_specimen_name ;
      private String A275BR_Pathology_Specimen_Name ;
      private String AV21Option ;
      private IGxSession AV30Session ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] P002M2_A275BR_Pathology_Specimen_Name ;
      private bool[] P002M2_n275BR_Pathology_Specimen_Name ;
      private long[] P002M2_A226BR_PathologyID ;
      private bool[] P002M2_n226BR_PathologyID ;
      private long[] P002M2_A274BR_Pathology_SpecimenID ;
      private String aP3_OptionsJson ;
      private String aP4_OptionsDescJson ;
      private String aP5_OptionIndexesJson ;
      private GxSimpleCollection<String> AV22Options ;
      private GxSimpleCollection<String> AV25OptionsDesc ;
      private GxSimpleCollection<String> AV27OptionIndexes ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV9WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState AV32GridState ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue AV33GridStateFilterValue ;
   }

   public class br_pathology_specimenwwgetfilterdata__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_P002M2( IGxContext context ,
                                             long AV39BR_Pathology_SpecimenWWDS_1_Tfbr_pathology_specimenid ,
                                             long AV40BR_Pathology_SpecimenWWDS_2_Tfbr_pathology_specimenid_to ,
                                             long AV41BR_Pathology_SpecimenWWDS_3_Tfbr_pathologyid ,
                                             long AV42BR_Pathology_SpecimenWWDS_4_Tfbr_pathologyid_to ,
                                             String AV44BR_Pathology_SpecimenWWDS_6_Tfbr_pathology_specimen_name_sel ,
                                             String AV43BR_Pathology_SpecimenWWDS_5_Tfbr_pathology_specimen_name ,
                                             long A274BR_Pathology_SpecimenID ,
                                             long A226BR_PathologyID ,
                                             String A275BR_Pathology_Specimen_Name )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int2 ;
         GXv_int2 = new short [6] ;
         Object[] GXv_Object3 ;
         GXv_Object3 = new Object [2] ;
         scmdbuf = "SELECT [BR_Pathology_Specimen_Name], [BR_PathologyID], [BR_Pathology_SpecimenID] FROM [BR_Pathology_Specimen] WITH (NOLOCK)";
         if ( ! (0==AV39BR_Pathology_SpecimenWWDS_1_Tfbr_pathology_specimenid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_SpecimenID] >= @AV39BR_Pathology_SpecimenWWDS_1_Tfbr_pathology_specimenid)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_SpecimenID] >= @AV39BR_Pathology_SpecimenWWDS_1_Tfbr_pathology_specimenid)";
            }
         }
         else
         {
            GXv_int2[0] = 1;
         }
         if ( ! (0==AV40BR_Pathology_SpecimenWWDS_2_Tfbr_pathology_specimenid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_SpecimenID] <= @AV40BR_Pathology_SpecimenWWDS_2_Tfbr_pathology_specimenid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_SpecimenID] <= @AV40BR_Pathology_SpecimenWWDS_2_Tfbr_pathology_specimenid_to)";
            }
         }
         else
         {
            GXv_int2[1] = 1;
         }
         if ( ! (0==AV41BR_Pathology_SpecimenWWDS_3_Tfbr_pathologyid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_PathologyID] >= @AV41BR_Pathology_SpecimenWWDS_3_Tfbr_pathologyid)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_PathologyID] >= @AV41BR_Pathology_SpecimenWWDS_3_Tfbr_pathologyid)";
            }
         }
         else
         {
            GXv_int2[2] = 1;
         }
         if ( ! (0==AV42BR_Pathology_SpecimenWWDS_4_Tfbr_pathologyid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_PathologyID] <= @AV42BR_Pathology_SpecimenWWDS_4_Tfbr_pathologyid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_PathologyID] <= @AV42BR_Pathology_SpecimenWWDS_4_Tfbr_pathologyid_to)";
            }
         }
         else
         {
            GXv_int2[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV44BR_Pathology_SpecimenWWDS_6_Tfbr_pathology_specimen_name_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV43BR_Pathology_SpecimenWWDS_5_Tfbr_pathology_specimen_name)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Specimen_Name] like @lV43BR_Pathology_SpecimenWWDS_5_Tfbr_pathology_specimen_name)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Specimen_Name] like @lV43BR_Pathology_SpecimenWWDS_5_Tfbr_pathology_specimen_name)";
            }
         }
         else
         {
            GXv_int2[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV44BR_Pathology_SpecimenWWDS_6_Tfbr_pathology_specimen_name_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Pathology_Specimen_Name] = @AV44BR_Pathology_SpecimenWWDS_6_Tfbr_pathology_specimen_name_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Pathology_Specimen_Name] = @AV44BR_Pathology_SpecimenWWDS_6_Tfbr_pathology_specimen_name_sel)";
            }
         }
         else
         {
            GXv_int2[5] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            scmdbuf = scmdbuf + " WHERE" + sWhereString;
         }
         scmdbuf = scmdbuf + " ORDER BY [BR_Pathology_Specimen_Name]";
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
                     return conditional_P002M2(context, (long)dynConstraints[0] , (long)dynConstraints[1] , (long)dynConstraints[2] , (long)dynConstraints[3] , (String)dynConstraints[4] , (String)dynConstraints[5] , (long)dynConstraints[6] , (long)dynConstraints[7] , (String)dynConstraints[8] );
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
          Object[] prmP002M2 ;
          prmP002M2 = new Object[] {
          new Object[] {"@AV39BR_Pathology_SpecimenWWDS_1_Tfbr_pathology_specimenid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV40BR_Pathology_SpecimenWWDS_2_Tfbr_pathology_specimenid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV41BR_Pathology_SpecimenWWDS_3_Tfbr_pathologyid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV42BR_Pathology_SpecimenWWDS_4_Tfbr_pathologyid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV43BR_Pathology_SpecimenWWDS_5_Tfbr_pathology_specimen_name",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV44BR_Pathology_SpecimenWWDS_6_Tfbr_pathology_specimen_name_sel",SqlDbType.NVarChar,100,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P002M2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP002M2,100,0,true,false )
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
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((long[]) buf[4])[0] = rslt.getLong(3) ;
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
                   stmt.SetParameter(sIdx, (long)parms[7]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[8]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[9]);
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

 [ServiceContract(Namespace = "GeneXus.Programs.br_pathology_specimenwwgetfilterdata_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class br_pathology_specimenwwgetfilterdata_services : GxRestService
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
          if ( ! ProcessHeaders("br_pathology_specimenwwgetfilterdata") )
          {
             return  ;
          }
          br_pathology_specimenwwgetfilterdata worker = new br_pathology_specimenwwgetfilterdata(context) ;
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
