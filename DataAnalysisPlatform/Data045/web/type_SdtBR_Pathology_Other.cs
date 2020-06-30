/*
               File: type_SdtBR_Pathology_Other
        Description: Data Mgmt Portal - RAAP
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:8:20.45
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
using System.Web.Services.Protocols;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Reflection;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   [XmlSerializerFormat]
   [XmlRoot(ElementName = "BR_Pathology_Other" )]
   [XmlType(TypeName =  "BR_Pathology_Other" , Namespace = "DataAnalysisPlatform" )]
   [Serializable]
   public class SdtBR_Pathology_Other : GxSilentTrnSdt, System.Web.SessionState.IRequiresSessionState
   {
      public SdtBR_Pathology_Other( )
      {
      }

      public SdtBR_Pathology_Other( IGxContext context )
      {
         this.context = context;
         constructorCallingAssembly = Assembly.GetCallingAssembly();
         initialize();
      }

      private static Hashtable mapper;
      public override String JsonMap( String value )
      {
         if ( mapper == null )
         {
            mapper = new Hashtable();
         }
         return (String)mapper[value]; ;
      }

      public void Load( long AV288BR_Pathology_OtherID )
      {
         IGxSilentTrn obj ;
         obj = getTransaction();
         obj.LoadKey(new Object[] {(long)AV288BR_Pathology_OtherID});
         return  ;
      }

      public override Object[][] GetBCKey( )
      {
         return (Object[][])(new Object[][]{new Object[]{"BR_Pathology_OtherID", typeof(long)}}) ;
      }

      public override GXProperties GetMetadata( )
      {
         GXProperties metadata = new GXProperties() ;
         metadata.Set("Name", "BR_Pathology_Other");
         metadata.Set("BT", "BR_Pathology_Other");
         metadata.Set("PK", "[ \"BR_Pathology_OtherID\" ]");
         metadata.Set("PKAssigned", "[ \"BR_Pathology_OtherID\" ]");
         metadata.Set("FKList", "[ { \"FK\":[ \"BR_PathologyID\" ],\"FKMap\":[  ] } ]");
         metadata.Set("AllowInsert", "True");
         metadata.Set("AllowUpdate", "True");
         metadata.Set("AllowDelete", "True");
         return metadata ;
      }

      public override GeneXus.Utils.GxStringCollection StateAttributes( )
      {
         GeneXus.Utils.GxStringCollection state = new GeneXus.Utils.GxStringCollection() ;
         state.Add("gxTpr_Mode");
         state.Add("gxTpr_Initialized");
         state.Add("gxTpr_Br_pathology_otherid_Z");
         state.Add("gxTpr_Br_pathologyid_Z");
         state.Add("gxTpr_Br_pathology_other_bio_Z");
         state.Add("gxTpr_Br_pathology_other_bio_code_Z");
         state.Add("gxTpr_Br_pathology_other_bionum_Z_double");
         state.Add("gxTpr_Br_pathology_other_bionum_code_Z");
         state.Add("gxTpr_Br_pathology_other_bionumunit_Z");
         state.Add("gxTpr_Br_pathology_other_bioqual_Z");
         state.Add("gxTpr_Br_pathology_other_bioqual_code_Z");
         state.Add("gxTpr_Br_pathology_other_low_Z_double");
         state.Add("gxTpr_Br_pathology_other_high_Z_double");
         state.Add("gxTpr_Br_pathology_other_abnind_Z");
         state.Add("gxTpr_Br_pathology_other_abnind_code_Z");
         state.Add("gxTpr_Br_pathologyid_N");
         state.Add("gxTpr_Br_pathology_other_bio_N");
         state.Add("gxTpr_Br_pathology_other_bio_code_N");
         state.Add("gxTpr_Br_pathology_other_bionum_N");
         state.Add("gxTpr_Br_pathology_other_bionum_code_N");
         state.Add("gxTpr_Br_pathology_other_bionumunit_N");
         state.Add("gxTpr_Br_pathology_other_bioqual_N");
         state.Add("gxTpr_Br_pathology_other_bioqual_code_N");
         state.Add("gxTpr_Br_pathology_other_low_N");
         state.Add("gxTpr_Br_pathology_other_high_N");
         state.Add("gxTpr_Br_pathology_other_abnind_N");
         state.Add("gxTpr_Br_pathology_other_abnind_code_N");
         return state ;
      }

      public override void Copy( GxUserType source )
      {
         SdtBR_Pathology_Other sdt ;
         sdt = (SdtBR_Pathology_Other)(source);
         gxTv_SdtBR_Pathology_Other_Br_pathology_otherid = sdt.gxTv_SdtBR_Pathology_Other_Br_pathology_otherid ;
         gxTv_SdtBR_Pathology_Other_Br_pathologyid = sdt.gxTv_SdtBR_Pathology_Other_Br_pathologyid ;
         gxTv_SdtBR_Pathology_Other_Br_pathology_other_bio = sdt.gxTv_SdtBR_Pathology_Other_Br_pathology_other_bio ;
         gxTv_SdtBR_Pathology_Other_Br_pathology_other_bio_code = sdt.gxTv_SdtBR_Pathology_Other_Br_pathology_other_bio_code ;
         gxTv_SdtBR_Pathology_Other_Br_pathology_other_bionum = sdt.gxTv_SdtBR_Pathology_Other_Br_pathology_other_bionum ;
         gxTv_SdtBR_Pathology_Other_Br_pathology_other_bionum_code = sdt.gxTv_SdtBR_Pathology_Other_Br_pathology_other_bionum_code ;
         gxTv_SdtBR_Pathology_Other_Br_pathology_other_bionumunit = sdt.gxTv_SdtBR_Pathology_Other_Br_pathology_other_bionumunit ;
         gxTv_SdtBR_Pathology_Other_Br_pathology_other_bioqual = sdt.gxTv_SdtBR_Pathology_Other_Br_pathology_other_bioqual ;
         gxTv_SdtBR_Pathology_Other_Br_pathology_other_bioqual_code = sdt.gxTv_SdtBR_Pathology_Other_Br_pathology_other_bioqual_code ;
         gxTv_SdtBR_Pathology_Other_Br_pathology_other_low = sdt.gxTv_SdtBR_Pathology_Other_Br_pathology_other_low ;
         gxTv_SdtBR_Pathology_Other_Br_pathology_other_high = sdt.gxTv_SdtBR_Pathology_Other_Br_pathology_other_high ;
         gxTv_SdtBR_Pathology_Other_Br_pathology_other_abnind = sdt.gxTv_SdtBR_Pathology_Other_Br_pathology_other_abnind ;
         gxTv_SdtBR_Pathology_Other_Br_pathology_other_abnind_code = sdt.gxTv_SdtBR_Pathology_Other_Br_pathology_other_abnind_code ;
         gxTv_SdtBR_Pathology_Other_Mode = sdt.gxTv_SdtBR_Pathology_Other_Mode ;
         gxTv_SdtBR_Pathology_Other_Initialized = sdt.gxTv_SdtBR_Pathology_Other_Initialized ;
         gxTv_SdtBR_Pathology_Other_Br_pathology_otherid_Z = sdt.gxTv_SdtBR_Pathology_Other_Br_pathology_otherid_Z ;
         gxTv_SdtBR_Pathology_Other_Br_pathologyid_Z = sdt.gxTv_SdtBR_Pathology_Other_Br_pathologyid_Z ;
         gxTv_SdtBR_Pathology_Other_Br_pathology_other_bio_Z = sdt.gxTv_SdtBR_Pathology_Other_Br_pathology_other_bio_Z ;
         gxTv_SdtBR_Pathology_Other_Br_pathology_other_bio_code_Z = sdt.gxTv_SdtBR_Pathology_Other_Br_pathology_other_bio_code_Z ;
         gxTv_SdtBR_Pathology_Other_Br_pathology_other_bionum_Z = sdt.gxTv_SdtBR_Pathology_Other_Br_pathology_other_bionum_Z ;
         gxTv_SdtBR_Pathology_Other_Br_pathology_other_bionum_code_Z = sdt.gxTv_SdtBR_Pathology_Other_Br_pathology_other_bionum_code_Z ;
         gxTv_SdtBR_Pathology_Other_Br_pathology_other_bionumunit_Z = sdt.gxTv_SdtBR_Pathology_Other_Br_pathology_other_bionumunit_Z ;
         gxTv_SdtBR_Pathology_Other_Br_pathology_other_bioqual_Z = sdt.gxTv_SdtBR_Pathology_Other_Br_pathology_other_bioqual_Z ;
         gxTv_SdtBR_Pathology_Other_Br_pathology_other_bioqual_code_Z = sdt.gxTv_SdtBR_Pathology_Other_Br_pathology_other_bioqual_code_Z ;
         gxTv_SdtBR_Pathology_Other_Br_pathology_other_low_Z = sdt.gxTv_SdtBR_Pathology_Other_Br_pathology_other_low_Z ;
         gxTv_SdtBR_Pathology_Other_Br_pathology_other_high_Z = sdt.gxTv_SdtBR_Pathology_Other_Br_pathology_other_high_Z ;
         gxTv_SdtBR_Pathology_Other_Br_pathology_other_abnind_Z = sdt.gxTv_SdtBR_Pathology_Other_Br_pathology_other_abnind_Z ;
         gxTv_SdtBR_Pathology_Other_Br_pathology_other_abnind_code_Z = sdt.gxTv_SdtBR_Pathology_Other_Br_pathology_other_abnind_code_Z ;
         gxTv_SdtBR_Pathology_Other_Br_pathologyid_N = sdt.gxTv_SdtBR_Pathology_Other_Br_pathologyid_N ;
         gxTv_SdtBR_Pathology_Other_Br_pathology_other_bio_N = sdt.gxTv_SdtBR_Pathology_Other_Br_pathology_other_bio_N ;
         gxTv_SdtBR_Pathology_Other_Br_pathology_other_bio_code_N = sdt.gxTv_SdtBR_Pathology_Other_Br_pathology_other_bio_code_N ;
         gxTv_SdtBR_Pathology_Other_Br_pathology_other_bionum_N = sdt.gxTv_SdtBR_Pathology_Other_Br_pathology_other_bionum_N ;
         gxTv_SdtBR_Pathology_Other_Br_pathology_other_bionum_code_N = sdt.gxTv_SdtBR_Pathology_Other_Br_pathology_other_bionum_code_N ;
         gxTv_SdtBR_Pathology_Other_Br_pathology_other_bionumunit_N = sdt.gxTv_SdtBR_Pathology_Other_Br_pathology_other_bionumunit_N ;
         gxTv_SdtBR_Pathology_Other_Br_pathology_other_bioqual_N = sdt.gxTv_SdtBR_Pathology_Other_Br_pathology_other_bioqual_N ;
         gxTv_SdtBR_Pathology_Other_Br_pathology_other_bioqual_code_N = sdt.gxTv_SdtBR_Pathology_Other_Br_pathology_other_bioqual_code_N ;
         gxTv_SdtBR_Pathology_Other_Br_pathology_other_low_N = sdt.gxTv_SdtBR_Pathology_Other_Br_pathology_other_low_N ;
         gxTv_SdtBR_Pathology_Other_Br_pathology_other_high_N = sdt.gxTv_SdtBR_Pathology_Other_Br_pathology_other_high_N ;
         gxTv_SdtBR_Pathology_Other_Br_pathology_other_abnind_N = sdt.gxTv_SdtBR_Pathology_Other_Br_pathology_other_abnind_N ;
         gxTv_SdtBR_Pathology_Other_Br_pathology_other_abnind_code_N = sdt.gxTv_SdtBR_Pathology_Other_Br_pathology_other_abnind_code_N ;
         return  ;
      }

      public override void ToJSON( )
      {
         ToJSON( true) ;
         return  ;
      }

      public override void ToJSON( bool includeState )
      {
         AddObjectProperty("BR_Pathology_OtherID", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_Pathology_Other_Br_pathology_otherid), 18, 0)), false);
         AddObjectProperty("BR_PathologyID", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_Pathology_Other_Br_pathologyid), 18, 0)), false);
         AddObjectProperty("BR_PathologyID_N", gxTv_SdtBR_Pathology_Other_Br_pathologyid_N, false);
         AddObjectProperty("BR_Pathology_Other_Bio", gxTv_SdtBR_Pathology_Other_Br_pathology_other_bio, false);
         AddObjectProperty("BR_Pathology_Other_Bio_N", gxTv_SdtBR_Pathology_Other_Br_pathology_other_bio_N, false);
         AddObjectProperty("BR_Pathology_Other_Bio_Code", gxTv_SdtBR_Pathology_Other_Br_pathology_other_bio_code, false);
         AddObjectProperty("BR_Pathology_Other_Bio_Code_N", gxTv_SdtBR_Pathology_Other_Br_pathology_other_bio_code_N, false);
         AddObjectProperty("BR_Pathology_Other_BioNum", gxTv_SdtBR_Pathology_Other_Br_pathology_other_bionum, false);
         AddObjectProperty("BR_Pathology_Other_BioNum_N", gxTv_SdtBR_Pathology_Other_Br_pathology_other_bionum_N, false);
         AddObjectProperty("BR_Pathology_Other_BioNum_Code", gxTv_SdtBR_Pathology_Other_Br_pathology_other_bionum_code, false);
         AddObjectProperty("BR_Pathology_Other_BioNum_Code_N", gxTv_SdtBR_Pathology_Other_Br_pathology_other_bionum_code_N, false);
         AddObjectProperty("BR_Pathology_Other_BioNumUnit", gxTv_SdtBR_Pathology_Other_Br_pathology_other_bionumunit, false);
         AddObjectProperty("BR_Pathology_Other_BioNumUnit_N", gxTv_SdtBR_Pathology_Other_Br_pathology_other_bionumunit_N, false);
         AddObjectProperty("BR_Pathology_Other_BioQual", gxTv_SdtBR_Pathology_Other_Br_pathology_other_bioqual, false);
         AddObjectProperty("BR_Pathology_Other_BioQual_N", gxTv_SdtBR_Pathology_Other_Br_pathology_other_bioqual_N, false);
         AddObjectProperty("BR_Pathology_Other_BioQual_Code", gxTv_SdtBR_Pathology_Other_Br_pathology_other_bioqual_code, false);
         AddObjectProperty("BR_Pathology_Other_BioQual_Code_N", gxTv_SdtBR_Pathology_Other_Br_pathology_other_bioqual_code_N, false);
         AddObjectProperty("BR_Pathology_Other_Low", gxTv_SdtBR_Pathology_Other_Br_pathology_other_low, false);
         AddObjectProperty("BR_Pathology_Other_Low_N", gxTv_SdtBR_Pathology_Other_Br_pathology_other_low_N, false);
         AddObjectProperty("BR_Pathology_Other_High", gxTv_SdtBR_Pathology_Other_Br_pathology_other_high, false);
         AddObjectProperty("BR_Pathology_Other_High_N", gxTv_SdtBR_Pathology_Other_Br_pathology_other_high_N, false);
         AddObjectProperty("BR_Pathology_Other_AbnInd", gxTv_SdtBR_Pathology_Other_Br_pathology_other_abnind, false);
         AddObjectProperty("BR_Pathology_Other_AbnInd_N", gxTv_SdtBR_Pathology_Other_Br_pathology_other_abnind_N, false);
         AddObjectProperty("BR_Pathology_Other_AbnInd_Code", gxTv_SdtBR_Pathology_Other_Br_pathology_other_abnind_code, false);
         AddObjectProperty("BR_Pathology_Other_AbnInd_Code_N", gxTv_SdtBR_Pathology_Other_Br_pathology_other_abnind_code_N, false);
         if ( includeState )
         {
            AddObjectProperty("Mode", gxTv_SdtBR_Pathology_Other_Mode, false);
            AddObjectProperty("Initialized", gxTv_SdtBR_Pathology_Other_Initialized, false);
            AddObjectProperty("BR_Pathology_OtherID_Z", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_Pathology_Other_Br_pathology_otherid_Z), 18, 0)), false);
            AddObjectProperty("BR_PathologyID_Z", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_Pathology_Other_Br_pathologyid_Z), 18, 0)), false);
            AddObjectProperty("BR_Pathology_Other_Bio_Z", gxTv_SdtBR_Pathology_Other_Br_pathology_other_bio_Z, false);
            AddObjectProperty("BR_Pathology_Other_Bio_Code_Z", gxTv_SdtBR_Pathology_Other_Br_pathology_other_bio_code_Z, false);
            AddObjectProperty("BR_Pathology_Other_BioNum_Z", gxTv_SdtBR_Pathology_Other_Br_pathology_other_bionum_Z, false);
            AddObjectProperty("BR_Pathology_Other_BioNum_Code_Z", gxTv_SdtBR_Pathology_Other_Br_pathology_other_bionum_code_Z, false);
            AddObjectProperty("BR_Pathology_Other_BioNumUnit_Z", gxTv_SdtBR_Pathology_Other_Br_pathology_other_bionumunit_Z, false);
            AddObjectProperty("BR_Pathology_Other_BioQual_Z", gxTv_SdtBR_Pathology_Other_Br_pathology_other_bioqual_Z, false);
            AddObjectProperty("BR_Pathology_Other_BioQual_Code_Z", gxTv_SdtBR_Pathology_Other_Br_pathology_other_bioqual_code_Z, false);
            AddObjectProperty("BR_Pathology_Other_Low_Z", gxTv_SdtBR_Pathology_Other_Br_pathology_other_low_Z, false);
            AddObjectProperty("BR_Pathology_Other_High_Z", gxTv_SdtBR_Pathology_Other_Br_pathology_other_high_Z, false);
            AddObjectProperty("BR_Pathology_Other_AbnInd_Z", gxTv_SdtBR_Pathology_Other_Br_pathology_other_abnind_Z, false);
            AddObjectProperty("BR_Pathology_Other_AbnInd_Code_Z", gxTv_SdtBR_Pathology_Other_Br_pathology_other_abnind_code_Z, false);
            AddObjectProperty("BR_PathologyID_N", gxTv_SdtBR_Pathology_Other_Br_pathologyid_N, false);
            AddObjectProperty("BR_Pathology_Other_Bio_N", gxTv_SdtBR_Pathology_Other_Br_pathology_other_bio_N, false);
            AddObjectProperty("BR_Pathology_Other_Bio_Code_N", gxTv_SdtBR_Pathology_Other_Br_pathology_other_bio_code_N, false);
            AddObjectProperty("BR_Pathology_Other_BioNum_N", gxTv_SdtBR_Pathology_Other_Br_pathology_other_bionum_N, false);
            AddObjectProperty("BR_Pathology_Other_BioNum_Code_N", gxTv_SdtBR_Pathology_Other_Br_pathology_other_bionum_code_N, false);
            AddObjectProperty("BR_Pathology_Other_BioNumUnit_N", gxTv_SdtBR_Pathology_Other_Br_pathology_other_bionumunit_N, false);
            AddObjectProperty("BR_Pathology_Other_BioQual_N", gxTv_SdtBR_Pathology_Other_Br_pathology_other_bioqual_N, false);
            AddObjectProperty("BR_Pathology_Other_BioQual_Code_N", gxTv_SdtBR_Pathology_Other_Br_pathology_other_bioqual_code_N, false);
            AddObjectProperty("BR_Pathology_Other_Low_N", gxTv_SdtBR_Pathology_Other_Br_pathology_other_low_N, false);
            AddObjectProperty("BR_Pathology_Other_High_N", gxTv_SdtBR_Pathology_Other_Br_pathology_other_high_N, false);
            AddObjectProperty("BR_Pathology_Other_AbnInd_N", gxTv_SdtBR_Pathology_Other_Br_pathology_other_abnind_N, false);
            AddObjectProperty("BR_Pathology_Other_AbnInd_Code_N", gxTv_SdtBR_Pathology_Other_Br_pathology_other_abnind_code_N, false);
         }
         return  ;
      }

      public void UpdateDirties( SdtBR_Pathology_Other sdt )
      {
         if ( sdt.IsDirty("BR_Pathology_OtherID") )
         {
            gxTv_SdtBR_Pathology_Other_Br_pathology_otherid = sdt.gxTv_SdtBR_Pathology_Other_Br_pathology_otherid ;
         }
         if ( sdt.IsDirty("BR_PathologyID") )
         {
            gxTv_SdtBR_Pathology_Other_Br_pathologyid = sdt.gxTv_SdtBR_Pathology_Other_Br_pathologyid ;
         }
         if ( sdt.IsDirty("BR_Pathology_Other_Bio") )
         {
            gxTv_SdtBR_Pathology_Other_Br_pathology_other_bio = sdt.gxTv_SdtBR_Pathology_Other_Br_pathology_other_bio ;
         }
         if ( sdt.IsDirty("BR_Pathology_Other_Bio_Code") )
         {
            gxTv_SdtBR_Pathology_Other_Br_pathology_other_bio_code = sdt.gxTv_SdtBR_Pathology_Other_Br_pathology_other_bio_code ;
         }
         if ( sdt.IsDirty("BR_Pathology_Other_BioNum") )
         {
            gxTv_SdtBR_Pathology_Other_Br_pathology_other_bionum = sdt.gxTv_SdtBR_Pathology_Other_Br_pathology_other_bionum ;
         }
         if ( sdt.IsDirty("BR_Pathology_Other_BioNum_Code") )
         {
            gxTv_SdtBR_Pathology_Other_Br_pathology_other_bionum_code = sdt.gxTv_SdtBR_Pathology_Other_Br_pathology_other_bionum_code ;
         }
         if ( sdt.IsDirty("BR_Pathology_Other_BioNumUnit") )
         {
            gxTv_SdtBR_Pathology_Other_Br_pathology_other_bionumunit = sdt.gxTv_SdtBR_Pathology_Other_Br_pathology_other_bionumunit ;
         }
         if ( sdt.IsDirty("BR_Pathology_Other_BioQual") )
         {
            gxTv_SdtBR_Pathology_Other_Br_pathology_other_bioqual = sdt.gxTv_SdtBR_Pathology_Other_Br_pathology_other_bioqual ;
         }
         if ( sdt.IsDirty("BR_Pathology_Other_BioQual_Code") )
         {
            gxTv_SdtBR_Pathology_Other_Br_pathology_other_bioqual_code = sdt.gxTv_SdtBR_Pathology_Other_Br_pathology_other_bioqual_code ;
         }
         if ( sdt.IsDirty("BR_Pathology_Other_Low") )
         {
            gxTv_SdtBR_Pathology_Other_Br_pathology_other_low = sdt.gxTv_SdtBR_Pathology_Other_Br_pathology_other_low ;
         }
         if ( sdt.IsDirty("BR_Pathology_Other_High") )
         {
            gxTv_SdtBR_Pathology_Other_Br_pathology_other_high = sdt.gxTv_SdtBR_Pathology_Other_Br_pathology_other_high ;
         }
         if ( sdt.IsDirty("BR_Pathology_Other_AbnInd") )
         {
            gxTv_SdtBR_Pathology_Other_Br_pathology_other_abnind = sdt.gxTv_SdtBR_Pathology_Other_Br_pathology_other_abnind ;
         }
         if ( sdt.IsDirty("BR_Pathology_Other_AbnInd_Code") )
         {
            gxTv_SdtBR_Pathology_Other_Br_pathology_other_abnind_code = sdt.gxTv_SdtBR_Pathology_Other_Br_pathology_other_abnind_code ;
         }
         return  ;
      }

      [  SoapElement( ElementName = "BR_Pathology_OtherID" )]
      [  XmlElement( ElementName = "BR_Pathology_OtherID"   )]
      public long gxTpr_Br_pathology_otherid
      {
         get {
            return gxTv_SdtBR_Pathology_Other_Br_pathology_otherid ;
         }

         set {
            if ( gxTv_SdtBR_Pathology_Other_Br_pathology_otherid != value )
            {
               gxTv_SdtBR_Pathology_Other_Mode = "INS";
               this.gxTv_SdtBR_Pathology_Other_Br_pathology_otherid_Z_SetNull( );
               this.gxTv_SdtBR_Pathology_Other_Br_pathologyid_Z_SetNull( );
               this.gxTv_SdtBR_Pathology_Other_Br_pathology_other_bio_Z_SetNull( );
               this.gxTv_SdtBR_Pathology_Other_Br_pathology_other_bio_code_Z_SetNull( );
               this.gxTv_SdtBR_Pathology_Other_Br_pathology_other_bionum_Z_SetNull( );
               this.gxTv_SdtBR_Pathology_Other_Br_pathology_other_bionum_code_Z_SetNull( );
               this.gxTv_SdtBR_Pathology_Other_Br_pathology_other_bionumunit_Z_SetNull( );
               this.gxTv_SdtBR_Pathology_Other_Br_pathology_other_bioqual_Z_SetNull( );
               this.gxTv_SdtBR_Pathology_Other_Br_pathology_other_bioqual_code_Z_SetNull( );
               this.gxTv_SdtBR_Pathology_Other_Br_pathology_other_low_Z_SetNull( );
               this.gxTv_SdtBR_Pathology_Other_Br_pathology_other_high_Z_SetNull( );
               this.gxTv_SdtBR_Pathology_Other_Br_pathology_other_abnind_Z_SetNull( );
               this.gxTv_SdtBR_Pathology_Other_Br_pathology_other_abnind_code_Z_SetNull( );
            }
            gxTv_SdtBR_Pathology_Other_Br_pathology_otherid = value;
            SetDirty("Br_pathology_otherid");
         }

      }

      [  SoapElement( ElementName = "BR_PathologyID" )]
      [  XmlElement( ElementName = "BR_PathologyID"   )]
      public long gxTpr_Br_pathologyid
      {
         get {
            return gxTv_SdtBR_Pathology_Other_Br_pathologyid ;
         }

         set {
            gxTv_SdtBR_Pathology_Other_Br_pathologyid_N = 0;
            gxTv_SdtBR_Pathology_Other_Br_pathologyid = value;
            SetDirty("Br_pathologyid");
         }

      }

      public void gxTv_SdtBR_Pathology_Other_Br_pathologyid_SetNull( )
      {
         gxTv_SdtBR_Pathology_Other_Br_pathologyid_N = 1;
         gxTv_SdtBR_Pathology_Other_Br_pathologyid = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Other_Br_pathologyid_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Pathology_Other_Bio" )]
      [  XmlElement( ElementName = "BR_Pathology_Other_Bio"   )]
      public String gxTpr_Br_pathology_other_bio
      {
         get {
            return gxTv_SdtBR_Pathology_Other_Br_pathology_other_bio ;
         }

         set {
            gxTv_SdtBR_Pathology_Other_Br_pathology_other_bio_N = 0;
            gxTv_SdtBR_Pathology_Other_Br_pathology_other_bio = value;
            SetDirty("Br_pathology_other_bio");
         }

      }

      public void gxTv_SdtBR_Pathology_Other_Br_pathology_other_bio_SetNull( )
      {
         gxTv_SdtBR_Pathology_Other_Br_pathology_other_bio_N = 1;
         gxTv_SdtBR_Pathology_Other_Br_pathology_other_bio = "";
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Other_Br_pathology_other_bio_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Pathology_Other_Bio_Code" )]
      [  XmlElement( ElementName = "BR_Pathology_Other_Bio_Code"   )]
      public String gxTpr_Br_pathology_other_bio_code
      {
         get {
            return gxTv_SdtBR_Pathology_Other_Br_pathology_other_bio_code ;
         }

         set {
            gxTv_SdtBR_Pathology_Other_Br_pathology_other_bio_code_N = 0;
            gxTv_SdtBR_Pathology_Other_Br_pathology_other_bio_code = value;
            SetDirty("Br_pathology_other_bio_code");
         }

      }

      public void gxTv_SdtBR_Pathology_Other_Br_pathology_other_bio_code_SetNull( )
      {
         gxTv_SdtBR_Pathology_Other_Br_pathology_other_bio_code_N = 1;
         gxTv_SdtBR_Pathology_Other_Br_pathology_other_bio_code = "";
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Other_Br_pathology_other_bio_code_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Pathology_Other_BioNum" )]
      [  XmlElement( ElementName = "BR_Pathology_Other_BioNum"   )]
      public double gxTpr_Br_pathology_other_bionum_double
      {
         get {
            return Convert.ToDouble(gxTv_SdtBR_Pathology_Other_Br_pathology_other_bionum) ;
         }

         set {
            gxTv_SdtBR_Pathology_Other_Br_pathology_other_bionum_N = 0;
            gxTv_SdtBR_Pathology_Other_Br_pathology_other_bionum = (decimal)(Convert.ToDecimal( value));
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public decimal gxTpr_Br_pathology_other_bionum
      {
         get {
            return gxTv_SdtBR_Pathology_Other_Br_pathology_other_bionum ;
         }

         set {
            gxTv_SdtBR_Pathology_Other_Br_pathology_other_bionum_N = 0;
            gxTv_SdtBR_Pathology_Other_Br_pathology_other_bionum = value;
            SetDirty("Br_pathology_other_bionum");
         }

      }

      public void gxTv_SdtBR_Pathology_Other_Br_pathology_other_bionum_SetNull( )
      {
         gxTv_SdtBR_Pathology_Other_Br_pathology_other_bionum_N = 1;
         gxTv_SdtBR_Pathology_Other_Br_pathology_other_bionum = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Other_Br_pathology_other_bionum_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Pathology_Other_BioNum_Code" )]
      [  XmlElement( ElementName = "BR_Pathology_Other_BioNum_Code"   )]
      public String gxTpr_Br_pathology_other_bionum_code
      {
         get {
            return gxTv_SdtBR_Pathology_Other_Br_pathology_other_bionum_code ;
         }

         set {
            gxTv_SdtBR_Pathology_Other_Br_pathology_other_bionum_code_N = 0;
            gxTv_SdtBR_Pathology_Other_Br_pathology_other_bionum_code = value;
            SetDirty("Br_pathology_other_bionum_code");
         }

      }

      public void gxTv_SdtBR_Pathology_Other_Br_pathology_other_bionum_code_SetNull( )
      {
         gxTv_SdtBR_Pathology_Other_Br_pathology_other_bionum_code_N = 1;
         gxTv_SdtBR_Pathology_Other_Br_pathology_other_bionum_code = "";
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Other_Br_pathology_other_bionum_code_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Pathology_Other_BioNumUnit" )]
      [  XmlElement( ElementName = "BR_Pathology_Other_BioNumUnit"   )]
      public String gxTpr_Br_pathology_other_bionumunit
      {
         get {
            return gxTv_SdtBR_Pathology_Other_Br_pathology_other_bionumunit ;
         }

         set {
            gxTv_SdtBR_Pathology_Other_Br_pathology_other_bionumunit_N = 0;
            gxTv_SdtBR_Pathology_Other_Br_pathology_other_bionumunit = value;
            SetDirty("Br_pathology_other_bionumunit");
         }

      }

      public void gxTv_SdtBR_Pathology_Other_Br_pathology_other_bionumunit_SetNull( )
      {
         gxTv_SdtBR_Pathology_Other_Br_pathology_other_bionumunit_N = 1;
         gxTv_SdtBR_Pathology_Other_Br_pathology_other_bionumunit = "";
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Other_Br_pathology_other_bionumunit_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Pathology_Other_BioQual" )]
      [  XmlElement( ElementName = "BR_Pathology_Other_BioQual"   )]
      public String gxTpr_Br_pathology_other_bioqual
      {
         get {
            return gxTv_SdtBR_Pathology_Other_Br_pathology_other_bioqual ;
         }

         set {
            gxTv_SdtBR_Pathology_Other_Br_pathology_other_bioqual_N = 0;
            gxTv_SdtBR_Pathology_Other_Br_pathology_other_bioqual = value;
            SetDirty("Br_pathology_other_bioqual");
         }

      }

      public void gxTv_SdtBR_Pathology_Other_Br_pathology_other_bioqual_SetNull( )
      {
         gxTv_SdtBR_Pathology_Other_Br_pathology_other_bioqual_N = 1;
         gxTv_SdtBR_Pathology_Other_Br_pathology_other_bioqual = "";
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Other_Br_pathology_other_bioqual_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Pathology_Other_BioQual_Code" )]
      [  XmlElement( ElementName = "BR_Pathology_Other_BioQual_Code"   )]
      public String gxTpr_Br_pathology_other_bioqual_code
      {
         get {
            return gxTv_SdtBR_Pathology_Other_Br_pathology_other_bioqual_code ;
         }

         set {
            gxTv_SdtBR_Pathology_Other_Br_pathology_other_bioqual_code_N = 0;
            gxTv_SdtBR_Pathology_Other_Br_pathology_other_bioqual_code = value;
            SetDirty("Br_pathology_other_bioqual_code");
         }

      }

      public void gxTv_SdtBR_Pathology_Other_Br_pathology_other_bioqual_code_SetNull( )
      {
         gxTv_SdtBR_Pathology_Other_Br_pathology_other_bioqual_code_N = 1;
         gxTv_SdtBR_Pathology_Other_Br_pathology_other_bioqual_code = "";
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Other_Br_pathology_other_bioqual_code_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Pathology_Other_Low" )]
      [  XmlElement( ElementName = "BR_Pathology_Other_Low"   )]
      public double gxTpr_Br_pathology_other_low_double
      {
         get {
            return Convert.ToDouble(gxTv_SdtBR_Pathology_Other_Br_pathology_other_low) ;
         }

         set {
            gxTv_SdtBR_Pathology_Other_Br_pathology_other_low_N = 0;
            gxTv_SdtBR_Pathology_Other_Br_pathology_other_low = (decimal)(Convert.ToDecimal( value));
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public decimal gxTpr_Br_pathology_other_low
      {
         get {
            return gxTv_SdtBR_Pathology_Other_Br_pathology_other_low ;
         }

         set {
            gxTv_SdtBR_Pathology_Other_Br_pathology_other_low_N = 0;
            gxTv_SdtBR_Pathology_Other_Br_pathology_other_low = value;
            SetDirty("Br_pathology_other_low");
         }

      }

      public void gxTv_SdtBR_Pathology_Other_Br_pathology_other_low_SetNull( )
      {
         gxTv_SdtBR_Pathology_Other_Br_pathology_other_low_N = 1;
         gxTv_SdtBR_Pathology_Other_Br_pathology_other_low = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Other_Br_pathology_other_low_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Pathology_Other_High" )]
      [  XmlElement( ElementName = "BR_Pathology_Other_High"   )]
      public double gxTpr_Br_pathology_other_high_double
      {
         get {
            return Convert.ToDouble(gxTv_SdtBR_Pathology_Other_Br_pathology_other_high) ;
         }

         set {
            gxTv_SdtBR_Pathology_Other_Br_pathology_other_high_N = 0;
            gxTv_SdtBR_Pathology_Other_Br_pathology_other_high = (decimal)(Convert.ToDecimal( value));
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public decimal gxTpr_Br_pathology_other_high
      {
         get {
            return gxTv_SdtBR_Pathology_Other_Br_pathology_other_high ;
         }

         set {
            gxTv_SdtBR_Pathology_Other_Br_pathology_other_high_N = 0;
            gxTv_SdtBR_Pathology_Other_Br_pathology_other_high = value;
            SetDirty("Br_pathology_other_high");
         }

      }

      public void gxTv_SdtBR_Pathology_Other_Br_pathology_other_high_SetNull( )
      {
         gxTv_SdtBR_Pathology_Other_Br_pathology_other_high_N = 1;
         gxTv_SdtBR_Pathology_Other_Br_pathology_other_high = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Other_Br_pathology_other_high_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Pathology_Other_AbnInd" )]
      [  XmlElement( ElementName = "BR_Pathology_Other_AbnInd"   )]
      public String gxTpr_Br_pathology_other_abnind
      {
         get {
            return gxTv_SdtBR_Pathology_Other_Br_pathology_other_abnind ;
         }

         set {
            gxTv_SdtBR_Pathology_Other_Br_pathology_other_abnind_N = 0;
            gxTv_SdtBR_Pathology_Other_Br_pathology_other_abnind = value;
            SetDirty("Br_pathology_other_abnind");
         }

      }

      public void gxTv_SdtBR_Pathology_Other_Br_pathology_other_abnind_SetNull( )
      {
         gxTv_SdtBR_Pathology_Other_Br_pathology_other_abnind_N = 1;
         gxTv_SdtBR_Pathology_Other_Br_pathology_other_abnind = "";
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Other_Br_pathology_other_abnind_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Pathology_Other_AbnInd_Code" )]
      [  XmlElement( ElementName = "BR_Pathology_Other_AbnInd_Code"   )]
      public String gxTpr_Br_pathology_other_abnind_code
      {
         get {
            return gxTv_SdtBR_Pathology_Other_Br_pathology_other_abnind_code ;
         }

         set {
            gxTv_SdtBR_Pathology_Other_Br_pathology_other_abnind_code_N = 0;
            gxTv_SdtBR_Pathology_Other_Br_pathology_other_abnind_code = value;
            SetDirty("Br_pathology_other_abnind_code");
         }

      }

      public void gxTv_SdtBR_Pathology_Other_Br_pathology_other_abnind_code_SetNull( )
      {
         gxTv_SdtBR_Pathology_Other_Br_pathology_other_abnind_code_N = 1;
         gxTv_SdtBR_Pathology_Other_Br_pathology_other_abnind_code = "";
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Other_Br_pathology_other_abnind_code_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Mode" )]
      [  XmlElement( ElementName = "Mode"   )]
      public String gxTpr_Mode
      {
         get {
            return gxTv_SdtBR_Pathology_Other_Mode ;
         }

         set {
            gxTv_SdtBR_Pathology_Other_Mode = value;
            SetDirty("Mode");
         }

      }

      public void gxTv_SdtBR_Pathology_Other_Mode_SetNull( )
      {
         gxTv_SdtBR_Pathology_Other_Mode = "";
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Other_Mode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Initialized" )]
      [  XmlElement( ElementName = "Initialized"   )]
      public short gxTpr_Initialized
      {
         get {
            return gxTv_SdtBR_Pathology_Other_Initialized ;
         }

         set {
            gxTv_SdtBR_Pathology_Other_Initialized = value;
            SetDirty("Initialized");
         }

      }

      public void gxTv_SdtBR_Pathology_Other_Initialized_SetNull( )
      {
         gxTv_SdtBR_Pathology_Other_Initialized = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Other_Initialized_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Pathology_OtherID_Z" )]
      [  XmlElement( ElementName = "BR_Pathology_OtherID_Z"   )]
      public long gxTpr_Br_pathology_otherid_Z
      {
         get {
            return gxTv_SdtBR_Pathology_Other_Br_pathology_otherid_Z ;
         }

         set {
            gxTv_SdtBR_Pathology_Other_Br_pathology_otherid_Z = value;
            SetDirty("Br_pathology_otherid_Z");
         }

      }

      public void gxTv_SdtBR_Pathology_Other_Br_pathology_otherid_Z_SetNull( )
      {
         gxTv_SdtBR_Pathology_Other_Br_pathology_otherid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Other_Br_pathology_otherid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_PathologyID_Z" )]
      [  XmlElement( ElementName = "BR_PathologyID_Z"   )]
      public long gxTpr_Br_pathologyid_Z
      {
         get {
            return gxTv_SdtBR_Pathology_Other_Br_pathologyid_Z ;
         }

         set {
            gxTv_SdtBR_Pathology_Other_Br_pathologyid_Z = value;
            SetDirty("Br_pathologyid_Z");
         }

      }

      public void gxTv_SdtBR_Pathology_Other_Br_pathologyid_Z_SetNull( )
      {
         gxTv_SdtBR_Pathology_Other_Br_pathologyid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Other_Br_pathologyid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Pathology_Other_Bio_Z" )]
      [  XmlElement( ElementName = "BR_Pathology_Other_Bio_Z"   )]
      public String gxTpr_Br_pathology_other_bio_Z
      {
         get {
            return gxTv_SdtBR_Pathology_Other_Br_pathology_other_bio_Z ;
         }

         set {
            gxTv_SdtBR_Pathology_Other_Br_pathology_other_bio_Z = value;
            SetDirty("Br_pathology_other_bio_Z");
         }

      }

      public void gxTv_SdtBR_Pathology_Other_Br_pathology_other_bio_Z_SetNull( )
      {
         gxTv_SdtBR_Pathology_Other_Br_pathology_other_bio_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Other_Br_pathology_other_bio_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Pathology_Other_Bio_Code_Z" )]
      [  XmlElement( ElementName = "BR_Pathology_Other_Bio_Code_Z"   )]
      public String gxTpr_Br_pathology_other_bio_code_Z
      {
         get {
            return gxTv_SdtBR_Pathology_Other_Br_pathology_other_bio_code_Z ;
         }

         set {
            gxTv_SdtBR_Pathology_Other_Br_pathology_other_bio_code_Z = value;
            SetDirty("Br_pathology_other_bio_code_Z");
         }

      }

      public void gxTv_SdtBR_Pathology_Other_Br_pathology_other_bio_code_Z_SetNull( )
      {
         gxTv_SdtBR_Pathology_Other_Br_pathology_other_bio_code_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Other_Br_pathology_other_bio_code_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Pathology_Other_BioNum_Z" )]
      [  XmlElement( ElementName = "BR_Pathology_Other_BioNum_Z"   )]
      public double gxTpr_Br_pathology_other_bionum_Z_double
      {
         get {
            return Convert.ToDouble(gxTv_SdtBR_Pathology_Other_Br_pathology_other_bionum_Z) ;
         }

         set {
            gxTv_SdtBR_Pathology_Other_Br_pathology_other_bionum_Z = (decimal)(Convert.ToDecimal( value));
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public decimal gxTpr_Br_pathology_other_bionum_Z
      {
         get {
            return gxTv_SdtBR_Pathology_Other_Br_pathology_other_bionum_Z ;
         }

         set {
            gxTv_SdtBR_Pathology_Other_Br_pathology_other_bionum_Z = value;
            SetDirty("Br_pathology_other_bionum_Z");
         }

      }

      public void gxTv_SdtBR_Pathology_Other_Br_pathology_other_bionum_Z_SetNull( )
      {
         gxTv_SdtBR_Pathology_Other_Br_pathology_other_bionum_Z = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Other_Br_pathology_other_bionum_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Pathology_Other_BioNum_Code_Z" )]
      [  XmlElement( ElementName = "BR_Pathology_Other_BioNum_Code_Z"   )]
      public String gxTpr_Br_pathology_other_bionum_code_Z
      {
         get {
            return gxTv_SdtBR_Pathology_Other_Br_pathology_other_bionum_code_Z ;
         }

         set {
            gxTv_SdtBR_Pathology_Other_Br_pathology_other_bionum_code_Z = value;
            SetDirty("Br_pathology_other_bionum_code_Z");
         }

      }

      public void gxTv_SdtBR_Pathology_Other_Br_pathology_other_bionum_code_Z_SetNull( )
      {
         gxTv_SdtBR_Pathology_Other_Br_pathology_other_bionum_code_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Other_Br_pathology_other_bionum_code_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Pathology_Other_BioNumUnit_Z" )]
      [  XmlElement( ElementName = "BR_Pathology_Other_BioNumUnit_Z"   )]
      public String gxTpr_Br_pathology_other_bionumunit_Z
      {
         get {
            return gxTv_SdtBR_Pathology_Other_Br_pathology_other_bionumunit_Z ;
         }

         set {
            gxTv_SdtBR_Pathology_Other_Br_pathology_other_bionumunit_Z = value;
            SetDirty("Br_pathology_other_bionumunit_Z");
         }

      }

      public void gxTv_SdtBR_Pathology_Other_Br_pathology_other_bionumunit_Z_SetNull( )
      {
         gxTv_SdtBR_Pathology_Other_Br_pathology_other_bionumunit_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Other_Br_pathology_other_bionumunit_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Pathology_Other_BioQual_Z" )]
      [  XmlElement( ElementName = "BR_Pathology_Other_BioQual_Z"   )]
      public String gxTpr_Br_pathology_other_bioqual_Z
      {
         get {
            return gxTv_SdtBR_Pathology_Other_Br_pathology_other_bioqual_Z ;
         }

         set {
            gxTv_SdtBR_Pathology_Other_Br_pathology_other_bioqual_Z = value;
            SetDirty("Br_pathology_other_bioqual_Z");
         }

      }

      public void gxTv_SdtBR_Pathology_Other_Br_pathology_other_bioqual_Z_SetNull( )
      {
         gxTv_SdtBR_Pathology_Other_Br_pathology_other_bioqual_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Other_Br_pathology_other_bioqual_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Pathology_Other_BioQual_Code_Z" )]
      [  XmlElement( ElementName = "BR_Pathology_Other_BioQual_Code_Z"   )]
      public String gxTpr_Br_pathology_other_bioqual_code_Z
      {
         get {
            return gxTv_SdtBR_Pathology_Other_Br_pathology_other_bioqual_code_Z ;
         }

         set {
            gxTv_SdtBR_Pathology_Other_Br_pathology_other_bioqual_code_Z = value;
            SetDirty("Br_pathology_other_bioqual_code_Z");
         }

      }

      public void gxTv_SdtBR_Pathology_Other_Br_pathology_other_bioqual_code_Z_SetNull( )
      {
         gxTv_SdtBR_Pathology_Other_Br_pathology_other_bioqual_code_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Other_Br_pathology_other_bioqual_code_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Pathology_Other_Low_Z" )]
      [  XmlElement( ElementName = "BR_Pathology_Other_Low_Z"   )]
      public double gxTpr_Br_pathology_other_low_Z_double
      {
         get {
            return Convert.ToDouble(gxTv_SdtBR_Pathology_Other_Br_pathology_other_low_Z) ;
         }

         set {
            gxTv_SdtBR_Pathology_Other_Br_pathology_other_low_Z = (decimal)(Convert.ToDecimal( value));
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public decimal gxTpr_Br_pathology_other_low_Z
      {
         get {
            return gxTv_SdtBR_Pathology_Other_Br_pathology_other_low_Z ;
         }

         set {
            gxTv_SdtBR_Pathology_Other_Br_pathology_other_low_Z = value;
            SetDirty("Br_pathology_other_low_Z");
         }

      }

      public void gxTv_SdtBR_Pathology_Other_Br_pathology_other_low_Z_SetNull( )
      {
         gxTv_SdtBR_Pathology_Other_Br_pathology_other_low_Z = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Other_Br_pathology_other_low_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Pathology_Other_High_Z" )]
      [  XmlElement( ElementName = "BR_Pathology_Other_High_Z"   )]
      public double gxTpr_Br_pathology_other_high_Z_double
      {
         get {
            return Convert.ToDouble(gxTv_SdtBR_Pathology_Other_Br_pathology_other_high_Z) ;
         }

         set {
            gxTv_SdtBR_Pathology_Other_Br_pathology_other_high_Z = (decimal)(Convert.ToDecimal( value));
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public decimal gxTpr_Br_pathology_other_high_Z
      {
         get {
            return gxTv_SdtBR_Pathology_Other_Br_pathology_other_high_Z ;
         }

         set {
            gxTv_SdtBR_Pathology_Other_Br_pathology_other_high_Z = value;
            SetDirty("Br_pathology_other_high_Z");
         }

      }

      public void gxTv_SdtBR_Pathology_Other_Br_pathology_other_high_Z_SetNull( )
      {
         gxTv_SdtBR_Pathology_Other_Br_pathology_other_high_Z = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Other_Br_pathology_other_high_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Pathology_Other_AbnInd_Z" )]
      [  XmlElement( ElementName = "BR_Pathology_Other_AbnInd_Z"   )]
      public String gxTpr_Br_pathology_other_abnind_Z
      {
         get {
            return gxTv_SdtBR_Pathology_Other_Br_pathology_other_abnind_Z ;
         }

         set {
            gxTv_SdtBR_Pathology_Other_Br_pathology_other_abnind_Z = value;
            SetDirty("Br_pathology_other_abnind_Z");
         }

      }

      public void gxTv_SdtBR_Pathology_Other_Br_pathology_other_abnind_Z_SetNull( )
      {
         gxTv_SdtBR_Pathology_Other_Br_pathology_other_abnind_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Other_Br_pathology_other_abnind_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Pathology_Other_AbnInd_Code_Z" )]
      [  XmlElement( ElementName = "BR_Pathology_Other_AbnInd_Code_Z"   )]
      public String gxTpr_Br_pathology_other_abnind_code_Z
      {
         get {
            return gxTv_SdtBR_Pathology_Other_Br_pathology_other_abnind_code_Z ;
         }

         set {
            gxTv_SdtBR_Pathology_Other_Br_pathology_other_abnind_code_Z = value;
            SetDirty("Br_pathology_other_abnind_code_Z");
         }

      }

      public void gxTv_SdtBR_Pathology_Other_Br_pathology_other_abnind_code_Z_SetNull( )
      {
         gxTv_SdtBR_Pathology_Other_Br_pathology_other_abnind_code_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Other_Br_pathology_other_abnind_code_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_PathologyID_N" )]
      [  XmlElement( ElementName = "BR_PathologyID_N"   )]
      public short gxTpr_Br_pathologyid_N
      {
         get {
            return gxTv_SdtBR_Pathology_Other_Br_pathologyid_N ;
         }

         set {
            gxTv_SdtBR_Pathology_Other_Br_pathologyid_N = value;
            SetDirty("Br_pathologyid_N");
         }

      }

      public void gxTv_SdtBR_Pathology_Other_Br_pathologyid_N_SetNull( )
      {
         gxTv_SdtBR_Pathology_Other_Br_pathologyid_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Other_Br_pathologyid_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Pathology_Other_Bio_N" )]
      [  XmlElement( ElementName = "BR_Pathology_Other_Bio_N"   )]
      public short gxTpr_Br_pathology_other_bio_N
      {
         get {
            return gxTv_SdtBR_Pathology_Other_Br_pathology_other_bio_N ;
         }

         set {
            gxTv_SdtBR_Pathology_Other_Br_pathology_other_bio_N = value;
            SetDirty("Br_pathology_other_bio_N");
         }

      }

      public void gxTv_SdtBR_Pathology_Other_Br_pathology_other_bio_N_SetNull( )
      {
         gxTv_SdtBR_Pathology_Other_Br_pathology_other_bio_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Other_Br_pathology_other_bio_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Pathology_Other_Bio_Code_N" )]
      [  XmlElement( ElementName = "BR_Pathology_Other_Bio_Code_N"   )]
      public short gxTpr_Br_pathology_other_bio_code_N
      {
         get {
            return gxTv_SdtBR_Pathology_Other_Br_pathology_other_bio_code_N ;
         }

         set {
            gxTv_SdtBR_Pathology_Other_Br_pathology_other_bio_code_N = value;
            SetDirty("Br_pathology_other_bio_code_N");
         }

      }

      public void gxTv_SdtBR_Pathology_Other_Br_pathology_other_bio_code_N_SetNull( )
      {
         gxTv_SdtBR_Pathology_Other_Br_pathology_other_bio_code_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Other_Br_pathology_other_bio_code_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Pathology_Other_BioNum_N" )]
      [  XmlElement( ElementName = "BR_Pathology_Other_BioNum_N"   )]
      public short gxTpr_Br_pathology_other_bionum_N
      {
         get {
            return gxTv_SdtBR_Pathology_Other_Br_pathology_other_bionum_N ;
         }

         set {
            gxTv_SdtBR_Pathology_Other_Br_pathology_other_bionum_N = value;
            SetDirty("Br_pathology_other_bionum_N");
         }

      }

      public void gxTv_SdtBR_Pathology_Other_Br_pathology_other_bionum_N_SetNull( )
      {
         gxTv_SdtBR_Pathology_Other_Br_pathology_other_bionum_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Other_Br_pathology_other_bionum_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Pathology_Other_BioNum_Code_N" )]
      [  XmlElement( ElementName = "BR_Pathology_Other_BioNum_Code_N"   )]
      public short gxTpr_Br_pathology_other_bionum_code_N
      {
         get {
            return gxTv_SdtBR_Pathology_Other_Br_pathology_other_bionum_code_N ;
         }

         set {
            gxTv_SdtBR_Pathology_Other_Br_pathology_other_bionum_code_N = value;
            SetDirty("Br_pathology_other_bionum_code_N");
         }

      }

      public void gxTv_SdtBR_Pathology_Other_Br_pathology_other_bionum_code_N_SetNull( )
      {
         gxTv_SdtBR_Pathology_Other_Br_pathology_other_bionum_code_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Other_Br_pathology_other_bionum_code_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Pathology_Other_BioNumUnit_N" )]
      [  XmlElement( ElementName = "BR_Pathology_Other_BioNumUnit_N"   )]
      public short gxTpr_Br_pathology_other_bionumunit_N
      {
         get {
            return gxTv_SdtBR_Pathology_Other_Br_pathology_other_bionumunit_N ;
         }

         set {
            gxTv_SdtBR_Pathology_Other_Br_pathology_other_bionumunit_N = value;
            SetDirty("Br_pathology_other_bionumunit_N");
         }

      }

      public void gxTv_SdtBR_Pathology_Other_Br_pathology_other_bionumunit_N_SetNull( )
      {
         gxTv_SdtBR_Pathology_Other_Br_pathology_other_bionumunit_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Other_Br_pathology_other_bionumunit_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Pathology_Other_BioQual_N" )]
      [  XmlElement( ElementName = "BR_Pathology_Other_BioQual_N"   )]
      public short gxTpr_Br_pathology_other_bioqual_N
      {
         get {
            return gxTv_SdtBR_Pathology_Other_Br_pathology_other_bioqual_N ;
         }

         set {
            gxTv_SdtBR_Pathology_Other_Br_pathology_other_bioqual_N = value;
            SetDirty("Br_pathology_other_bioqual_N");
         }

      }

      public void gxTv_SdtBR_Pathology_Other_Br_pathology_other_bioqual_N_SetNull( )
      {
         gxTv_SdtBR_Pathology_Other_Br_pathology_other_bioqual_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Other_Br_pathology_other_bioqual_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Pathology_Other_BioQual_Code_N" )]
      [  XmlElement( ElementName = "BR_Pathology_Other_BioQual_Code_N"   )]
      public short gxTpr_Br_pathology_other_bioqual_code_N
      {
         get {
            return gxTv_SdtBR_Pathology_Other_Br_pathology_other_bioqual_code_N ;
         }

         set {
            gxTv_SdtBR_Pathology_Other_Br_pathology_other_bioqual_code_N = value;
            SetDirty("Br_pathology_other_bioqual_code_N");
         }

      }

      public void gxTv_SdtBR_Pathology_Other_Br_pathology_other_bioqual_code_N_SetNull( )
      {
         gxTv_SdtBR_Pathology_Other_Br_pathology_other_bioqual_code_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Other_Br_pathology_other_bioqual_code_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Pathology_Other_Low_N" )]
      [  XmlElement( ElementName = "BR_Pathology_Other_Low_N"   )]
      public short gxTpr_Br_pathology_other_low_N
      {
         get {
            return gxTv_SdtBR_Pathology_Other_Br_pathology_other_low_N ;
         }

         set {
            gxTv_SdtBR_Pathology_Other_Br_pathology_other_low_N = value;
            SetDirty("Br_pathology_other_low_N");
         }

      }

      public void gxTv_SdtBR_Pathology_Other_Br_pathology_other_low_N_SetNull( )
      {
         gxTv_SdtBR_Pathology_Other_Br_pathology_other_low_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Other_Br_pathology_other_low_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Pathology_Other_High_N" )]
      [  XmlElement( ElementName = "BR_Pathology_Other_High_N"   )]
      public short gxTpr_Br_pathology_other_high_N
      {
         get {
            return gxTv_SdtBR_Pathology_Other_Br_pathology_other_high_N ;
         }

         set {
            gxTv_SdtBR_Pathology_Other_Br_pathology_other_high_N = value;
            SetDirty("Br_pathology_other_high_N");
         }

      }

      public void gxTv_SdtBR_Pathology_Other_Br_pathology_other_high_N_SetNull( )
      {
         gxTv_SdtBR_Pathology_Other_Br_pathology_other_high_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Other_Br_pathology_other_high_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Pathology_Other_AbnInd_N" )]
      [  XmlElement( ElementName = "BR_Pathology_Other_AbnInd_N"   )]
      public short gxTpr_Br_pathology_other_abnind_N
      {
         get {
            return gxTv_SdtBR_Pathology_Other_Br_pathology_other_abnind_N ;
         }

         set {
            gxTv_SdtBR_Pathology_Other_Br_pathology_other_abnind_N = value;
            SetDirty("Br_pathology_other_abnind_N");
         }

      }

      public void gxTv_SdtBR_Pathology_Other_Br_pathology_other_abnind_N_SetNull( )
      {
         gxTv_SdtBR_Pathology_Other_Br_pathology_other_abnind_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Other_Br_pathology_other_abnind_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Pathology_Other_AbnInd_Code_N" )]
      [  XmlElement( ElementName = "BR_Pathology_Other_AbnInd_Code_N"   )]
      public short gxTpr_Br_pathology_other_abnind_code_N
      {
         get {
            return gxTv_SdtBR_Pathology_Other_Br_pathology_other_abnind_code_N ;
         }

         set {
            gxTv_SdtBR_Pathology_Other_Br_pathology_other_abnind_code_N = value;
            SetDirty("Br_pathology_other_abnind_code_N");
         }

      }

      public void gxTv_SdtBR_Pathology_Other_Br_pathology_other_abnind_code_N_SetNull( )
      {
         gxTv_SdtBR_Pathology_Other_Br_pathology_other_abnind_code_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Pathology_Other_Br_pathology_other_abnind_code_N_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_SdtBR_Pathology_Other_Br_pathology_other_bio = "";
         gxTv_SdtBR_Pathology_Other_Br_pathology_other_bio_code = "";
         gxTv_SdtBR_Pathology_Other_Br_pathology_other_bionum_code = "";
         gxTv_SdtBR_Pathology_Other_Br_pathology_other_bionumunit = "";
         gxTv_SdtBR_Pathology_Other_Br_pathology_other_bioqual = "";
         gxTv_SdtBR_Pathology_Other_Br_pathology_other_bioqual_code = "";
         gxTv_SdtBR_Pathology_Other_Br_pathology_other_abnind = "";
         gxTv_SdtBR_Pathology_Other_Br_pathology_other_abnind_code = "";
         gxTv_SdtBR_Pathology_Other_Mode = "";
         gxTv_SdtBR_Pathology_Other_Br_pathology_other_bio_Z = "";
         gxTv_SdtBR_Pathology_Other_Br_pathology_other_bio_code_Z = "";
         gxTv_SdtBR_Pathology_Other_Br_pathology_other_bionum_code_Z = "";
         gxTv_SdtBR_Pathology_Other_Br_pathology_other_bionumunit_Z = "";
         gxTv_SdtBR_Pathology_Other_Br_pathology_other_bioqual_Z = "";
         gxTv_SdtBR_Pathology_Other_Br_pathology_other_bioqual_code_Z = "";
         gxTv_SdtBR_Pathology_Other_Br_pathology_other_abnind_Z = "";
         gxTv_SdtBR_Pathology_Other_Br_pathology_other_abnind_code_Z = "";
         IGxSilentTrn obj ;
         obj = (IGxSilentTrn)ClassLoader.FindInstance( "br_pathology_other", "GeneXus.Programs.br_pathology_other_bc", new Object[] {context}, constructorCallingAssembly);;
         obj.initialize();
         obj.SetSDT(this, 1);
         setTransaction( obj) ;
         obj.SetMode("INS");
         return  ;
      }

      private short gxTv_SdtBR_Pathology_Other_Initialized ;
      private short gxTv_SdtBR_Pathology_Other_Br_pathologyid_N ;
      private short gxTv_SdtBR_Pathology_Other_Br_pathology_other_bio_N ;
      private short gxTv_SdtBR_Pathology_Other_Br_pathology_other_bio_code_N ;
      private short gxTv_SdtBR_Pathology_Other_Br_pathology_other_bionum_N ;
      private short gxTv_SdtBR_Pathology_Other_Br_pathology_other_bionum_code_N ;
      private short gxTv_SdtBR_Pathology_Other_Br_pathology_other_bionumunit_N ;
      private short gxTv_SdtBR_Pathology_Other_Br_pathology_other_bioqual_N ;
      private short gxTv_SdtBR_Pathology_Other_Br_pathology_other_bioqual_code_N ;
      private short gxTv_SdtBR_Pathology_Other_Br_pathology_other_low_N ;
      private short gxTv_SdtBR_Pathology_Other_Br_pathology_other_high_N ;
      private short gxTv_SdtBR_Pathology_Other_Br_pathology_other_abnind_N ;
      private short gxTv_SdtBR_Pathology_Other_Br_pathology_other_abnind_code_N ;
      private long gxTv_SdtBR_Pathology_Other_Br_pathology_otherid ;
      private long gxTv_SdtBR_Pathology_Other_Br_pathologyid ;
      private long gxTv_SdtBR_Pathology_Other_Br_pathology_otherid_Z ;
      private long gxTv_SdtBR_Pathology_Other_Br_pathologyid_Z ;
      private decimal gxTv_SdtBR_Pathology_Other_Br_pathology_other_bionum ;
      private decimal gxTv_SdtBR_Pathology_Other_Br_pathology_other_low ;
      private decimal gxTv_SdtBR_Pathology_Other_Br_pathology_other_high ;
      private decimal gxTv_SdtBR_Pathology_Other_Br_pathology_other_bionum_Z ;
      private decimal gxTv_SdtBR_Pathology_Other_Br_pathology_other_low_Z ;
      private decimal gxTv_SdtBR_Pathology_Other_Br_pathology_other_high_Z ;
      private String gxTv_SdtBR_Pathology_Other_Mode ;
      private String gxTv_SdtBR_Pathology_Other_Br_pathology_other_bio ;
      private String gxTv_SdtBR_Pathology_Other_Br_pathology_other_bio_code ;
      private String gxTv_SdtBR_Pathology_Other_Br_pathology_other_bionum_code ;
      private String gxTv_SdtBR_Pathology_Other_Br_pathology_other_bionumunit ;
      private String gxTv_SdtBR_Pathology_Other_Br_pathology_other_bioqual ;
      private String gxTv_SdtBR_Pathology_Other_Br_pathology_other_bioqual_code ;
      private String gxTv_SdtBR_Pathology_Other_Br_pathology_other_abnind ;
      private String gxTv_SdtBR_Pathology_Other_Br_pathology_other_abnind_code ;
      private String gxTv_SdtBR_Pathology_Other_Br_pathology_other_bio_Z ;
      private String gxTv_SdtBR_Pathology_Other_Br_pathology_other_bio_code_Z ;
      private String gxTv_SdtBR_Pathology_Other_Br_pathology_other_bionum_code_Z ;
      private String gxTv_SdtBR_Pathology_Other_Br_pathology_other_bionumunit_Z ;
      private String gxTv_SdtBR_Pathology_Other_Br_pathology_other_bioqual_Z ;
      private String gxTv_SdtBR_Pathology_Other_Br_pathology_other_bioqual_code_Z ;
      private String gxTv_SdtBR_Pathology_Other_Br_pathology_other_abnind_Z ;
      private String gxTv_SdtBR_Pathology_Other_Br_pathology_other_abnind_code_Z ;
   }

   [DataContract(Name = @"BR_Pathology_Other", Namespace = "DataAnalysisPlatform")]
   public class SdtBR_Pathology_Other_RESTInterface : GxGenericCollectionItem<SdtBR_Pathology_Other>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtBR_Pathology_Other_RESTInterface( ) : base()
      {
      }

      public SdtBR_Pathology_Other_RESTInterface( SdtBR_Pathology_Other psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "BR_Pathology_OtherID" , Order = 0 )]
      [GxSeudo()]
      public String gxTpr_Br_pathology_otherid
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Br_pathology_otherid), 18, 0)) ;
         }

         set {
            sdt.gxTpr_Br_pathology_otherid = (long)(NumberUtil.Val( value, "."));
         }

      }

      [DataMember( Name = "BR_PathologyID" , Order = 1 )]
      [GxSeudo()]
      public String gxTpr_Br_pathologyid
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Br_pathologyid), 18, 0)) ;
         }

         set {
            sdt.gxTpr_Br_pathologyid = (long)(NumberUtil.Val( value, "."));
         }

      }

      [DataMember( Name = "BR_Pathology_Other_Bio" , Order = 2 )]
      [GxSeudo()]
      public String gxTpr_Br_pathology_other_bio
      {
         get {
            return sdt.gxTpr_Br_pathology_other_bio ;
         }

         set {
            sdt.gxTpr_Br_pathology_other_bio = value;
         }

      }

      [DataMember( Name = "BR_Pathology_Other_Bio_Code" , Order = 3 )]
      [GxSeudo()]
      public String gxTpr_Br_pathology_other_bio_code
      {
         get {
            return sdt.gxTpr_Br_pathology_other_bio_code ;
         }

         set {
            sdt.gxTpr_Br_pathology_other_bio_code = value;
         }

      }

      [DataMember( Name = "BR_Pathology_Other_BioNum" , Order = 4 )]
      [GxSeudo()]
      public String gxTpr_Br_pathology_other_bionum
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( sdt.gxTpr_Br_pathology_other_bionum, 15, 5)) ;
         }

         set {
            sdt.gxTpr_Br_pathology_other_bionum = NumberUtil.Val( value, ".");
         }

      }

      [DataMember( Name = "BR_Pathology_Other_BioNum_Code" , Order = 5 )]
      [GxSeudo()]
      public String gxTpr_Br_pathology_other_bionum_code
      {
         get {
            return sdt.gxTpr_Br_pathology_other_bionum_code ;
         }

         set {
            sdt.gxTpr_Br_pathology_other_bionum_code = value;
         }

      }

      [DataMember( Name = "BR_Pathology_Other_BioNumUnit" , Order = 6 )]
      [GxSeudo()]
      public String gxTpr_Br_pathology_other_bionumunit
      {
         get {
            return sdt.gxTpr_Br_pathology_other_bionumunit ;
         }

         set {
            sdt.gxTpr_Br_pathology_other_bionumunit = value;
         }

      }

      [DataMember( Name = "BR_Pathology_Other_BioQual" , Order = 7 )]
      [GxSeudo()]
      public String gxTpr_Br_pathology_other_bioqual
      {
         get {
            return sdt.gxTpr_Br_pathology_other_bioqual ;
         }

         set {
            sdt.gxTpr_Br_pathology_other_bioqual = value;
         }

      }

      [DataMember( Name = "BR_Pathology_Other_BioQual_Code" , Order = 8 )]
      [GxSeudo()]
      public String gxTpr_Br_pathology_other_bioqual_code
      {
         get {
            return sdt.gxTpr_Br_pathology_other_bioqual_code ;
         }

         set {
            sdt.gxTpr_Br_pathology_other_bioqual_code = value;
         }

      }

      [DataMember( Name = "BR_Pathology_Other_Low" , Order = 9 )]
      [GxSeudo()]
      public String gxTpr_Br_pathology_other_low
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( sdt.gxTpr_Br_pathology_other_low, 15, 5)) ;
         }

         set {
            sdt.gxTpr_Br_pathology_other_low = NumberUtil.Val( value, ".");
         }

      }

      [DataMember( Name = "BR_Pathology_Other_High" , Order = 10 )]
      [GxSeudo()]
      public String gxTpr_Br_pathology_other_high
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( sdt.gxTpr_Br_pathology_other_high, 15, 5)) ;
         }

         set {
            sdt.gxTpr_Br_pathology_other_high = NumberUtil.Val( value, ".");
         }

      }

      [DataMember( Name = "BR_Pathology_Other_AbnInd" , Order = 11 )]
      [GxSeudo()]
      public String gxTpr_Br_pathology_other_abnind
      {
         get {
            return sdt.gxTpr_Br_pathology_other_abnind ;
         }

         set {
            sdt.gxTpr_Br_pathology_other_abnind = value;
         }

      }

      [DataMember( Name = "BR_Pathology_Other_AbnInd_Code" , Order = 12 )]
      [GxSeudo()]
      public String gxTpr_Br_pathology_other_abnind_code
      {
         get {
            return sdt.gxTpr_Br_pathology_other_abnind_code ;
         }

         set {
            sdt.gxTpr_Br_pathology_other_abnind_code = value;
         }

      }

      public SdtBR_Pathology_Other sdt
      {
         get {
            return (SdtBR_Pathology_Other)Sdt ;
         }

         set {
            Sdt = value ;
         }

      }

      [OnDeserializing]
      void checkSdt( StreamingContext ctx )
      {
         if ( sdt == null )
         {
            sdt = new SdtBR_Pathology_Other() ;
         }
      }

      [DataMember( Name = "gx_md5_hash", Order = 13 )]
      public string Hash
      {
         get {
            if ( StringUtil.StrCmp(md5Hash, null) == 0 )
            {
               md5Hash = (String)(getHash());
            }
            return md5Hash ;
         }

         set {
            md5Hash = value ;
         }

      }

      private String md5Hash ;
   }

}
