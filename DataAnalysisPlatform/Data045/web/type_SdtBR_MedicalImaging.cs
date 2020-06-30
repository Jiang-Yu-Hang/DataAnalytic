/*
               File: type_SdtBR_MedicalImaging
        Description: Data Mgmt Portal - RAAP
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:8:5.27
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
   [XmlRoot(ElementName = "BR_MedicalImaging" )]
   [XmlType(TypeName =  "BR_MedicalImaging" , Namespace = "DataAnalysisPlatform" )]
   [Serializable]
   public class SdtBR_MedicalImaging : GxSilentTrnSdt, System.Web.SessionState.IRequiresSessionState
   {
      public SdtBR_MedicalImaging( )
      {
      }

      public SdtBR_MedicalImaging( IGxContext context )
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

      public void Load( long AV225BR_MedicalImagingID )
      {
         IGxSilentTrn obj ;
         obj = getTransaction();
         obj.LoadKey(new Object[] {(long)AV225BR_MedicalImagingID});
         return  ;
      }

      public override Object[][] GetBCKey( )
      {
         return (Object[][])(new Object[][]{new Object[]{"BR_MedicalImagingID", typeof(long)}}) ;
      }

      public override GXProperties GetMetadata( )
      {
         GXProperties metadata = new GXProperties() ;
         metadata.Set("Name", "BR_MedicalImaging");
         metadata.Set("BT", "BR_MedicalImaging");
         metadata.Set("PK", "[ \"BR_MedicalImagingID\" ]");
         metadata.Set("PKAssigned", "[ \"BR_MedicalImagingID\" ]");
         metadata.Set("FKList", "[ { \"FK\":[ \"BR_EncounterID\" ],\"FKMap\":[  ] } ]");
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
         state.Add("gxTpr_Br_medicalimagingid_Z");
         state.Add("gxTpr_Br_encounterid_Z");
         state.Add("gxTpr_Br_information_patientno_Z");
         state.Add("gxTpr_Br_medicalimaging_id_Z");
         state.Add("gxTpr_Br_medicalimaging_no_Z");
         state.Add("gxTpr_Br_medicalimaging_imagename_Z");
         state.Add("gxTpr_Br_medicalimaging_imagename_code_Z");
         state.Add("gxTpr_Br_medicalimaging_imagedate_Z_Nullable");
         state.Add("gxTpr_Br_medicalimaging_imagehosp_Z");
         state.Add("gxTpr_Br_medicalimaging_imagehosp_code_Z");
         state.Add("gxTpr_Br_medicalimaging_imageage_Z");
         state.Add("gxTpr_Br_medicalimaging_imageloc_Z");
         state.Add("gxTpr_Br_medicalimaging_imageloc_code_Z");
         state.Add("gxTpr_Br_medicalimaging_imageorgan_Z");
         state.Add("gxTpr_Br_medicalimaging_preimagediag_Z");
         state.Add("gxTpr_Br_medicalimaging_imagedes_Z");
         state.Add("gxTpr_Br_medicalimaging_tumorsize_Z");
         state.Add("gxTpr_Br_medicalimaging_metastasesdx_Z");
         state.Add("gxTpr_Br_medicalimaging_metaloc_Z");
         state.Add("gxTpr_Br_medicalimaging_metadate_Z_Nullable");
         state.Add("gxTpr_Br_medicalimagingid_N");
         state.Add("gxTpr_Br_encounterid_N");
         state.Add("gxTpr_Br_information_patientno_N");
         state.Add("gxTpr_Br_medicalimaging_id_N");
         state.Add("gxTpr_Br_medicalimaging_no_N");
         state.Add("gxTpr_Br_medicalimaging_imagename_N");
         state.Add("gxTpr_Br_medicalimaging_imagename_code_N");
         state.Add("gxTpr_Br_medicalimaging_imagedate_N");
         state.Add("gxTpr_Br_medicalimaging_imagehosp_N");
         state.Add("gxTpr_Br_medicalimaging_imagehosp_code_N");
         state.Add("gxTpr_Br_medicalimaging_imageage_N");
         state.Add("gxTpr_Br_medicalimaging_imageloc_N");
         state.Add("gxTpr_Br_medicalimaging_imageloc_code_N");
         state.Add("gxTpr_Br_medicalimaging_imageorgan_N");
         state.Add("gxTpr_Br_medicalimaging_preimagediag_N");
         state.Add("gxTpr_Br_medicalimaging_imagedes_N");
         state.Add("gxTpr_Br_medicalimaging_tumorsize_N");
         state.Add("gxTpr_Br_medicalimaging_imagehtml_N");
         state.Add("gxTpr_Br_medicalimaging_metastasesdx_N");
         state.Add("gxTpr_Br_medicalimaging_metaloc_N");
         state.Add("gxTpr_Br_medicalimaging_metadate_N");
         return state ;
      }

      public override void Copy( GxUserType source )
      {
         SdtBR_MedicalImaging sdt ;
         sdt = (SdtBR_MedicalImaging)(source);
         gxTv_SdtBR_MedicalImaging_Br_medicalimagingid = sdt.gxTv_SdtBR_MedicalImaging_Br_medicalimagingid ;
         gxTv_SdtBR_MedicalImaging_Br_encounterid = sdt.gxTv_SdtBR_MedicalImaging_Br_encounterid ;
         gxTv_SdtBR_MedicalImaging_Br_information_patientno = sdt.gxTv_SdtBR_MedicalImaging_Br_information_patientno ;
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_id = sdt.gxTv_SdtBR_MedicalImaging_Br_medicalimaging_id ;
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_no = sdt.gxTv_SdtBR_MedicalImaging_Br_medicalimaging_no ;
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagename = sdt.gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagename ;
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagename_code = sdt.gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagename_code ;
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagedate = sdt.gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagedate ;
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagehosp = sdt.gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagehosp ;
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagehosp_code = sdt.gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagehosp_code ;
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageage = sdt.gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageage ;
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageloc = sdt.gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageloc ;
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageloc_code = sdt.gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageloc_code ;
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageorgan = sdt.gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageorgan ;
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_preimagediag = sdt.gxTv_SdtBR_MedicalImaging_Br_medicalimaging_preimagediag ;
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagedes = sdt.gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagedes ;
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_tumorsize = sdt.gxTv_SdtBR_MedicalImaging_Br_medicalimaging_tumorsize ;
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagehtml = sdt.gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagehtml ;
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metastasesdx = sdt.gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metastasesdx ;
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metaloc = sdt.gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metaloc ;
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metadate = sdt.gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metadate ;
         gxTv_SdtBR_MedicalImaging_Mode = sdt.gxTv_SdtBR_MedicalImaging_Mode ;
         gxTv_SdtBR_MedicalImaging_Initialized = sdt.gxTv_SdtBR_MedicalImaging_Initialized ;
         gxTv_SdtBR_MedicalImaging_Br_medicalimagingid_Z = sdt.gxTv_SdtBR_MedicalImaging_Br_medicalimagingid_Z ;
         gxTv_SdtBR_MedicalImaging_Br_encounterid_Z = sdt.gxTv_SdtBR_MedicalImaging_Br_encounterid_Z ;
         gxTv_SdtBR_MedicalImaging_Br_information_patientno_Z = sdt.gxTv_SdtBR_MedicalImaging_Br_information_patientno_Z ;
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_id_Z = sdt.gxTv_SdtBR_MedicalImaging_Br_medicalimaging_id_Z ;
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_no_Z = sdt.gxTv_SdtBR_MedicalImaging_Br_medicalimaging_no_Z ;
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagename_Z = sdt.gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagename_Z ;
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagename_code_Z = sdt.gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagename_code_Z ;
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagedate_Z = sdt.gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagedate_Z ;
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagehosp_Z = sdt.gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagehosp_Z ;
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagehosp_code_Z = sdt.gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagehosp_code_Z ;
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageage_Z = sdt.gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageage_Z ;
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageloc_Z = sdt.gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageloc_Z ;
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageloc_code_Z = sdt.gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageloc_code_Z ;
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageorgan_Z = sdt.gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageorgan_Z ;
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_preimagediag_Z = sdt.gxTv_SdtBR_MedicalImaging_Br_medicalimaging_preimagediag_Z ;
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagedes_Z = sdt.gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagedes_Z ;
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_tumorsize_Z = sdt.gxTv_SdtBR_MedicalImaging_Br_medicalimaging_tumorsize_Z ;
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metastasesdx_Z = sdt.gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metastasesdx_Z ;
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metaloc_Z = sdt.gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metaloc_Z ;
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metadate_Z = sdt.gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metadate_Z ;
         gxTv_SdtBR_MedicalImaging_Br_medicalimagingid_N = sdt.gxTv_SdtBR_MedicalImaging_Br_medicalimagingid_N ;
         gxTv_SdtBR_MedicalImaging_Br_encounterid_N = sdt.gxTv_SdtBR_MedicalImaging_Br_encounterid_N ;
         gxTv_SdtBR_MedicalImaging_Br_information_patientno_N = sdt.gxTv_SdtBR_MedicalImaging_Br_information_patientno_N ;
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_id_N = sdt.gxTv_SdtBR_MedicalImaging_Br_medicalimaging_id_N ;
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_no_N = sdt.gxTv_SdtBR_MedicalImaging_Br_medicalimaging_no_N ;
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagename_N = sdt.gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagename_N ;
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagename_code_N = sdt.gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagename_code_N ;
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagedate_N = sdt.gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagedate_N ;
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagehosp_N = sdt.gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagehosp_N ;
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagehosp_code_N = sdt.gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagehosp_code_N ;
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageage_N = sdt.gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageage_N ;
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageloc_N = sdt.gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageloc_N ;
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageloc_code_N = sdt.gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageloc_code_N ;
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageorgan_N = sdt.gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageorgan_N ;
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_preimagediag_N = sdt.gxTv_SdtBR_MedicalImaging_Br_medicalimaging_preimagediag_N ;
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagedes_N = sdt.gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagedes_N ;
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_tumorsize_N = sdt.gxTv_SdtBR_MedicalImaging_Br_medicalimaging_tumorsize_N ;
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagehtml_N = sdt.gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagehtml_N ;
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metastasesdx_N = sdt.gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metastasesdx_N ;
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metaloc_N = sdt.gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metaloc_N ;
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metadate_N = sdt.gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metadate_N ;
         return  ;
      }

      public override void ToJSON( )
      {
         ToJSON( true) ;
         return  ;
      }

      public override void ToJSON( bool includeState )
      {
         AddObjectProperty("BR_MedicalImagingID", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_MedicalImaging_Br_medicalimagingid), 18, 0)), false);
         AddObjectProperty("BR_MedicalImagingID_N", gxTv_SdtBR_MedicalImaging_Br_medicalimagingid_N, false);
         AddObjectProperty("BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_MedicalImaging_Br_encounterid), 18, 0)), false);
         AddObjectProperty("BR_EncounterID_N", gxTv_SdtBR_MedicalImaging_Br_encounterid_N, false);
         AddObjectProperty("BR_Information_PatientNo", gxTv_SdtBR_MedicalImaging_Br_information_patientno, false);
         AddObjectProperty("BR_Information_PatientNo_N", gxTv_SdtBR_MedicalImaging_Br_information_patientno_N, false);
         AddObjectProperty("BR_MedicalImaging_ID", gxTv_SdtBR_MedicalImaging_Br_medicalimaging_id, false);
         AddObjectProperty("BR_MedicalImaging_ID_N", gxTv_SdtBR_MedicalImaging_Br_medicalimaging_id_N, false);
         AddObjectProperty("BR_MedicalImaging_No", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_MedicalImaging_Br_medicalimaging_no), 18, 0)), false);
         AddObjectProperty("BR_MedicalImaging_No_N", gxTv_SdtBR_MedicalImaging_Br_medicalimaging_no_N, false);
         AddObjectProperty("BR_MedicalImaging_ImageName", gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagename, false);
         AddObjectProperty("BR_MedicalImaging_ImageName_N", gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagename_N, false);
         AddObjectProperty("BR_MedicalImaging_ImageName_Code", gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagename_code, false);
         AddObjectProperty("BR_MedicalImaging_ImageName_Code_N", gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagename_code_N, false);
         sDateCnv = "";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagedate)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagedate)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagedate)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         AddObjectProperty("BR_MedicalImaging_ImageDate", sDateCnv, false);
         AddObjectProperty("BR_MedicalImaging_ImageDate_N", gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagedate_N, false);
         AddObjectProperty("BR_MedicalImaging_ImageHosp", gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagehosp, false);
         AddObjectProperty("BR_MedicalImaging_ImageHosp_N", gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagehosp_N, false);
         AddObjectProperty("BR_MedicalImaging_ImageHosp_Code", gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagehosp_code, false);
         AddObjectProperty("BR_MedicalImaging_ImageHosp_Code_N", gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagehosp_code_N, false);
         AddObjectProperty("BR_MedicalImaging_ImageAge", gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageage, false);
         AddObjectProperty("BR_MedicalImaging_ImageAge_N", gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageage_N, false);
         AddObjectProperty("BR_MedicalImaging_ImageLoc", gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageloc, false);
         AddObjectProperty("BR_MedicalImaging_ImageLoc_N", gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageloc_N, false);
         AddObjectProperty("BR_MedicalImaging_ImageLoc_Code", gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageloc_code, false);
         AddObjectProperty("BR_MedicalImaging_ImageLoc_Code_N", gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageloc_code_N, false);
         AddObjectProperty("BR_MedicalImaging_ImageOrgan", gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageorgan, false);
         AddObjectProperty("BR_MedicalImaging_ImageOrgan_N", gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageorgan_N, false);
         AddObjectProperty("BR_MedicalImaging_PreImageDiag", gxTv_SdtBR_MedicalImaging_Br_medicalimaging_preimagediag, false);
         AddObjectProperty("BR_MedicalImaging_PreImageDiag_N", gxTv_SdtBR_MedicalImaging_Br_medicalimaging_preimagediag_N, false);
         AddObjectProperty("BR_MedicalImaging_ImageDes", gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagedes, false);
         AddObjectProperty("BR_MedicalImaging_ImageDes_N", gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagedes_N, false);
         AddObjectProperty("BR_MedicalImaging_TumorSize", gxTv_SdtBR_MedicalImaging_Br_medicalimaging_tumorsize, false);
         AddObjectProperty("BR_MedicalImaging_TumorSize_N", gxTv_SdtBR_MedicalImaging_Br_medicalimaging_tumorsize_N, false);
         AddObjectProperty("BR_MedicalImaging_ImageHtml", gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagehtml, false);
         AddObjectProperty("BR_MedicalImaging_ImageHtml_N", gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagehtml_N, false);
         AddObjectProperty("BR_MedicalImaging_MetastasesDX", gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metastasesdx, false);
         AddObjectProperty("BR_MedicalImaging_MetastasesDX_N", gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metastasesdx_N, false);
         AddObjectProperty("BR_MedicalImaging_MetaLoc", gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metaloc, false);
         AddObjectProperty("BR_MedicalImaging_MetaLoc_N", gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metaloc_N, false);
         sDateCnv = "";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metadate)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metadate)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metadate)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         AddObjectProperty("BR_MedicalImaging_MetaDate", sDateCnv, false);
         AddObjectProperty("BR_MedicalImaging_MetaDate_N", gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metadate_N, false);
         if ( includeState )
         {
            AddObjectProperty("Mode", gxTv_SdtBR_MedicalImaging_Mode, false);
            AddObjectProperty("Initialized", gxTv_SdtBR_MedicalImaging_Initialized, false);
            AddObjectProperty("BR_MedicalImagingID_Z", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_MedicalImaging_Br_medicalimagingid_Z), 18, 0)), false);
            AddObjectProperty("BR_EncounterID_Z", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_MedicalImaging_Br_encounterid_Z), 18, 0)), false);
            AddObjectProperty("BR_Information_PatientNo_Z", gxTv_SdtBR_MedicalImaging_Br_information_patientno_Z, false);
            AddObjectProperty("BR_MedicalImaging_ID_Z", gxTv_SdtBR_MedicalImaging_Br_medicalimaging_id_Z, false);
            AddObjectProperty("BR_MedicalImaging_No_Z", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_MedicalImaging_Br_medicalimaging_no_Z), 18, 0)), false);
            AddObjectProperty("BR_MedicalImaging_ImageName_Z", gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagename_Z, false);
            AddObjectProperty("BR_MedicalImaging_ImageName_Code_Z", gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagename_code_Z, false);
            sDateCnv = "";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagedate_Z)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagedate_Z)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagedate_Z)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            AddObjectProperty("BR_MedicalImaging_ImageDate_Z", sDateCnv, false);
            AddObjectProperty("BR_MedicalImaging_ImageHosp_Z", gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagehosp_Z, false);
            AddObjectProperty("BR_MedicalImaging_ImageHosp_Code_Z", gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagehosp_code_Z, false);
            AddObjectProperty("BR_MedicalImaging_ImageAge_Z", gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageage_Z, false);
            AddObjectProperty("BR_MedicalImaging_ImageLoc_Z", gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageloc_Z, false);
            AddObjectProperty("BR_MedicalImaging_ImageLoc_Code_Z", gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageloc_code_Z, false);
            AddObjectProperty("BR_MedicalImaging_ImageOrgan_Z", gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageorgan_Z, false);
            AddObjectProperty("BR_MedicalImaging_PreImageDiag_Z", gxTv_SdtBR_MedicalImaging_Br_medicalimaging_preimagediag_Z, false);
            AddObjectProperty("BR_MedicalImaging_ImageDes_Z", gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagedes_Z, false);
            AddObjectProperty("BR_MedicalImaging_TumorSize_Z", gxTv_SdtBR_MedicalImaging_Br_medicalimaging_tumorsize_Z, false);
            AddObjectProperty("BR_MedicalImaging_MetastasesDX_Z", gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metastasesdx_Z, false);
            AddObjectProperty("BR_MedicalImaging_MetaLoc_Z", gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metaloc_Z, false);
            sDateCnv = "";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metadate_Z)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metadate_Z)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metadate_Z)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            AddObjectProperty("BR_MedicalImaging_MetaDate_Z", sDateCnv, false);
            AddObjectProperty("BR_MedicalImagingID_N", gxTv_SdtBR_MedicalImaging_Br_medicalimagingid_N, false);
            AddObjectProperty("BR_EncounterID_N", gxTv_SdtBR_MedicalImaging_Br_encounterid_N, false);
            AddObjectProperty("BR_Information_PatientNo_N", gxTv_SdtBR_MedicalImaging_Br_information_patientno_N, false);
            AddObjectProperty("BR_MedicalImaging_ID_N", gxTv_SdtBR_MedicalImaging_Br_medicalimaging_id_N, false);
            AddObjectProperty("BR_MedicalImaging_No_N", gxTv_SdtBR_MedicalImaging_Br_medicalimaging_no_N, false);
            AddObjectProperty("BR_MedicalImaging_ImageName_N", gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagename_N, false);
            AddObjectProperty("BR_MedicalImaging_ImageName_Code_N", gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagename_code_N, false);
            AddObjectProperty("BR_MedicalImaging_ImageDate_N", gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagedate_N, false);
            AddObjectProperty("BR_MedicalImaging_ImageHosp_N", gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagehosp_N, false);
            AddObjectProperty("BR_MedicalImaging_ImageHosp_Code_N", gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagehosp_code_N, false);
            AddObjectProperty("BR_MedicalImaging_ImageAge_N", gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageage_N, false);
            AddObjectProperty("BR_MedicalImaging_ImageLoc_N", gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageloc_N, false);
            AddObjectProperty("BR_MedicalImaging_ImageLoc_Code_N", gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageloc_code_N, false);
            AddObjectProperty("BR_MedicalImaging_ImageOrgan_N", gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageorgan_N, false);
            AddObjectProperty("BR_MedicalImaging_PreImageDiag_N", gxTv_SdtBR_MedicalImaging_Br_medicalimaging_preimagediag_N, false);
            AddObjectProperty("BR_MedicalImaging_ImageDes_N", gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagedes_N, false);
            AddObjectProperty("BR_MedicalImaging_TumorSize_N", gxTv_SdtBR_MedicalImaging_Br_medicalimaging_tumorsize_N, false);
            AddObjectProperty("BR_MedicalImaging_ImageHtml_N", gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagehtml_N, false);
            AddObjectProperty("BR_MedicalImaging_MetastasesDX_N", gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metastasesdx_N, false);
            AddObjectProperty("BR_MedicalImaging_MetaLoc_N", gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metaloc_N, false);
            AddObjectProperty("BR_MedicalImaging_MetaDate_N", gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metadate_N, false);
         }
         return  ;
      }

      public void UpdateDirties( SdtBR_MedicalImaging sdt )
      {
         if ( sdt.IsDirty("BR_MedicalImagingID") )
         {
            gxTv_SdtBR_MedicalImaging_Br_medicalimagingid = sdt.gxTv_SdtBR_MedicalImaging_Br_medicalimagingid ;
         }
         if ( sdt.IsDirty("BR_EncounterID") )
         {
            gxTv_SdtBR_MedicalImaging_Br_encounterid = sdt.gxTv_SdtBR_MedicalImaging_Br_encounterid ;
         }
         if ( sdt.IsDirty("BR_Information_PatientNo") )
         {
            gxTv_SdtBR_MedicalImaging_Br_information_patientno = sdt.gxTv_SdtBR_MedicalImaging_Br_information_patientno ;
         }
         if ( sdt.IsDirty("BR_MedicalImaging_ID") )
         {
            gxTv_SdtBR_MedicalImaging_Br_medicalimaging_id = sdt.gxTv_SdtBR_MedicalImaging_Br_medicalimaging_id ;
         }
         if ( sdt.IsDirty("BR_MedicalImaging_No") )
         {
            gxTv_SdtBR_MedicalImaging_Br_medicalimaging_no = sdt.gxTv_SdtBR_MedicalImaging_Br_medicalimaging_no ;
         }
         if ( sdt.IsDirty("BR_MedicalImaging_ImageName") )
         {
            gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagename = sdt.gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagename ;
         }
         if ( sdt.IsDirty("BR_MedicalImaging_ImageName_Code") )
         {
            gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagename_code = sdt.gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagename_code ;
         }
         if ( sdt.IsDirty("BR_MedicalImaging_ImageDate") )
         {
            gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagedate = sdt.gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagedate ;
         }
         if ( sdt.IsDirty("BR_MedicalImaging_ImageHosp") )
         {
            gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagehosp = sdt.gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagehosp ;
         }
         if ( sdt.IsDirty("BR_MedicalImaging_ImageHosp_Code") )
         {
            gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagehosp_code = sdt.gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagehosp_code ;
         }
         if ( sdt.IsDirty("BR_MedicalImaging_ImageAge") )
         {
            gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageage = sdt.gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageage ;
         }
         if ( sdt.IsDirty("BR_MedicalImaging_ImageLoc") )
         {
            gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageloc = sdt.gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageloc ;
         }
         if ( sdt.IsDirty("BR_MedicalImaging_ImageLoc_Code") )
         {
            gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageloc_code = sdt.gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageloc_code ;
         }
         if ( sdt.IsDirty("BR_MedicalImaging_ImageOrgan") )
         {
            gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageorgan = sdt.gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageorgan ;
         }
         if ( sdt.IsDirty("BR_MedicalImaging_PreImageDiag") )
         {
            gxTv_SdtBR_MedicalImaging_Br_medicalimaging_preimagediag = sdt.gxTv_SdtBR_MedicalImaging_Br_medicalimaging_preimagediag ;
         }
         if ( sdt.IsDirty("BR_MedicalImaging_ImageDes") )
         {
            gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagedes = sdt.gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagedes ;
         }
         if ( sdt.IsDirty("BR_MedicalImaging_TumorSize") )
         {
            gxTv_SdtBR_MedicalImaging_Br_medicalimaging_tumorsize = sdt.gxTv_SdtBR_MedicalImaging_Br_medicalimaging_tumorsize ;
         }
         if ( sdt.IsDirty("BR_MedicalImaging_ImageHtml") )
         {
            gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagehtml = sdt.gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagehtml ;
         }
         if ( sdt.IsDirty("BR_MedicalImaging_MetastasesDX") )
         {
            gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metastasesdx = sdt.gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metastasesdx ;
         }
         if ( sdt.IsDirty("BR_MedicalImaging_MetaLoc") )
         {
            gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metaloc = sdt.gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metaloc ;
         }
         if ( sdt.IsDirty("BR_MedicalImaging_MetaDate") )
         {
            gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metadate = sdt.gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metadate ;
         }
         return  ;
      }

      [  SoapElement( ElementName = "BR_MedicalImagingID" )]
      [  XmlElement( ElementName = "BR_MedicalImagingID"   )]
      public long gxTpr_Br_medicalimagingid
      {
         get {
            return gxTv_SdtBR_MedicalImaging_Br_medicalimagingid ;
         }

         set {
            if ( gxTv_SdtBR_MedicalImaging_Br_medicalimagingid != value )
            {
               gxTv_SdtBR_MedicalImaging_Mode = "INS";
               this.gxTv_SdtBR_MedicalImaging_Br_medicalimagingid_Z_SetNull( );
               this.gxTv_SdtBR_MedicalImaging_Br_encounterid_Z_SetNull( );
               this.gxTv_SdtBR_MedicalImaging_Br_information_patientno_Z_SetNull( );
               this.gxTv_SdtBR_MedicalImaging_Br_medicalimaging_id_Z_SetNull( );
               this.gxTv_SdtBR_MedicalImaging_Br_medicalimaging_no_Z_SetNull( );
               this.gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagename_Z_SetNull( );
               this.gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagename_code_Z_SetNull( );
               this.gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagedate_Z_SetNull( );
               this.gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagehosp_Z_SetNull( );
               this.gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagehosp_code_Z_SetNull( );
               this.gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageage_Z_SetNull( );
               this.gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageloc_Z_SetNull( );
               this.gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageloc_code_Z_SetNull( );
               this.gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageorgan_Z_SetNull( );
               this.gxTv_SdtBR_MedicalImaging_Br_medicalimaging_preimagediag_Z_SetNull( );
               this.gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagedes_Z_SetNull( );
               this.gxTv_SdtBR_MedicalImaging_Br_medicalimaging_tumorsize_Z_SetNull( );
               this.gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metastasesdx_Z_SetNull( );
               this.gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metaloc_Z_SetNull( );
               this.gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metadate_Z_SetNull( );
            }
            gxTv_SdtBR_MedicalImaging_Br_medicalimagingid = value;
            SetDirty("Br_medicalimagingid");
         }

      }

      [  SoapElement( ElementName = "BR_EncounterID" )]
      [  XmlElement( ElementName = "BR_EncounterID"   )]
      public long gxTpr_Br_encounterid
      {
         get {
            return gxTv_SdtBR_MedicalImaging_Br_encounterid ;
         }

         set {
            gxTv_SdtBR_MedicalImaging_Br_encounterid_N = 0;
            gxTv_SdtBR_MedicalImaging_Br_encounterid = value;
            SetDirty("Br_encounterid");
         }

      }

      public void gxTv_SdtBR_MedicalImaging_Br_encounterid_SetNull( )
      {
         gxTv_SdtBR_MedicalImaging_Br_encounterid_N = 1;
         gxTv_SdtBR_MedicalImaging_Br_encounterid = 0;
         return  ;
      }

      public bool gxTv_SdtBR_MedicalImaging_Br_encounterid_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Information_PatientNo" )]
      [  XmlElement( ElementName = "BR_Information_PatientNo"   )]
      public String gxTpr_Br_information_patientno
      {
         get {
            return gxTv_SdtBR_MedicalImaging_Br_information_patientno ;
         }

         set {
            gxTv_SdtBR_MedicalImaging_Br_information_patientno_N = 0;
            gxTv_SdtBR_MedicalImaging_Br_information_patientno = value;
            SetDirty("Br_information_patientno");
         }

      }

      public void gxTv_SdtBR_MedicalImaging_Br_information_patientno_SetNull( )
      {
         gxTv_SdtBR_MedicalImaging_Br_information_patientno_N = 1;
         gxTv_SdtBR_MedicalImaging_Br_information_patientno = "";
         return  ;
      }

      public bool gxTv_SdtBR_MedicalImaging_Br_information_patientno_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_MedicalImaging_ID" )]
      [  XmlElement( ElementName = "BR_MedicalImaging_ID"   )]
      public long gxTpr_Br_medicalimaging_id
      {
         get {
            return gxTv_SdtBR_MedicalImaging_Br_medicalimaging_id ;
         }

         set {
            gxTv_SdtBR_MedicalImaging_Br_medicalimaging_id_N = 0;
            gxTv_SdtBR_MedicalImaging_Br_medicalimaging_id = value;
            SetDirty("Br_medicalimaging_id");
         }

      }

      public void gxTv_SdtBR_MedicalImaging_Br_medicalimaging_id_SetNull( )
      {
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_id_N = 1;
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_id = 0;
         return  ;
      }

      public bool gxTv_SdtBR_MedicalImaging_Br_medicalimaging_id_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_MedicalImaging_No" )]
      [  XmlElement( ElementName = "BR_MedicalImaging_No"   )]
      public long gxTpr_Br_medicalimaging_no
      {
         get {
            return gxTv_SdtBR_MedicalImaging_Br_medicalimaging_no ;
         }

         set {
            gxTv_SdtBR_MedicalImaging_Br_medicalimaging_no_N = 0;
            gxTv_SdtBR_MedicalImaging_Br_medicalimaging_no = value;
            SetDirty("Br_medicalimaging_no");
         }

      }

      public void gxTv_SdtBR_MedicalImaging_Br_medicalimaging_no_SetNull( )
      {
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_no_N = 1;
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_no = 0;
         return  ;
      }

      public bool gxTv_SdtBR_MedicalImaging_Br_medicalimaging_no_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_MedicalImaging_ImageName" )]
      [  XmlElement( ElementName = "BR_MedicalImaging_ImageName"   )]
      public String gxTpr_Br_medicalimaging_imagename
      {
         get {
            return gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagename ;
         }

         set {
            gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagename_N = 0;
            gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagename = value;
            SetDirty("Br_medicalimaging_imagename");
         }

      }

      public void gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagename_SetNull( )
      {
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagename_N = 1;
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagename = "";
         return  ;
      }

      public bool gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagename_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_MedicalImaging_ImageName_Code" )]
      [  XmlElement( ElementName = "BR_MedicalImaging_ImageName_Code"   )]
      public String gxTpr_Br_medicalimaging_imagename_code
      {
         get {
            return gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagename_code ;
         }

         set {
            gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagename_code_N = 0;
            gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagename_code = value;
            SetDirty("Br_medicalimaging_imagename_code");
         }

      }

      public void gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagename_code_SetNull( )
      {
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagename_code_N = 1;
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagename_code = "";
         return  ;
      }

      public bool gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagename_code_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_MedicalImaging_ImageDate" )]
      [  XmlElement( ElementName = "BR_MedicalImaging_ImageDate"  , IsNullable=true )]
      public string gxTpr_Br_medicalimaging_imagedate_Nullable
      {
         get {
            if ( gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagedate == DateTime.MinValue)
               return null;
            return new GxDateString(gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagedate).value ;
         }

         set {
            gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagedate_N = 0;
            if (String.IsNullOrEmpty(value) || value == GxDateString.NullValue )
               gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagedate = DateTime.MinValue;
            else
               gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagedate = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Br_medicalimaging_imagedate
      {
         get {
            return gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagedate ;
         }

         set {
            gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagedate_N = 0;
            gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagedate = value;
            SetDirty("Br_medicalimaging_imagedate");
         }

      }

      public void gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagedate_SetNull( )
      {
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagedate_N = 1;
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagedate = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagedate_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_MedicalImaging_ImageHosp" )]
      [  XmlElement( ElementName = "BR_MedicalImaging_ImageHosp"   )]
      public String gxTpr_Br_medicalimaging_imagehosp
      {
         get {
            return gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagehosp ;
         }

         set {
            gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagehosp_N = 0;
            gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagehosp = value;
            SetDirty("Br_medicalimaging_imagehosp");
         }

      }

      public void gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagehosp_SetNull( )
      {
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagehosp_N = 1;
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagehosp = "";
         return  ;
      }

      public bool gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagehosp_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_MedicalImaging_ImageHosp_Code" )]
      [  XmlElement( ElementName = "BR_MedicalImaging_ImageHosp_Code"   )]
      public String gxTpr_Br_medicalimaging_imagehosp_code
      {
         get {
            return gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagehosp_code ;
         }

         set {
            gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagehosp_code_N = 0;
            gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagehosp_code = value;
            SetDirty("Br_medicalimaging_imagehosp_code");
         }

      }

      public void gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagehosp_code_SetNull( )
      {
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagehosp_code_N = 1;
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagehosp_code = "";
         return  ;
      }

      public bool gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagehosp_code_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_MedicalImaging_ImageAge" )]
      [  XmlElement( ElementName = "BR_MedicalImaging_ImageAge"   )]
      public short gxTpr_Br_medicalimaging_imageage
      {
         get {
            return gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageage ;
         }

         set {
            gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageage_N = 0;
            gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageage = value;
            SetDirty("Br_medicalimaging_imageage");
         }

      }

      public void gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageage_SetNull( )
      {
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageage_N = 1;
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageage = 0;
         return  ;
      }

      public bool gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageage_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_MedicalImaging_ImageLoc" )]
      [  XmlElement( ElementName = "BR_MedicalImaging_ImageLoc"   )]
      public String gxTpr_Br_medicalimaging_imageloc
      {
         get {
            return gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageloc ;
         }

         set {
            gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageloc_N = 0;
            gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageloc = value;
            SetDirty("Br_medicalimaging_imageloc");
         }

      }

      public void gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageloc_SetNull( )
      {
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageloc_N = 1;
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageloc = "";
         return  ;
      }

      public bool gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageloc_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_MedicalImaging_ImageLoc_Code" )]
      [  XmlElement( ElementName = "BR_MedicalImaging_ImageLoc_Code"   )]
      public String gxTpr_Br_medicalimaging_imageloc_code
      {
         get {
            return gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageloc_code ;
         }

         set {
            gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageloc_code_N = 0;
            gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageloc_code = value;
            SetDirty("Br_medicalimaging_imageloc_code");
         }

      }

      public void gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageloc_code_SetNull( )
      {
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageloc_code_N = 1;
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageloc_code = "";
         return  ;
      }

      public bool gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageloc_code_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_MedicalImaging_ImageOrgan" )]
      [  XmlElement( ElementName = "BR_MedicalImaging_ImageOrgan"   )]
      public String gxTpr_Br_medicalimaging_imageorgan
      {
         get {
            return gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageorgan ;
         }

         set {
            gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageorgan_N = 0;
            gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageorgan = value;
            SetDirty("Br_medicalimaging_imageorgan");
         }

      }

      public void gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageorgan_SetNull( )
      {
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageorgan_N = 1;
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageorgan = "";
         return  ;
      }

      public bool gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageorgan_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_MedicalImaging_PreImageDiag" )]
      [  XmlElement( ElementName = "BR_MedicalImaging_PreImageDiag"   )]
      public String gxTpr_Br_medicalimaging_preimagediag
      {
         get {
            return gxTv_SdtBR_MedicalImaging_Br_medicalimaging_preimagediag ;
         }

         set {
            gxTv_SdtBR_MedicalImaging_Br_medicalimaging_preimagediag_N = 0;
            gxTv_SdtBR_MedicalImaging_Br_medicalimaging_preimagediag = value;
            SetDirty("Br_medicalimaging_preimagediag");
         }

      }

      public void gxTv_SdtBR_MedicalImaging_Br_medicalimaging_preimagediag_SetNull( )
      {
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_preimagediag_N = 1;
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_preimagediag = "";
         return  ;
      }

      public bool gxTv_SdtBR_MedicalImaging_Br_medicalimaging_preimagediag_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_MedicalImaging_ImageDes" )]
      [  XmlElement( ElementName = "BR_MedicalImaging_ImageDes"   )]
      public String gxTpr_Br_medicalimaging_imagedes
      {
         get {
            return gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagedes ;
         }

         set {
            gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagedes_N = 0;
            gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagedes = value;
            SetDirty("Br_medicalimaging_imagedes");
         }

      }

      public void gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagedes_SetNull( )
      {
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagedes_N = 1;
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagedes = "";
         return  ;
      }

      public bool gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagedes_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_MedicalImaging_TumorSize" )]
      [  XmlElement( ElementName = "BR_MedicalImaging_TumorSize"   )]
      public String gxTpr_Br_medicalimaging_tumorsize
      {
         get {
            return gxTv_SdtBR_MedicalImaging_Br_medicalimaging_tumorsize ;
         }

         set {
            gxTv_SdtBR_MedicalImaging_Br_medicalimaging_tumorsize_N = 0;
            gxTv_SdtBR_MedicalImaging_Br_medicalimaging_tumorsize = value;
            SetDirty("Br_medicalimaging_tumorsize");
         }

      }

      public void gxTv_SdtBR_MedicalImaging_Br_medicalimaging_tumorsize_SetNull( )
      {
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_tumorsize_N = 1;
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_tumorsize = "";
         return  ;
      }

      public bool gxTv_SdtBR_MedicalImaging_Br_medicalimaging_tumorsize_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_MedicalImaging_ImageHtml" )]
      [  XmlElement( ElementName = "BR_MedicalImaging_ImageHtml"   )]
      public String gxTpr_Br_medicalimaging_imagehtml
      {
         get {
            return gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagehtml ;
         }

         set {
            gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagehtml_N = 0;
            gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagehtml = value;
            SetDirty("Br_medicalimaging_imagehtml");
         }

      }

      public void gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagehtml_SetNull( )
      {
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagehtml_N = 1;
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagehtml = "";
         return  ;
      }

      public bool gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagehtml_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_MedicalImaging_MetastasesDX" )]
      [  XmlElement( ElementName = "BR_MedicalImaging_MetastasesDX"   )]
      public String gxTpr_Br_medicalimaging_metastasesdx
      {
         get {
            return gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metastasesdx ;
         }

         set {
            gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metastasesdx_N = 0;
            gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metastasesdx = value;
            SetDirty("Br_medicalimaging_metastasesdx");
         }

      }

      public void gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metastasesdx_SetNull( )
      {
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metastasesdx_N = 1;
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metastasesdx = "";
         return  ;
      }

      public bool gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metastasesdx_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_MedicalImaging_MetaLoc" )]
      [  XmlElement( ElementName = "BR_MedicalImaging_MetaLoc"   )]
      public String gxTpr_Br_medicalimaging_metaloc
      {
         get {
            return gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metaloc ;
         }

         set {
            gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metaloc_N = 0;
            gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metaloc = value;
            SetDirty("Br_medicalimaging_metaloc");
         }

      }

      public void gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metaloc_SetNull( )
      {
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metaloc_N = 1;
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metaloc = "";
         return  ;
      }

      public bool gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metaloc_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_MedicalImaging_MetaDate" )]
      [  XmlElement( ElementName = "BR_MedicalImaging_MetaDate"  , IsNullable=true )]
      public string gxTpr_Br_medicalimaging_metadate_Nullable
      {
         get {
            if ( gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metadate == DateTime.MinValue)
               return null;
            return new GxDateString(gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metadate).value ;
         }

         set {
            gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metadate_N = 0;
            if (String.IsNullOrEmpty(value) || value == GxDateString.NullValue )
               gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metadate = DateTime.MinValue;
            else
               gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metadate = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Br_medicalimaging_metadate
      {
         get {
            return gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metadate ;
         }

         set {
            gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metadate_N = 0;
            gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metadate = value;
            SetDirty("Br_medicalimaging_metadate");
         }

      }

      public void gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metadate_SetNull( )
      {
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metadate_N = 1;
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metadate = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metadate_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Mode" )]
      [  XmlElement( ElementName = "Mode"   )]
      public String gxTpr_Mode
      {
         get {
            return gxTv_SdtBR_MedicalImaging_Mode ;
         }

         set {
            gxTv_SdtBR_MedicalImaging_Mode = value;
            SetDirty("Mode");
         }

      }

      public void gxTv_SdtBR_MedicalImaging_Mode_SetNull( )
      {
         gxTv_SdtBR_MedicalImaging_Mode = "";
         return  ;
      }

      public bool gxTv_SdtBR_MedicalImaging_Mode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Initialized" )]
      [  XmlElement( ElementName = "Initialized"   )]
      public short gxTpr_Initialized
      {
         get {
            return gxTv_SdtBR_MedicalImaging_Initialized ;
         }

         set {
            gxTv_SdtBR_MedicalImaging_Initialized = value;
            SetDirty("Initialized");
         }

      }

      public void gxTv_SdtBR_MedicalImaging_Initialized_SetNull( )
      {
         gxTv_SdtBR_MedicalImaging_Initialized = 0;
         return  ;
      }

      public bool gxTv_SdtBR_MedicalImaging_Initialized_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_MedicalImagingID_Z" )]
      [  XmlElement( ElementName = "BR_MedicalImagingID_Z"   )]
      public long gxTpr_Br_medicalimagingid_Z
      {
         get {
            return gxTv_SdtBR_MedicalImaging_Br_medicalimagingid_Z ;
         }

         set {
            gxTv_SdtBR_MedicalImaging_Br_medicalimagingid_Z = value;
            SetDirty("Br_medicalimagingid_Z");
         }

      }

      public void gxTv_SdtBR_MedicalImaging_Br_medicalimagingid_Z_SetNull( )
      {
         gxTv_SdtBR_MedicalImaging_Br_medicalimagingid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtBR_MedicalImaging_Br_medicalimagingid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_EncounterID_Z" )]
      [  XmlElement( ElementName = "BR_EncounterID_Z"   )]
      public long gxTpr_Br_encounterid_Z
      {
         get {
            return gxTv_SdtBR_MedicalImaging_Br_encounterid_Z ;
         }

         set {
            gxTv_SdtBR_MedicalImaging_Br_encounterid_Z = value;
            SetDirty("Br_encounterid_Z");
         }

      }

      public void gxTv_SdtBR_MedicalImaging_Br_encounterid_Z_SetNull( )
      {
         gxTv_SdtBR_MedicalImaging_Br_encounterid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtBR_MedicalImaging_Br_encounterid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Information_PatientNo_Z" )]
      [  XmlElement( ElementName = "BR_Information_PatientNo_Z"   )]
      public String gxTpr_Br_information_patientno_Z
      {
         get {
            return gxTv_SdtBR_MedicalImaging_Br_information_patientno_Z ;
         }

         set {
            gxTv_SdtBR_MedicalImaging_Br_information_patientno_Z = value;
            SetDirty("Br_information_patientno_Z");
         }

      }

      public void gxTv_SdtBR_MedicalImaging_Br_information_patientno_Z_SetNull( )
      {
         gxTv_SdtBR_MedicalImaging_Br_information_patientno_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_MedicalImaging_Br_information_patientno_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_MedicalImaging_ID_Z" )]
      [  XmlElement( ElementName = "BR_MedicalImaging_ID_Z"   )]
      public long gxTpr_Br_medicalimaging_id_Z
      {
         get {
            return gxTv_SdtBR_MedicalImaging_Br_medicalimaging_id_Z ;
         }

         set {
            gxTv_SdtBR_MedicalImaging_Br_medicalimaging_id_Z = value;
            SetDirty("Br_medicalimaging_id_Z");
         }

      }

      public void gxTv_SdtBR_MedicalImaging_Br_medicalimaging_id_Z_SetNull( )
      {
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_id_Z = 0;
         return  ;
      }

      public bool gxTv_SdtBR_MedicalImaging_Br_medicalimaging_id_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_MedicalImaging_No_Z" )]
      [  XmlElement( ElementName = "BR_MedicalImaging_No_Z"   )]
      public long gxTpr_Br_medicalimaging_no_Z
      {
         get {
            return gxTv_SdtBR_MedicalImaging_Br_medicalimaging_no_Z ;
         }

         set {
            gxTv_SdtBR_MedicalImaging_Br_medicalimaging_no_Z = value;
            SetDirty("Br_medicalimaging_no_Z");
         }

      }

      public void gxTv_SdtBR_MedicalImaging_Br_medicalimaging_no_Z_SetNull( )
      {
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_no_Z = 0;
         return  ;
      }

      public bool gxTv_SdtBR_MedicalImaging_Br_medicalimaging_no_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_MedicalImaging_ImageName_Z" )]
      [  XmlElement( ElementName = "BR_MedicalImaging_ImageName_Z"   )]
      public String gxTpr_Br_medicalimaging_imagename_Z
      {
         get {
            return gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagename_Z ;
         }

         set {
            gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagename_Z = value;
            SetDirty("Br_medicalimaging_imagename_Z");
         }

      }

      public void gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagename_Z_SetNull( )
      {
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagename_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagename_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_MedicalImaging_ImageName_Code_Z" )]
      [  XmlElement( ElementName = "BR_MedicalImaging_ImageName_Code_Z"   )]
      public String gxTpr_Br_medicalimaging_imagename_code_Z
      {
         get {
            return gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagename_code_Z ;
         }

         set {
            gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagename_code_Z = value;
            SetDirty("Br_medicalimaging_imagename_code_Z");
         }

      }

      public void gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagename_code_Z_SetNull( )
      {
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagename_code_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagename_code_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_MedicalImaging_ImageDate_Z" )]
      [  XmlElement( ElementName = "BR_MedicalImaging_ImageDate_Z"  , IsNullable=true )]
      public string gxTpr_Br_medicalimaging_imagedate_Z_Nullable
      {
         get {
            if ( gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagedate_Z == DateTime.MinValue)
               return null;
            return new GxDateString(gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagedate_Z).value ;
         }

         set {
            if (String.IsNullOrEmpty(value) || value == GxDateString.NullValue )
               gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagedate_Z = DateTime.MinValue;
            else
               gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagedate_Z = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Br_medicalimaging_imagedate_Z
      {
         get {
            return gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagedate_Z ;
         }

         set {
            gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagedate_Z = value;
            SetDirty("Br_medicalimaging_imagedate_Z");
         }

      }

      public void gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagedate_Z_SetNull( )
      {
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagedate_Z = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagedate_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_MedicalImaging_ImageHosp_Z" )]
      [  XmlElement( ElementName = "BR_MedicalImaging_ImageHosp_Z"   )]
      public String gxTpr_Br_medicalimaging_imagehosp_Z
      {
         get {
            return gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagehosp_Z ;
         }

         set {
            gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagehosp_Z = value;
            SetDirty("Br_medicalimaging_imagehosp_Z");
         }

      }

      public void gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagehosp_Z_SetNull( )
      {
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagehosp_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagehosp_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_MedicalImaging_ImageHosp_Code_Z" )]
      [  XmlElement( ElementName = "BR_MedicalImaging_ImageHosp_Code_Z"   )]
      public String gxTpr_Br_medicalimaging_imagehosp_code_Z
      {
         get {
            return gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagehosp_code_Z ;
         }

         set {
            gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagehosp_code_Z = value;
            SetDirty("Br_medicalimaging_imagehosp_code_Z");
         }

      }

      public void gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagehosp_code_Z_SetNull( )
      {
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagehosp_code_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagehosp_code_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_MedicalImaging_ImageAge_Z" )]
      [  XmlElement( ElementName = "BR_MedicalImaging_ImageAge_Z"   )]
      public short gxTpr_Br_medicalimaging_imageage_Z
      {
         get {
            return gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageage_Z ;
         }

         set {
            gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageage_Z = value;
            SetDirty("Br_medicalimaging_imageage_Z");
         }

      }

      public void gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageage_Z_SetNull( )
      {
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageage_Z = 0;
         return  ;
      }

      public bool gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageage_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_MedicalImaging_ImageLoc_Z" )]
      [  XmlElement( ElementName = "BR_MedicalImaging_ImageLoc_Z"   )]
      public String gxTpr_Br_medicalimaging_imageloc_Z
      {
         get {
            return gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageloc_Z ;
         }

         set {
            gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageloc_Z = value;
            SetDirty("Br_medicalimaging_imageloc_Z");
         }

      }

      public void gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageloc_Z_SetNull( )
      {
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageloc_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageloc_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_MedicalImaging_ImageLoc_Code_Z" )]
      [  XmlElement( ElementName = "BR_MedicalImaging_ImageLoc_Code_Z"   )]
      public String gxTpr_Br_medicalimaging_imageloc_code_Z
      {
         get {
            return gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageloc_code_Z ;
         }

         set {
            gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageloc_code_Z = value;
            SetDirty("Br_medicalimaging_imageloc_code_Z");
         }

      }

      public void gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageloc_code_Z_SetNull( )
      {
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageloc_code_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageloc_code_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_MedicalImaging_ImageOrgan_Z" )]
      [  XmlElement( ElementName = "BR_MedicalImaging_ImageOrgan_Z"   )]
      public String gxTpr_Br_medicalimaging_imageorgan_Z
      {
         get {
            return gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageorgan_Z ;
         }

         set {
            gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageorgan_Z = value;
            SetDirty("Br_medicalimaging_imageorgan_Z");
         }

      }

      public void gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageorgan_Z_SetNull( )
      {
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageorgan_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageorgan_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_MedicalImaging_PreImageDiag_Z" )]
      [  XmlElement( ElementName = "BR_MedicalImaging_PreImageDiag_Z"   )]
      public String gxTpr_Br_medicalimaging_preimagediag_Z
      {
         get {
            return gxTv_SdtBR_MedicalImaging_Br_medicalimaging_preimagediag_Z ;
         }

         set {
            gxTv_SdtBR_MedicalImaging_Br_medicalimaging_preimagediag_Z = value;
            SetDirty("Br_medicalimaging_preimagediag_Z");
         }

      }

      public void gxTv_SdtBR_MedicalImaging_Br_medicalimaging_preimagediag_Z_SetNull( )
      {
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_preimagediag_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_MedicalImaging_Br_medicalimaging_preimagediag_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_MedicalImaging_ImageDes_Z" )]
      [  XmlElement( ElementName = "BR_MedicalImaging_ImageDes_Z"   )]
      public String gxTpr_Br_medicalimaging_imagedes_Z
      {
         get {
            return gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagedes_Z ;
         }

         set {
            gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagedes_Z = value;
            SetDirty("Br_medicalimaging_imagedes_Z");
         }

      }

      public void gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagedes_Z_SetNull( )
      {
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagedes_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagedes_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_MedicalImaging_TumorSize_Z" )]
      [  XmlElement( ElementName = "BR_MedicalImaging_TumorSize_Z"   )]
      public String gxTpr_Br_medicalimaging_tumorsize_Z
      {
         get {
            return gxTv_SdtBR_MedicalImaging_Br_medicalimaging_tumorsize_Z ;
         }

         set {
            gxTv_SdtBR_MedicalImaging_Br_medicalimaging_tumorsize_Z = value;
            SetDirty("Br_medicalimaging_tumorsize_Z");
         }

      }

      public void gxTv_SdtBR_MedicalImaging_Br_medicalimaging_tumorsize_Z_SetNull( )
      {
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_tumorsize_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_MedicalImaging_Br_medicalimaging_tumorsize_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_MedicalImaging_MetastasesDX_Z" )]
      [  XmlElement( ElementName = "BR_MedicalImaging_MetastasesDX_Z"   )]
      public String gxTpr_Br_medicalimaging_metastasesdx_Z
      {
         get {
            return gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metastasesdx_Z ;
         }

         set {
            gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metastasesdx_Z = value;
            SetDirty("Br_medicalimaging_metastasesdx_Z");
         }

      }

      public void gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metastasesdx_Z_SetNull( )
      {
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metastasesdx_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metastasesdx_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_MedicalImaging_MetaLoc_Z" )]
      [  XmlElement( ElementName = "BR_MedicalImaging_MetaLoc_Z"   )]
      public String gxTpr_Br_medicalimaging_metaloc_Z
      {
         get {
            return gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metaloc_Z ;
         }

         set {
            gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metaloc_Z = value;
            SetDirty("Br_medicalimaging_metaloc_Z");
         }

      }

      public void gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metaloc_Z_SetNull( )
      {
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metaloc_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metaloc_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_MedicalImaging_MetaDate_Z" )]
      [  XmlElement( ElementName = "BR_MedicalImaging_MetaDate_Z"  , IsNullable=true )]
      public string gxTpr_Br_medicalimaging_metadate_Z_Nullable
      {
         get {
            if ( gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metadate_Z == DateTime.MinValue)
               return null;
            return new GxDateString(gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metadate_Z).value ;
         }

         set {
            if (String.IsNullOrEmpty(value) || value == GxDateString.NullValue )
               gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metadate_Z = DateTime.MinValue;
            else
               gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metadate_Z = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Br_medicalimaging_metadate_Z
      {
         get {
            return gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metadate_Z ;
         }

         set {
            gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metadate_Z = value;
            SetDirty("Br_medicalimaging_metadate_Z");
         }

      }

      public void gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metadate_Z_SetNull( )
      {
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metadate_Z = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metadate_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_MedicalImagingID_N" )]
      [  XmlElement( ElementName = "BR_MedicalImagingID_N"   )]
      public short gxTpr_Br_medicalimagingid_N
      {
         get {
            return gxTv_SdtBR_MedicalImaging_Br_medicalimagingid_N ;
         }

         set {
            gxTv_SdtBR_MedicalImaging_Br_medicalimagingid_N = value;
            SetDirty("Br_medicalimagingid_N");
         }

      }

      public void gxTv_SdtBR_MedicalImaging_Br_medicalimagingid_N_SetNull( )
      {
         gxTv_SdtBR_MedicalImaging_Br_medicalimagingid_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_MedicalImaging_Br_medicalimagingid_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_EncounterID_N" )]
      [  XmlElement( ElementName = "BR_EncounterID_N"   )]
      public short gxTpr_Br_encounterid_N
      {
         get {
            return gxTv_SdtBR_MedicalImaging_Br_encounterid_N ;
         }

         set {
            gxTv_SdtBR_MedicalImaging_Br_encounterid_N = value;
            SetDirty("Br_encounterid_N");
         }

      }

      public void gxTv_SdtBR_MedicalImaging_Br_encounterid_N_SetNull( )
      {
         gxTv_SdtBR_MedicalImaging_Br_encounterid_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_MedicalImaging_Br_encounterid_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Information_PatientNo_N" )]
      [  XmlElement( ElementName = "BR_Information_PatientNo_N"   )]
      public short gxTpr_Br_information_patientno_N
      {
         get {
            return gxTv_SdtBR_MedicalImaging_Br_information_patientno_N ;
         }

         set {
            gxTv_SdtBR_MedicalImaging_Br_information_patientno_N = value;
            SetDirty("Br_information_patientno_N");
         }

      }

      public void gxTv_SdtBR_MedicalImaging_Br_information_patientno_N_SetNull( )
      {
         gxTv_SdtBR_MedicalImaging_Br_information_patientno_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_MedicalImaging_Br_information_patientno_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_MedicalImaging_ID_N" )]
      [  XmlElement( ElementName = "BR_MedicalImaging_ID_N"   )]
      public short gxTpr_Br_medicalimaging_id_N
      {
         get {
            return gxTv_SdtBR_MedicalImaging_Br_medicalimaging_id_N ;
         }

         set {
            gxTv_SdtBR_MedicalImaging_Br_medicalimaging_id_N = value;
            SetDirty("Br_medicalimaging_id_N");
         }

      }

      public void gxTv_SdtBR_MedicalImaging_Br_medicalimaging_id_N_SetNull( )
      {
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_id_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_MedicalImaging_Br_medicalimaging_id_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_MedicalImaging_No_N" )]
      [  XmlElement( ElementName = "BR_MedicalImaging_No_N"   )]
      public short gxTpr_Br_medicalimaging_no_N
      {
         get {
            return gxTv_SdtBR_MedicalImaging_Br_medicalimaging_no_N ;
         }

         set {
            gxTv_SdtBR_MedicalImaging_Br_medicalimaging_no_N = value;
            SetDirty("Br_medicalimaging_no_N");
         }

      }

      public void gxTv_SdtBR_MedicalImaging_Br_medicalimaging_no_N_SetNull( )
      {
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_no_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_MedicalImaging_Br_medicalimaging_no_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_MedicalImaging_ImageName_N" )]
      [  XmlElement( ElementName = "BR_MedicalImaging_ImageName_N"   )]
      public short gxTpr_Br_medicalimaging_imagename_N
      {
         get {
            return gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagename_N ;
         }

         set {
            gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagename_N = value;
            SetDirty("Br_medicalimaging_imagename_N");
         }

      }

      public void gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagename_N_SetNull( )
      {
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagename_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagename_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_MedicalImaging_ImageName_Code_N" )]
      [  XmlElement( ElementName = "BR_MedicalImaging_ImageName_Code_N"   )]
      public short gxTpr_Br_medicalimaging_imagename_code_N
      {
         get {
            return gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagename_code_N ;
         }

         set {
            gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagename_code_N = value;
            SetDirty("Br_medicalimaging_imagename_code_N");
         }

      }

      public void gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagename_code_N_SetNull( )
      {
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagename_code_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagename_code_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_MedicalImaging_ImageDate_N" )]
      [  XmlElement( ElementName = "BR_MedicalImaging_ImageDate_N"   )]
      public short gxTpr_Br_medicalimaging_imagedate_N
      {
         get {
            return gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagedate_N ;
         }

         set {
            gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagedate_N = value;
            SetDirty("Br_medicalimaging_imagedate_N");
         }

      }

      public void gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagedate_N_SetNull( )
      {
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagedate_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagedate_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_MedicalImaging_ImageHosp_N" )]
      [  XmlElement( ElementName = "BR_MedicalImaging_ImageHosp_N"   )]
      public short gxTpr_Br_medicalimaging_imagehosp_N
      {
         get {
            return gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagehosp_N ;
         }

         set {
            gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagehosp_N = value;
            SetDirty("Br_medicalimaging_imagehosp_N");
         }

      }

      public void gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagehosp_N_SetNull( )
      {
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagehosp_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagehosp_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_MedicalImaging_ImageHosp_Code_N" )]
      [  XmlElement( ElementName = "BR_MedicalImaging_ImageHosp_Code_N"   )]
      public short gxTpr_Br_medicalimaging_imagehosp_code_N
      {
         get {
            return gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagehosp_code_N ;
         }

         set {
            gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagehosp_code_N = value;
            SetDirty("Br_medicalimaging_imagehosp_code_N");
         }

      }

      public void gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagehosp_code_N_SetNull( )
      {
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagehosp_code_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagehosp_code_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_MedicalImaging_ImageAge_N" )]
      [  XmlElement( ElementName = "BR_MedicalImaging_ImageAge_N"   )]
      public short gxTpr_Br_medicalimaging_imageage_N
      {
         get {
            return gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageage_N ;
         }

         set {
            gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageage_N = value;
            SetDirty("Br_medicalimaging_imageage_N");
         }

      }

      public void gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageage_N_SetNull( )
      {
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageage_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageage_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_MedicalImaging_ImageLoc_N" )]
      [  XmlElement( ElementName = "BR_MedicalImaging_ImageLoc_N"   )]
      public short gxTpr_Br_medicalimaging_imageloc_N
      {
         get {
            return gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageloc_N ;
         }

         set {
            gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageloc_N = value;
            SetDirty("Br_medicalimaging_imageloc_N");
         }

      }

      public void gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageloc_N_SetNull( )
      {
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageloc_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageloc_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_MedicalImaging_ImageLoc_Code_N" )]
      [  XmlElement( ElementName = "BR_MedicalImaging_ImageLoc_Code_N"   )]
      public short gxTpr_Br_medicalimaging_imageloc_code_N
      {
         get {
            return gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageloc_code_N ;
         }

         set {
            gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageloc_code_N = value;
            SetDirty("Br_medicalimaging_imageloc_code_N");
         }

      }

      public void gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageloc_code_N_SetNull( )
      {
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageloc_code_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageloc_code_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_MedicalImaging_ImageOrgan_N" )]
      [  XmlElement( ElementName = "BR_MedicalImaging_ImageOrgan_N"   )]
      public short gxTpr_Br_medicalimaging_imageorgan_N
      {
         get {
            return gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageorgan_N ;
         }

         set {
            gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageorgan_N = value;
            SetDirty("Br_medicalimaging_imageorgan_N");
         }

      }

      public void gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageorgan_N_SetNull( )
      {
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageorgan_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageorgan_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_MedicalImaging_PreImageDiag_N" )]
      [  XmlElement( ElementName = "BR_MedicalImaging_PreImageDiag_N"   )]
      public short gxTpr_Br_medicalimaging_preimagediag_N
      {
         get {
            return gxTv_SdtBR_MedicalImaging_Br_medicalimaging_preimagediag_N ;
         }

         set {
            gxTv_SdtBR_MedicalImaging_Br_medicalimaging_preimagediag_N = value;
            SetDirty("Br_medicalimaging_preimagediag_N");
         }

      }

      public void gxTv_SdtBR_MedicalImaging_Br_medicalimaging_preimagediag_N_SetNull( )
      {
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_preimagediag_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_MedicalImaging_Br_medicalimaging_preimagediag_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_MedicalImaging_ImageDes_N" )]
      [  XmlElement( ElementName = "BR_MedicalImaging_ImageDes_N"   )]
      public short gxTpr_Br_medicalimaging_imagedes_N
      {
         get {
            return gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagedes_N ;
         }

         set {
            gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagedes_N = value;
            SetDirty("Br_medicalimaging_imagedes_N");
         }

      }

      public void gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagedes_N_SetNull( )
      {
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagedes_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagedes_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_MedicalImaging_TumorSize_N" )]
      [  XmlElement( ElementName = "BR_MedicalImaging_TumorSize_N"   )]
      public short gxTpr_Br_medicalimaging_tumorsize_N
      {
         get {
            return gxTv_SdtBR_MedicalImaging_Br_medicalimaging_tumorsize_N ;
         }

         set {
            gxTv_SdtBR_MedicalImaging_Br_medicalimaging_tumorsize_N = value;
            SetDirty("Br_medicalimaging_tumorsize_N");
         }

      }

      public void gxTv_SdtBR_MedicalImaging_Br_medicalimaging_tumorsize_N_SetNull( )
      {
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_tumorsize_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_MedicalImaging_Br_medicalimaging_tumorsize_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_MedicalImaging_ImageHtml_N" )]
      [  XmlElement( ElementName = "BR_MedicalImaging_ImageHtml_N"   )]
      public short gxTpr_Br_medicalimaging_imagehtml_N
      {
         get {
            return gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagehtml_N ;
         }

         set {
            gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagehtml_N = value;
            SetDirty("Br_medicalimaging_imagehtml_N");
         }

      }

      public void gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagehtml_N_SetNull( )
      {
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagehtml_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagehtml_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_MedicalImaging_MetastasesDX_N" )]
      [  XmlElement( ElementName = "BR_MedicalImaging_MetastasesDX_N"   )]
      public short gxTpr_Br_medicalimaging_metastasesdx_N
      {
         get {
            return gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metastasesdx_N ;
         }

         set {
            gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metastasesdx_N = value;
            SetDirty("Br_medicalimaging_metastasesdx_N");
         }

      }

      public void gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metastasesdx_N_SetNull( )
      {
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metastasesdx_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metastasesdx_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_MedicalImaging_MetaLoc_N" )]
      [  XmlElement( ElementName = "BR_MedicalImaging_MetaLoc_N"   )]
      public short gxTpr_Br_medicalimaging_metaloc_N
      {
         get {
            return gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metaloc_N ;
         }

         set {
            gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metaloc_N = value;
            SetDirty("Br_medicalimaging_metaloc_N");
         }

      }

      public void gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metaloc_N_SetNull( )
      {
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metaloc_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metaloc_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_MedicalImaging_MetaDate_N" )]
      [  XmlElement( ElementName = "BR_MedicalImaging_MetaDate_N"   )]
      public short gxTpr_Br_medicalimaging_metadate_N
      {
         get {
            return gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metadate_N ;
         }

         set {
            gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metadate_N = value;
            SetDirty("Br_medicalimaging_metadate_N");
         }

      }

      public void gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metadate_N_SetNull( )
      {
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metadate_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metadate_N_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_SdtBR_MedicalImaging_Br_information_patientno = "";
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagename = "";
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagename_code = "";
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagedate = DateTime.MinValue;
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagehosp = "";
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagehosp_code = "";
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageloc = "";
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageloc_code = "";
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageorgan = "";
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_preimagediag = "";
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagedes = "";
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_tumorsize = "";
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagehtml = "";
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metastasesdx = "";
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metaloc = "";
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metadate = DateTime.MinValue;
         gxTv_SdtBR_MedicalImaging_Mode = "";
         gxTv_SdtBR_MedicalImaging_Br_information_patientno_Z = "";
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagename_Z = "";
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagename_code_Z = "";
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagedate_Z = DateTime.MinValue;
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagehosp_Z = "";
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagehosp_code_Z = "";
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageloc_Z = "";
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageloc_code_Z = "";
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageorgan_Z = "";
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_preimagediag_Z = "";
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagedes_Z = "";
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_tumorsize_Z = "";
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metastasesdx_Z = "";
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metaloc_Z = "";
         gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metadate_Z = DateTime.MinValue;
         sDateCnv = "";
         sNumToPad = "";
         IGxSilentTrn obj ;
         obj = (IGxSilentTrn)ClassLoader.FindInstance( "br_medicalimaging", "GeneXus.Programs.br_medicalimaging_bc", new Object[] {context}, constructorCallingAssembly);;
         obj.initialize();
         obj.SetSDT(this, 1);
         setTransaction( obj) ;
         obj.SetMode("INS");
         return  ;
      }

      private short gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageage ;
      private short gxTv_SdtBR_MedicalImaging_Initialized ;
      private short gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageage_Z ;
      private short gxTv_SdtBR_MedicalImaging_Br_medicalimagingid_N ;
      private short gxTv_SdtBR_MedicalImaging_Br_encounterid_N ;
      private short gxTv_SdtBR_MedicalImaging_Br_information_patientno_N ;
      private short gxTv_SdtBR_MedicalImaging_Br_medicalimaging_id_N ;
      private short gxTv_SdtBR_MedicalImaging_Br_medicalimaging_no_N ;
      private short gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagename_N ;
      private short gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagename_code_N ;
      private short gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagedate_N ;
      private short gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagehosp_N ;
      private short gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagehosp_code_N ;
      private short gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageage_N ;
      private short gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageloc_N ;
      private short gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageloc_code_N ;
      private short gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageorgan_N ;
      private short gxTv_SdtBR_MedicalImaging_Br_medicalimaging_preimagediag_N ;
      private short gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagedes_N ;
      private short gxTv_SdtBR_MedicalImaging_Br_medicalimaging_tumorsize_N ;
      private short gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagehtml_N ;
      private short gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metastasesdx_N ;
      private short gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metaloc_N ;
      private short gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metadate_N ;
      private long gxTv_SdtBR_MedicalImaging_Br_medicalimagingid ;
      private long gxTv_SdtBR_MedicalImaging_Br_encounterid ;
      private long gxTv_SdtBR_MedicalImaging_Br_medicalimaging_id ;
      private long gxTv_SdtBR_MedicalImaging_Br_medicalimaging_no ;
      private long gxTv_SdtBR_MedicalImaging_Br_medicalimagingid_Z ;
      private long gxTv_SdtBR_MedicalImaging_Br_encounterid_Z ;
      private long gxTv_SdtBR_MedicalImaging_Br_medicalimaging_id_Z ;
      private long gxTv_SdtBR_MedicalImaging_Br_medicalimaging_no_Z ;
      private String gxTv_SdtBR_MedicalImaging_Mode ;
      private String sDateCnv ;
      private String sNumToPad ;
      private DateTime gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagedate ;
      private DateTime gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metadate ;
      private DateTime gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagedate_Z ;
      private DateTime gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metadate_Z ;
      private String gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagehtml ;
      private String gxTv_SdtBR_MedicalImaging_Br_information_patientno ;
      private String gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagename ;
      private String gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagename_code ;
      private String gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagehosp ;
      private String gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagehosp_code ;
      private String gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageloc ;
      private String gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageloc_code ;
      private String gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageorgan ;
      private String gxTv_SdtBR_MedicalImaging_Br_medicalimaging_preimagediag ;
      private String gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagedes ;
      private String gxTv_SdtBR_MedicalImaging_Br_medicalimaging_tumorsize ;
      private String gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metastasesdx ;
      private String gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metaloc ;
      private String gxTv_SdtBR_MedicalImaging_Br_information_patientno_Z ;
      private String gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagename_Z ;
      private String gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagename_code_Z ;
      private String gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagehosp_Z ;
      private String gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagehosp_code_Z ;
      private String gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageloc_Z ;
      private String gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageloc_code_Z ;
      private String gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imageorgan_Z ;
      private String gxTv_SdtBR_MedicalImaging_Br_medicalimaging_preimagediag_Z ;
      private String gxTv_SdtBR_MedicalImaging_Br_medicalimaging_imagedes_Z ;
      private String gxTv_SdtBR_MedicalImaging_Br_medicalimaging_tumorsize_Z ;
      private String gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metastasesdx_Z ;
      private String gxTv_SdtBR_MedicalImaging_Br_medicalimaging_metaloc_Z ;
   }

   [DataContract(Name = @"BR_MedicalImaging", Namespace = "DataAnalysisPlatform")]
   public class SdtBR_MedicalImaging_RESTInterface : GxGenericCollectionItem<SdtBR_MedicalImaging>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtBR_MedicalImaging_RESTInterface( ) : base()
      {
      }

      public SdtBR_MedicalImaging_RESTInterface( SdtBR_MedicalImaging psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "BR_MedicalImagingID" , Order = 0 )]
      [GxSeudo()]
      public String gxTpr_Br_medicalimagingid
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Br_medicalimagingid), 18, 0)) ;
         }

         set {
            sdt.gxTpr_Br_medicalimagingid = (long)(NumberUtil.Val( value, "."));
         }

      }

      [DataMember( Name = "BR_EncounterID" , Order = 1 )]
      [GxSeudo()]
      public String gxTpr_Br_encounterid
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Br_encounterid), 18, 0)) ;
         }

         set {
            sdt.gxTpr_Br_encounterid = (long)(NumberUtil.Val( value, "."));
         }

      }

      [DataMember( Name = "BR_Information_PatientNo" , Order = 2 )]
      [GxSeudo()]
      public String gxTpr_Br_information_patientno
      {
         get {
            return sdt.gxTpr_Br_information_patientno ;
         }

         set {
            sdt.gxTpr_Br_information_patientno = value;
         }

      }

      [DataMember( Name = "BR_MedicalImaging_ID" , Order = 3 )]
      [GxSeudo()]
      public String gxTpr_Br_medicalimaging_id
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Br_medicalimaging_id), 10, 0)) ;
         }

         set {
            sdt.gxTpr_Br_medicalimaging_id = (long)(NumberUtil.Val( value, "."));
         }

      }

      [DataMember( Name = "BR_MedicalImaging_No" , Order = 4 )]
      [GxSeudo()]
      public String gxTpr_Br_medicalimaging_no
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Br_medicalimaging_no), 18, 0)) ;
         }

         set {
            sdt.gxTpr_Br_medicalimaging_no = (long)(NumberUtil.Val( value, "."));
         }

      }

      [DataMember( Name = "BR_MedicalImaging_ImageName" , Order = 5 )]
      [GxSeudo()]
      public String gxTpr_Br_medicalimaging_imagename
      {
         get {
            return sdt.gxTpr_Br_medicalimaging_imagename ;
         }

         set {
            sdt.gxTpr_Br_medicalimaging_imagename = value;
         }

      }

      [DataMember( Name = "BR_MedicalImaging_ImageName_Code" , Order = 6 )]
      [GxSeudo()]
      public String gxTpr_Br_medicalimaging_imagename_code
      {
         get {
            return sdt.gxTpr_Br_medicalimaging_imagename_code ;
         }

         set {
            sdt.gxTpr_Br_medicalimaging_imagename_code = value;
         }

      }

      [DataMember( Name = "BR_MedicalImaging_ImageDate" , Order = 7 )]
      [GxSeudo()]
      public String gxTpr_Br_medicalimaging_imagedate
      {
         get {
            return DateTimeUtil.DToC2( sdt.gxTpr_Br_medicalimaging_imagedate) ;
         }

         set {
            sdt.gxTpr_Br_medicalimaging_imagedate = DateTimeUtil.CToD2( value);
         }

      }

      [DataMember( Name = "BR_MedicalImaging_ImageHosp" , Order = 8 )]
      [GxSeudo()]
      public String gxTpr_Br_medicalimaging_imagehosp
      {
         get {
            return sdt.gxTpr_Br_medicalimaging_imagehosp ;
         }

         set {
            sdt.gxTpr_Br_medicalimaging_imagehosp = value;
         }

      }

      [DataMember( Name = "BR_MedicalImaging_ImageHosp_Code" , Order = 9 )]
      [GxSeudo()]
      public String gxTpr_Br_medicalimaging_imagehosp_code
      {
         get {
            return sdt.gxTpr_Br_medicalimaging_imagehosp_code ;
         }

         set {
            sdt.gxTpr_Br_medicalimaging_imagehosp_code = value;
         }

      }

      [DataMember( Name = "BR_MedicalImaging_ImageAge" , Order = 10 )]
      [GxSeudo()]
      public Nullable<short> gxTpr_Br_medicalimaging_imageage
      {
         get {
            return sdt.gxTpr_Br_medicalimaging_imageage ;
         }

         set {
            sdt.gxTpr_Br_medicalimaging_imageage = (short)(value.HasValue ? value.Value : 0);
         }

      }

      [DataMember( Name = "BR_MedicalImaging_ImageLoc" , Order = 11 )]
      [GxSeudo()]
      public String gxTpr_Br_medicalimaging_imageloc
      {
         get {
            return sdt.gxTpr_Br_medicalimaging_imageloc ;
         }

         set {
            sdt.gxTpr_Br_medicalimaging_imageloc = value;
         }

      }

      [DataMember( Name = "BR_MedicalImaging_ImageLoc_Code" , Order = 12 )]
      [GxSeudo()]
      public String gxTpr_Br_medicalimaging_imageloc_code
      {
         get {
            return sdt.gxTpr_Br_medicalimaging_imageloc_code ;
         }

         set {
            sdt.gxTpr_Br_medicalimaging_imageloc_code = value;
         }

      }

      [DataMember( Name = "BR_MedicalImaging_ImageOrgan" , Order = 13 )]
      [GxSeudo()]
      public String gxTpr_Br_medicalimaging_imageorgan
      {
         get {
            return sdt.gxTpr_Br_medicalimaging_imageorgan ;
         }

         set {
            sdt.gxTpr_Br_medicalimaging_imageorgan = value;
         }

      }

      [DataMember( Name = "BR_MedicalImaging_PreImageDiag" , Order = 14 )]
      [GxSeudo()]
      public String gxTpr_Br_medicalimaging_preimagediag
      {
         get {
            return sdt.gxTpr_Br_medicalimaging_preimagediag ;
         }

         set {
            sdt.gxTpr_Br_medicalimaging_preimagediag = value;
         }

      }

      [DataMember( Name = "BR_MedicalImaging_ImageDes" , Order = 15 )]
      [GxSeudo()]
      public String gxTpr_Br_medicalimaging_imagedes
      {
         get {
            return sdt.gxTpr_Br_medicalimaging_imagedes ;
         }

         set {
            sdt.gxTpr_Br_medicalimaging_imagedes = value;
         }

      }

      [DataMember( Name = "BR_MedicalImaging_TumorSize" , Order = 16 )]
      [GxSeudo()]
      public String gxTpr_Br_medicalimaging_tumorsize
      {
         get {
            return sdt.gxTpr_Br_medicalimaging_tumorsize ;
         }

         set {
            sdt.gxTpr_Br_medicalimaging_tumorsize = value;
         }

      }

      [DataMember( Name = "BR_MedicalImaging_ImageHtml" , Order = 17 )]
      public String gxTpr_Br_medicalimaging_imagehtml
      {
         get {
            return sdt.gxTpr_Br_medicalimaging_imagehtml ;
         }

         set {
            sdt.gxTpr_Br_medicalimaging_imagehtml = value;
         }

      }

      [DataMember( Name = "BR_MedicalImaging_MetastasesDX" , Order = 18 )]
      [GxSeudo()]
      public String gxTpr_Br_medicalimaging_metastasesdx
      {
         get {
            return sdt.gxTpr_Br_medicalimaging_metastasesdx ;
         }

         set {
            sdt.gxTpr_Br_medicalimaging_metastasesdx = value;
         }

      }

      [DataMember( Name = "BR_MedicalImaging_MetaLoc" , Order = 19 )]
      [GxSeudo()]
      public String gxTpr_Br_medicalimaging_metaloc
      {
         get {
            return sdt.gxTpr_Br_medicalimaging_metaloc ;
         }

         set {
            sdt.gxTpr_Br_medicalimaging_metaloc = value;
         }

      }

      [DataMember( Name = "BR_MedicalImaging_MetaDate" , Order = 20 )]
      [GxSeudo()]
      public String gxTpr_Br_medicalimaging_metadate
      {
         get {
            return DateTimeUtil.DToC2( sdt.gxTpr_Br_medicalimaging_metadate) ;
         }

         set {
            sdt.gxTpr_Br_medicalimaging_metadate = DateTimeUtil.CToD2( value);
         }

      }

      public SdtBR_MedicalImaging sdt
      {
         get {
            return (SdtBR_MedicalImaging)Sdt ;
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
            sdt = new SdtBR_MedicalImaging() ;
         }
      }

      [DataMember( Name = "gx_md5_hash", Order = 21 )]
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
