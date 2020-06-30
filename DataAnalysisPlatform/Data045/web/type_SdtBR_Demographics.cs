/*
               File: type_SdtBR_Demographics
        Description: 人口信息学
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:6:44.33
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
   [XmlRoot(ElementName = "BR_Demographics" )]
   [XmlType(TypeName =  "BR_Demographics" , Namespace = "DataAnalysisPlatform" )]
   [Serializable]
   public class SdtBR_Demographics : GxSilentTrnSdt, System.Web.SessionState.IRequiresSessionState
   {
      public SdtBR_Demographics( )
      {
      }

      public SdtBR_Demographics( IGxContext context )
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

      public void Load( long AV61BR_Demographics_ID )
      {
         IGxSilentTrn obj ;
         obj = getTransaction();
         obj.LoadKey(new Object[] {(long)AV61BR_Demographics_ID});
         return  ;
      }

      public override Object[][] GetBCKey( )
      {
         return (Object[][])(new Object[][]{new Object[]{"BR_Demographics_ID", typeof(long)}}) ;
      }

      public override GXProperties GetMetadata( )
      {
         GXProperties metadata = new GXProperties() ;
         metadata.Set("Name", "BR_Demographics");
         metadata.Set("BT", "BR_Demographics");
         metadata.Set("PK", "[ \"BR_Demographics_ID\" ]");
         metadata.Set("PKAssigned", "[ \"BR_Demographics_ID\" ]");
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
         state.Add("gxTpr_Br_demographics_id_Z");
         state.Add("gxTpr_Br_encounterid_Z");
         state.Add("gxTpr_Br_information_patientno_Z");
         state.Add("gxTpr_Br_demographics_birthdate_Z_Nullable");
         state.Add("gxTpr_Br_demographics_sex_Z");
         state.Add("gxTpr_Br_demographics_sex_code_Z");
         state.Add("gxTpr_Br_demographics_marritalstatus_Z");
         state.Add("gxTpr_Br_demographics_marritalstatus_code_Z");
         state.Add("gxTpr_Br_demographics_ethnic_Z");
         state.Add("gxTpr_Br_demographics_ethnic_code_Z");
         state.Add("gxTpr_Br_demographics_education_Z");
         state.Add("gxTpr_Br_demographics_education_code_Z");
         state.Add("gxTpr_Br_demographics_occupation_Z");
         state.Add("gxTpr_Br_demographics_insurance_Z");
         state.Add("gxTpr_Br_demographics_insurance_code_Z");
         state.Add("gxTpr_Br_demographics_province_Z");
         state.Add("gxTpr_Br_demographics_city_Z");
         state.Add("gxTpr_Br_information_patientno_N");
         state.Add("gxTpr_Br_demographics_birthdate_N");
         state.Add("gxTpr_Br_demographics_sex_N");
         state.Add("gxTpr_Br_demographics_sex_code_N");
         state.Add("gxTpr_Br_demographics_marritalstatus_N");
         state.Add("gxTpr_Br_demographics_marritalstatus_code_N");
         state.Add("gxTpr_Br_demographics_ethnic_N");
         state.Add("gxTpr_Br_demographics_ethnic_code_N");
         state.Add("gxTpr_Br_demographics_education_N");
         state.Add("gxTpr_Br_demographics_education_code_N");
         state.Add("gxTpr_Br_demographics_occupation_N");
         state.Add("gxTpr_Br_demographics_insurance_N");
         state.Add("gxTpr_Br_demographics_insurance_code_N");
         state.Add("gxTpr_Br_demographics_province_N");
         state.Add("gxTpr_Br_demographics_city_N");
         return state ;
      }

      public override void Copy( GxUserType source )
      {
         SdtBR_Demographics sdt ;
         sdt = (SdtBR_Demographics)(source);
         gxTv_SdtBR_Demographics_Br_demographics_id = sdt.gxTv_SdtBR_Demographics_Br_demographics_id ;
         gxTv_SdtBR_Demographics_Br_encounterid = sdt.gxTv_SdtBR_Demographics_Br_encounterid ;
         gxTv_SdtBR_Demographics_Br_information_patientno = sdt.gxTv_SdtBR_Demographics_Br_information_patientno ;
         gxTv_SdtBR_Demographics_Br_demographics_birthdate = sdt.gxTv_SdtBR_Demographics_Br_demographics_birthdate ;
         gxTv_SdtBR_Demographics_Br_demographics_sex = sdt.gxTv_SdtBR_Demographics_Br_demographics_sex ;
         gxTv_SdtBR_Demographics_Br_demographics_sex_code = sdt.gxTv_SdtBR_Demographics_Br_demographics_sex_code ;
         gxTv_SdtBR_Demographics_Br_demographics_marritalstatus = sdt.gxTv_SdtBR_Demographics_Br_demographics_marritalstatus ;
         gxTv_SdtBR_Demographics_Br_demographics_marritalstatus_code = sdt.gxTv_SdtBR_Demographics_Br_demographics_marritalstatus_code ;
         gxTv_SdtBR_Demographics_Br_demographics_ethnic = sdt.gxTv_SdtBR_Demographics_Br_demographics_ethnic ;
         gxTv_SdtBR_Demographics_Br_demographics_ethnic_code = sdt.gxTv_SdtBR_Demographics_Br_demographics_ethnic_code ;
         gxTv_SdtBR_Demographics_Br_demographics_education = sdt.gxTv_SdtBR_Demographics_Br_demographics_education ;
         gxTv_SdtBR_Demographics_Br_demographics_education_code = sdt.gxTv_SdtBR_Demographics_Br_demographics_education_code ;
         gxTv_SdtBR_Demographics_Br_demographics_occupation = sdt.gxTv_SdtBR_Demographics_Br_demographics_occupation ;
         gxTv_SdtBR_Demographics_Br_demographics_insurance = sdt.gxTv_SdtBR_Demographics_Br_demographics_insurance ;
         gxTv_SdtBR_Demographics_Br_demographics_insurance_code = sdt.gxTv_SdtBR_Demographics_Br_demographics_insurance_code ;
         gxTv_SdtBR_Demographics_Br_demographics_province = sdt.gxTv_SdtBR_Demographics_Br_demographics_province ;
         gxTv_SdtBR_Demographics_Br_demographics_city = sdt.gxTv_SdtBR_Demographics_Br_demographics_city ;
         gxTv_SdtBR_Demographics_Mode = sdt.gxTv_SdtBR_Demographics_Mode ;
         gxTv_SdtBR_Demographics_Initialized = sdt.gxTv_SdtBR_Demographics_Initialized ;
         gxTv_SdtBR_Demographics_Br_demographics_id_Z = sdt.gxTv_SdtBR_Demographics_Br_demographics_id_Z ;
         gxTv_SdtBR_Demographics_Br_encounterid_Z = sdt.gxTv_SdtBR_Demographics_Br_encounterid_Z ;
         gxTv_SdtBR_Demographics_Br_information_patientno_Z = sdt.gxTv_SdtBR_Demographics_Br_information_patientno_Z ;
         gxTv_SdtBR_Demographics_Br_demographics_birthdate_Z = sdt.gxTv_SdtBR_Demographics_Br_demographics_birthdate_Z ;
         gxTv_SdtBR_Demographics_Br_demographics_sex_Z = sdt.gxTv_SdtBR_Demographics_Br_demographics_sex_Z ;
         gxTv_SdtBR_Demographics_Br_demographics_sex_code_Z = sdt.gxTv_SdtBR_Demographics_Br_demographics_sex_code_Z ;
         gxTv_SdtBR_Demographics_Br_demographics_marritalstatus_Z = sdt.gxTv_SdtBR_Demographics_Br_demographics_marritalstatus_Z ;
         gxTv_SdtBR_Demographics_Br_demographics_marritalstatus_code_Z = sdt.gxTv_SdtBR_Demographics_Br_demographics_marritalstatus_code_Z ;
         gxTv_SdtBR_Demographics_Br_demographics_ethnic_Z = sdt.gxTv_SdtBR_Demographics_Br_demographics_ethnic_Z ;
         gxTv_SdtBR_Demographics_Br_demographics_ethnic_code_Z = sdt.gxTv_SdtBR_Demographics_Br_demographics_ethnic_code_Z ;
         gxTv_SdtBR_Demographics_Br_demographics_education_Z = sdt.gxTv_SdtBR_Demographics_Br_demographics_education_Z ;
         gxTv_SdtBR_Demographics_Br_demographics_education_code_Z = sdt.gxTv_SdtBR_Demographics_Br_demographics_education_code_Z ;
         gxTv_SdtBR_Demographics_Br_demographics_occupation_Z = sdt.gxTv_SdtBR_Demographics_Br_demographics_occupation_Z ;
         gxTv_SdtBR_Demographics_Br_demographics_insurance_Z = sdt.gxTv_SdtBR_Demographics_Br_demographics_insurance_Z ;
         gxTv_SdtBR_Demographics_Br_demographics_insurance_code_Z = sdt.gxTv_SdtBR_Demographics_Br_demographics_insurance_code_Z ;
         gxTv_SdtBR_Demographics_Br_demographics_province_Z = sdt.gxTv_SdtBR_Demographics_Br_demographics_province_Z ;
         gxTv_SdtBR_Demographics_Br_demographics_city_Z = sdt.gxTv_SdtBR_Demographics_Br_demographics_city_Z ;
         gxTv_SdtBR_Demographics_Br_information_patientno_N = sdt.gxTv_SdtBR_Demographics_Br_information_patientno_N ;
         gxTv_SdtBR_Demographics_Br_demographics_birthdate_N = sdt.gxTv_SdtBR_Demographics_Br_demographics_birthdate_N ;
         gxTv_SdtBR_Demographics_Br_demographics_sex_N = sdt.gxTv_SdtBR_Demographics_Br_demographics_sex_N ;
         gxTv_SdtBR_Demographics_Br_demographics_sex_code_N = sdt.gxTv_SdtBR_Demographics_Br_demographics_sex_code_N ;
         gxTv_SdtBR_Demographics_Br_demographics_marritalstatus_N = sdt.gxTv_SdtBR_Demographics_Br_demographics_marritalstatus_N ;
         gxTv_SdtBR_Demographics_Br_demographics_marritalstatus_code_N = sdt.gxTv_SdtBR_Demographics_Br_demographics_marritalstatus_code_N ;
         gxTv_SdtBR_Demographics_Br_demographics_ethnic_N = sdt.gxTv_SdtBR_Demographics_Br_demographics_ethnic_N ;
         gxTv_SdtBR_Demographics_Br_demographics_ethnic_code_N = sdt.gxTv_SdtBR_Demographics_Br_demographics_ethnic_code_N ;
         gxTv_SdtBR_Demographics_Br_demographics_education_N = sdt.gxTv_SdtBR_Demographics_Br_demographics_education_N ;
         gxTv_SdtBR_Demographics_Br_demographics_education_code_N = sdt.gxTv_SdtBR_Demographics_Br_demographics_education_code_N ;
         gxTv_SdtBR_Demographics_Br_demographics_occupation_N = sdt.gxTv_SdtBR_Demographics_Br_demographics_occupation_N ;
         gxTv_SdtBR_Demographics_Br_demographics_insurance_N = sdt.gxTv_SdtBR_Demographics_Br_demographics_insurance_N ;
         gxTv_SdtBR_Demographics_Br_demographics_insurance_code_N = sdt.gxTv_SdtBR_Demographics_Br_demographics_insurance_code_N ;
         gxTv_SdtBR_Demographics_Br_demographics_province_N = sdt.gxTv_SdtBR_Demographics_Br_demographics_province_N ;
         gxTv_SdtBR_Demographics_Br_demographics_city_N = sdt.gxTv_SdtBR_Demographics_Br_demographics_city_N ;
         return  ;
      }

      public override void ToJSON( )
      {
         ToJSON( true) ;
         return  ;
      }

      public override void ToJSON( bool includeState )
      {
         AddObjectProperty("BR_Demographics_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_Demographics_Br_demographics_id), 18, 0)), false);
         AddObjectProperty("BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_Demographics_Br_encounterid), 18, 0)), false);
         AddObjectProperty("BR_Information_PatientNo", gxTv_SdtBR_Demographics_Br_information_patientno, false);
         AddObjectProperty("BR_Information_PatientNo_N", gxTv_SdtBR_Demographics_Br_information_patientno_N, false);
         sDateCnv = "";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_SdtBR_Demographics_Br_demographics_birthdate)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_SdtBR_Demographics_Br_demographics_birthdate)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_SdtBR_Demographics_Br_demographics_birthdate)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         AddObjectProperty("BR_Demographics_BirthDate", sDateCnv, false);
         AddObjectProperty("BR_Demographics_BirthDate_N", gxTv_SdtBR_Demographics_Br_demographics_birthdate_N, false);
         AddObjectProperty("BR_Demographics_Sex", gxTv_SdtBR_Demographics_Br_demographics_sex, false);
         AddObjectProperty("BR_Demographics_Sex_N", gxTv_SdtBR_Demographics_Br_demographics_sex_N, false);
         AddObjectProperty("BR_Demographics_Sex_Code", gxTv_SdtBR_Demographics_Br_demographics_sex_code, false);
         AddObjectProperty("BR_Demographics_Sex_Code_N", gxTv_SdtBR_Demographics_Br_demographics_sex_code_N, false);
         AddObjectProperty("BR_Demographics_MarritalStatus", gxTv_SdtBR_Demographics_Br_demographics_marritalstatus, false);
         AddObjectProperty("BR_Demographics_MarritalStatus_N", gxTv_SdtBR_Demographics_Br_demographics_marritalstatus_N, false);
         AddObjectProperty("BR_Demographics_MarritalStatus_Code", gxTv_SdtBR_Demographics_Br_demographics_marritalstatus_code, false);
         AddObjectProperty("BR_Demographics_MarritalStatus_Code_N", gxTv_SdtBR_Demographics_Br_demographics_marritalstatus_code_N, false);
         AddObjectProperty("BR_Demographics_Ethnic", gxTv_SdtBR_Demographics_Br_demographics_ethnic, false);
         AddObjectProperty("BR_Demographics_Ethnic_N", gxTv_SdtBR_Demographics_Br_demographics_ethnic_N, false);
         AddObjectProperty("BR_Demographics_Ethnic_Code", gxTv_SdtBR_Demographics_Br_demographics_ethnic_code, false);
         AddObjectProperty("BR_Demographics_Ethnic_Code_N", gxTv_SdtBR_Demographics_Br_demographics_ethnic_code_N, false);
         AddObjectProperty("BR_Demographics_Education", gxTv_SdtBR_Demographics_Br_demographics_education, false);
         AddObjectProperty("BR_Demographics_Education_N", gxTv_SdtBR_Demographics_Br_demographics_education_N, false);
         AddObjectProperty("BR_Demographics_Education_Code", gxTv_SdtBR_Demographics_Br_demographics_education_code, false);
         AddObjectProperty("BR_Demographics_Education_Code_N", gxTv_SdtBR_Demographics_Br_demographics_education_code_N, false);
         AddObjectProperty("BR_Demographics_Occupation", gxTv_SdtBR_Demographics_Br_demographics_occupation, false);
         AddObjectProperty("BR_Demographics_Occupation_N", gxTv_SdtBR_Demographics_Br_demographics_occupation_N, false);
         AddObjectProperty("BR_Demographics_Insurance", gxTv_SdtBR_Demographics_Br_demographics_insurance, false);
         AddObjectProperty("BR_Demographics_Insurance_N", gxTv_SdtBR_Demographics_Br_demographics_insurance_N, false);
         AddObjectProperty("BR_Demographics_Insurance_Code", gxTv_SdtBR_Demographics_Br_demographics_insurance_code, false);
         AddObjectProperty("BR_Demographics_Insurance_Code_N", gxTv_SdtBR_Demographics_Br_demographics_insurance_code_N, false);
         AddObjectProperty("BR_Demographics_Province", gxTv_SdtBR_Demographics_Br_demographics_province, false);
         AddObjectProperty("BR_Demographics_Province_N", gxTv_SdtBR_Demographics_Br_demographics_province_N, false);
         AddObjectProperty("BR_Demographics_City", gxTv_SdtBR_Demographics_Br_demographics_city, false);
         AddObjectProperty("BR_Demographics_City_N", gxTv_SdtBR_Demographics_Br_demographics_city_N, false);
         if ( includeState )
         {
            AddObjectProperty("Mode", gxTv_SdtBR_Demographics_Mode, false);
            AddObjectProperty("Initialized", gxTv_SdtBR_Demographics_Initialized, false);
            AddObjectProperty("BR_Demographics_ID_Z", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_Demographics_Br_demographics_id_Z), 18, 0)), false);
            AddObjectProperty("BR_EncounterID_Z", StringUtil.LTrim( StringUtil.Str( (decimal)(gxTv_SdtBR_Demographics_Br_encounterid_Z), 18, 0)), false);
            AddObjectProperty("BR_Information_PatientNo_Z", gxTv_SdtBR_Demographics_Br_information_patientno_Z, false);
            sDateCnv = "";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_SdtBR_Demographics_Br_demographics_birthdate_Z)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_SdtBR_Demographics_Br_demographics_birthdate_Z)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_SdtBR_Demographics_Br_demographics_birthdate_Z)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            AddObjectProperty("BR_Demographics_BirthDate_Z", sDateCnv, false);
            AddObjectProperty("BR_Demographics_Sex_Z", gxTv_SdtBR_Demographics_Br_demographics_sex_Z, false);
            AddObjectProperty("BR_Demographics_Sex_Code_Z", gxTv_SdtBR_Demographics_Br_demographics_sex_code_Z, false);
            AddObjectProperty("BR_Demographics_MarritalStatus_Z", gxTv_SdtBR_Demographics_Br_demographics_marritalstatus_Z, false);
            AddObjectProperty("BR_Demographics_MarritalStatus_Code_Z", gxTv_SdtBR_Demographics_Br_demographics_marritalstatus_code_Z, false);
            AddObjectProperty("BR_Demographics_Ethnic_Z", gxTv_SdtBR_Demographics_Br_demographics_ethnic_Z, false);
            AddObjectProperty("BR_Demographics_Ethnic_Code_Z", gxTv_SdtBR_Demographics_Br_demographics_ethnic_code_Z, false);
            AddObjectProperty("BR_Demographics_Education_Z", gxTv_SdtBR_Demographics_Br_demographics_education_Z, false);
            AddObjectProperty("BR_Demographics_Education_Code_Z", gxTv_SdtBR_Demographics_Br_demographics_education_code_Z, false);
            AddObjectProperty("BR_Demographics_Occupation_Z", gxTv_SdtBR_Demographics_Br_demographics_occupation_Z, false);
            AddObjectProperty("BR_Demographics_Insurance_Z", gxTv_SdtBR_Demographics_Br_demographics_insurance_Z, false);
            AddObjectProperty("BR_Demographics_Insurance_Code_Z", gxTv_SdtBR_Demographics_Br_demographics_insurance_code_Z, false);
            AddObjectProperty("BR_Demographics_Province_Z", gxTv_SdtBR_Demographics_Br_demographics_province_Z, false);
            AddObjectProperty("BR_Demographics_City_Z", gxTv_SdtBR_Demographics_Br_demographics_city_Z, false);
            AddObjectProperty("BR_Information_PatientNo_N", gxTv_SdtBR_Demographics_Br_information_patientno_N, false);
            AddObjectProperty("BR_Demographics_BirthDate_N", gxTv_SdtBR_Demographics_Br_demographics_birthdate_N, false);
            AddObjectProperty("BR_Demographics_Sex_N", gxTv_SdtBR_Demographics_Br_demographics_sex_N, false);
            AddObjectProperty("BR_Demographics_Sex_Code_N", gxTv_SdtBR_Demographics_Br_demographics_sex_code_N, false);
            AddObjectProperty("BR_Demographics_MarritalStatus_N", gxTv_SdtBR_Demographics_Br_demographics_marritalstatus_N, false);
            AddObjectProperty("BR_Demographics_MarritalStatus_Code_N", gxTv_SdtBR_Demographics_Br_demographics_marritalstatus_code_N, false);
            AddObjectProperty("BR_Demographics_Ethnic_N", gxTv_SdtBR_Demographics_Br_demographics_ethnic_N, false);
            AddObjectProperty("BR_Demographics_Ethnic_Code_N", gxTv_SdtBR_Demographics_Br_demographics_ethnic_code_N, false);
            AddObjectProperty("BR_Demographics_Education_N", gxTv_SdtBR_Demographics_Br_demographics_education_N, false);
            AddObjectProperty("BR_Demographics_Education_Code_N", gxTv_SdtBR_Demographics_Br_demographics_education_code_N, false);
            AddObjectProperty("BR_Demographics_Occupation_N", gxTv_SdtBR_Demographics_Br_demographics_occupation_N, false);
            AddObjectProperty("BR_Demographics_Insurance_N", gxTv_SdtBR_Demographics_Br_demographics_insurance_N, false);
            AddObjectProperty("BR_Demographics_Insurance_Code_N", gxTv_SdtBR_Demographics_Br_demographics_insurance_code_N, false);
            AddObjectProperty("BR_Demographics_Province_N", gxTv_SdtBR_Demographics_Br_demographics_province_N, false);
            AddObjectProperty("BR_Demographics_City_N", gxTv_SdtBR_Demographics_Br_demographics_city_N, false);
         }
         return  ;
      }

      public void UpdateDirties( SdtBR_Demographics sdt )
      {
         if ( sdt.IsDirty("BR_Demographics_ID") )
         {
            gxTv_SdtBR_Demographics_Br_demographics_id = sdt.gxTv_SdtBR_Demographics_Br_demographics_id ;
         }
         if ( sdt.IsDirty("BR_EncounterID") )
         {
            gxTv_SdtBR_Demographics_Br_encounterid = sdt.gxTv_SdtBR_Demographics_Br_encounterid ;
         }
         if ( sdt.IsDirty("BR_Information_PatientNo") )
         {
            gxTv_SdtBR_Demographics_Br_information_patientno = sdt.gxTv_SdtBR_Demographics_Br_information_patientno ;
         }
         if ( sdt.IsDirty("BR_Demographics_BirthDate") )
         {
            gxTv_SdtBR_Demographics_Br_demographics_birthdate = sdt.gxTv_SdtBR_Demographics_Br_demographics_birthdate ;
         }
         if ( sdt.IsDirty("BR_Demographics_Sex") )
         {
            gxTv_SdtBR_Demographics_Br_demographics_sex = sdt.gxTv_SdtBR_Demographics_Br_demographics_sex ;
         }
         if ( sdt.IsDirty("BR_Demographics_Sex_Code") )
         {
            gxTv_SdtBR_Demographics_Br_demographics_sex_code = sdt.gxTv_SdtBR_Demographics_Br_demographics_sex_code ;
         }
         if ( sdt.IsDirty("BR_Demographics_MarritalStatus") )
         {
            gxTv_SdtBR_Demographics_Br_demographics_marritalstatus = sdt.gxTv_SdtBR_Demographics_Br_demographics_marritalstatus ;
         }
         if ( sdt.IsDirty("BR_Demographics_MarritalStatus_Code") )
         {
            gxTv_SdtBR_Demographics_Br_demographics_marritalstatus_code = sdt.gxTv_SdtBR_Demographics_Br_demographics_marritalstatus_code ;
         }
         if ( sdt.IsDirty("BR_Demographics_Ethnic") )
         {
            gxTv_SdtBR_Demographics_Br_demographics_ethnic = sdt.gxTv_SdtBR_Demographics_Br_demographics_ethnic ;
         }
         if ( sdt.IsDirty("BR_Demographics_Ethnic_Code") )
         {
            gxTv_SdtBR_Demographics_Br_demographics_ethnic_code = sdt.gxTv_SdtBR_Demographics_Br_demographics_ethnic_code ;
         }
         if ( sdt.IsDirty("BR_Demographics_Education") )
         {
            gxTv_SdtBR_Demographics_Br_demographics_education = sdt.gxTv_SdtBR_Demographics_Br_demographics_education ;
         }
         if ( sdt.IsDirty("BR_Demographics_Education_Code") )
         {
            gxTv_SdtBR_Demographics_Br_demographics_education_code = sdt.gxTv_SdtBR_Demographics_Br_demographics_education_code ;
         }
         if ( sdt.IsDirty("BR_Demographics_Occupation") )
         {
            gxTv_SdtBR_Demographics_Br_demographics_occupation = sdt.gxTv_SdtBR_Demographics_Br_demographics_occupation ;
         }
         if ( sdt.IsDirty("BR_Demographics_Insurance") )
         {
            gxTv_SdtBR_Demographics_Br_demographics_insurance = sdt.gxTv_SdtBR_Demographics_Br_demographics_insurance ;
         }
         if ( sdt.IsDirty("BR_Demographics_Insurance_Code") )
         {
            gxTv_SdtBR_Demographics_Br_demographics_insurance_code = sdt.gxTv_SdtBR_Demographics_Br_demographics_insurance_code ;
         }
         if ( sdt.IsDirty("BR_Demographics_Province") )
         {
            gxTv_SdtBR_Demographics_Br_demographics_province = sdt.gxTv_SdtBR_Demographics_Br_demographics_province ;
         }
         if ( sdt.IsDirty("BR_Demographics_City") )
         {
            gxTv_SdtBR_Demographics_Br_demographics_city = sdt.gxTv_SdtBR_Demographics_Br_demographics_city ;
         }
         return  ;
      }

      [  SoapElement( ElementName = "BR_Demographics_ID" )]
      [  XmlElement( ElementName = "BR_Demographics_ID"   )]
      public long gxTpr_Br_demographics_id
      {
         get {
            return gxTv_SdtBR_Demographics_Br_demographics_id ;
         }

         set {
            if ( gxTv_SdtBR_Demographics_Br_demographics_id != value )
            {
               gxTv_SdtBR_Demographics_Mode = "INS";
               this.gxTv_SdtBR_Demographics_Br_demographics_id_Z_SetNull( );
               this.gxTv_SdtBR_Demographics_Br_encounterid_Z_SetNull( );
               this.gxTv_SdtBR_Demographics_Br_information_patientno_Z_SetNull( );
               this.gxTv_SdtBR_Demographics_Br_demographics_birthdate_Z_SetNull( );
               this.gxTv_SdtBR_Demographics_Br_demographics_sex_Z_SetNull( );
               this.gxTv_SdtBR_Demographics_Br_demographics_sex_code_Z_SetNull( );
               this.gxTv_SdtBR_Demographics_Br_demographics_marritalstatus_Z_SetNull( );
               this.gxTv_SdtBR_Demographics_Br_demographics_marritalstatus_code_Z_SetNull( );
               this.gxTv_SdtBR_Demographics_Br_demographics_ethnic_Z_SetNull( );
               this.gxTv_SdtBR_Demographics_Br_demographics_ethnic_code_Z_SetNull( );
               this.gxTv_SdtBR_Demographics_Br_demographics_education_Z_SetNull( );
               this.gxTv_SdtBR_Demographics_Br_demographics_education_code_Z_SetNull( );
               this.gxTv_SdtBR_Demographics_Br_demographics_occupation_Z_SetNull( );
               this.gxTv_SdtBR_Demographics_Br_demographics_insurance_Z_SetNull( );
               this.gxTv_SdtBR_Demographics_Br_demographics_insurance_code_Z_SetNull( );
               this.gxTv_SdtBR_Demographics_Br_demographics_province_Z_SetNull( );
               this.gxTv_SdtBR_Demographics_Br_demographics_city_Z_SetNull( );
            }
            gxTv_SdtBR_Demographics_Br_demographics_id = value;
            SetDirty("Br_demographics_id");
         }

      }

      [  SoapElement( ElementName = "BR_EncounterID" )]
      [  XmlElement( ElementName = "BR_EncounterID"   )]
      public long gxTpr_Br_encounterid
      {
         get {
            return gxTv_SdtBR_Demographics_Br_encounterid ;
         }

         set {
            gxTv_SdtBR_Demographics_Br_encounterid = value;
            SetDirty("Br_encounterid");
         }

      }

      [  SoapElement( ElementName = "BR_Information_PatientNo" )]
      [  XmlElement( ElementName = "BR_Information_PatientNo"   )]
      public String gxTpr_Br_information_patientno
      {
         get {
            return gxTv_SdtBR_Demographics_Br_information_patientno ;
         }

         set {
            gxTv_SdtBR_Demographics_Br_information_patientno_N = 0;
            gxTv_SdtBR_Demographics_Br_information_patientno = value;
            SetDirty("Br_information_patientno");
         }

      }

      public void gxTv_SdtBR_Demographics_Br_information_patientno_SetNull( )
      {
         gxTv_SdtBR_Demographics_Br_information_patientno_N = 1;
         gxTv_SdtBR_Demographics_Br_information_patientno = "";
         return  ;
      }

      public bool gxTv_SdtBR_Demographics_Br_information_patientno_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Demographics_BirthDate" )]
      [  XmlElement( ElementName = "BR_Demographics_BirthDate"  , IsNullable=true )]
      public string gxTpr_Br_demographics_birthdate_Nullable
      {
         get {
            if ( gxTv_SdtBR_Demographics_Br_demographics_birthdate == DateTime.MinValue)
               return null;
            return new GxDateString(gxTv_SdtBR_Demographics_Br_demographics_birthdate).value ;
         }

         set {
            gxTv_SdtBR_Demographics_Br_demographics_birthdate_N = 0;
            if (String.IsNullOrEmpty(value) || value == GxDateString.NullValue )
               gxTv_SdtBR_Demographics_Br_demographics_birthdate = DateTime.MinValue;
            else
               gxTv_SdtBR_Demographics_Br_demographics_birthdate = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Br_demographics_birthdate
      {
         get {
            return gxTv_SdtBR_Demographics_Br_demographics_birthdate ;
         }

         set {
            gxTv_SdtBR_Demographics_Br_demographics_birthdate_N = 0;
            gxTv_SdtBR_Demographics_Br_demographics_birthdate = value;
            SetDirty("Br_demographics_birthdate");
         }

      }

      public void gxTv_SdtBR_Demographics_Br_demographics_birthdate_SetNull( )
      {
         gxTv_SdtBR_Demographics_Br_demographics_birthdate_N = 1;
         gxTv_SdtBR_Demographics_Br_demographics_birthdate = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_SdtBR_Demographics_Br_demographics_birthdate_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Demographics_Sex" )]
      [  XmlElement( ElementName = "BR_Demographics_Sex"   )]
      public String gxTpr_Br_demographics_sex
      {
         get {
            return gxTv_SdtBR_Demographics_Br_demographics_sex ;
         }

         set {
            gxTv_SdtBR_Demographics_Br_demographics_sex_N = 0;
            gxTv_SdtBR_Demographics_Br_demographics_sex = value;
            SetDirty("Br_demographics_sex");
         }

      }

      public void gxTv_SdtBR_Demographics_Br_demographics_sex_SetNull( )
      {
         gxTv_SdtBR_Demographics_Br_demographics_sex_N = 1;
         gxTv_SdtBR_Demographics_Br_demographics_sex = "";
         return  ;
      }

      public bool gxTv_SdtBR_Demographics_Br_demographics_sex_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Demographics_Sex_Code" )]
      [  XmlElement( ElementName = "BR_Demographics_Sex_Code"   )]
      public String gxTpr_Br_demographics_sex_code
      {
         get {
            return gxTv_SdtBR_Demographics_Br_demographics_sex_code ;
         }

         set {
            gxTv_SdtBR_Demographics_Br_demographics_sex_code_N = 0;
            gxTv_SdtBR_Demographics_Br_demographics_sex_code = value;
            SetDirty("Br_demographics_sex_code");
         }

      }

      public void gxTv_SdtBR_Demographics_Br_demographics_sex_code_SetNull( )
      {
         gxTv_SdtBR_Demographics_Br_demographics_sex_code_N = 1;
         gxTv_SdtBR_Demographics_Br_demographics_sex_code = "";
         return  ;
      }

      public bool gxTv_SdtBR_Demographics_Br_demographics_sex_code_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Demographics_MarritalStatus" )]
      [  XmlElement( ElementName = "BR_Demographics_MarritalStatus"   )]
      public String gxTpr_Br_demographics_marritalstatus
      {
         get {
            return gxTv_SdtBR_Demographics_Br_demographics_marritalstatus ;
         }

         set {
            gxTv_SdtBR_Demographics_Br_demographics_marritalstatus_N = 0;
            gxTv_SdtBR_Demographics_Br_demographics_marritalstatus = value;
            SetDirty("Br_demographics_marritalstatus");
         }

      }

      public void gxTv_SdtBR_Demographics_Br_demographics_marritalstatus_SetNull( )
      {
         gxTv_SdtBR_Demographics_Br_demographics_marritalstatus_N = 1;
         gxTv_SdtBR_Demographics_Br_demographics_marritalstatus = "";
         return  ;
      }

      public bool gxTv_SdtBR_Demographics_Br_demographics_marritalstatus_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Demographics_MarritalStatus_Code" )]
      [  XmlElement( ElementName = "BR_Demographics_MarritalStatus_Code"   )]
      public String gxTpr_Br_demographics_marritalstatus_code
      {
         get {
            return gxTv_SdtBR_Demographics_Br_demographics_marritalstatus_code ;
         }

         set {
            gxTv_SdtBR_Demographics_Br_demographics_marritalstatus_code_N = 0;
            gxTv_SdtBR_Demographics_Br_demographics_marritalstatus_code = value;
            SetDirty("Br_demographics_marritalstatus_code");
         }

      }

      public void gxTv_SdtBR_Demographics_Br_demographics_marritalstatus_code_SetNull( )
      {
         gxTv_SdtBR_Demographics_Br_demographics_marritalstatus_code_N = 1;
         gxTv_SdtBR_Demographics_Br_demographics_marritalstatus_code = "";
         return  ;
      }

      public bool gxTv_SdtBR_Demographics_Br_demographics_marritalstatus_code_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Demographics_Ethnic" )]
      [  XmlElement( ElementName = "BR_Demographics_Ethnic"   )]
      public String gxTpr_Br_demographics_ethnic
      {
         get {
            return gxTv_SdtBR_Demographics_Br_demographics_ethnic ;
         }

         set {
            gxTv_SdtBR_Demographics_Br_demographics_ethnic_N = 0;
            gxTv_SdtBR_Demographics_Br_demographics_ethnic = value;
            SetDirty("Br_demographics_ethnic");
         }

      }

      public void gxTv_SdtBR_Demographics_Br_demographics_ethnic_SetNull( )
      {
         gxTv_SdtBR_Demographics_Br_demographics_ethnic_N = 1;
         gxTv_SdtBR_Demographics_Br_demographics_ethnic = "";
         return  ;
      }

      public bool gxTv_SdtBR_Demographics_Br_demographics_ethnic_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Demographics_Ethnic_Code" )]
      [  XmlElement( ElementName = "BR_Demographics_Ethnic_Code"   )]
      public String gxTpr_Br_demographics_ethnic_code
      {
         get {
            return gxTv_SdtBR_Demographics_Br_demographics_ethnic_code ;
         }

         set {
            gxTv_SdtBR_Demographics_Br_demographics_ethnic_code_N = 0;
            gxTv_SdtBR_Demographics_Br_demographics_ethnic_code = value;
            SetDirty("Br_demographics_ethnic_code");
         }

      }

      public void gxTv_SdtBR_Demographics_Br_demographics_ethnic_code_SetNull( )
      {
         gxTv_SdtBR_Demographics_Br_demographics_ethnic_code_N = 1;
         gxTv_SdtBR_Demographics_Br_demographics_ethnic_code = "";
         return  ;
      }

      public bool gxTv_SdtBR_Demographics_Br_demographics_ethnic_code_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Demographics_Education" )]
      [  XmlElement( ElementName = "BR_Demographics_Education"   )]
      public String gxTpr_Br_demographics_education
      {
         get {
            return gxTv_SdtBR_Demographics_Br_demographics_education ;
         }

         set {
            gxTv_SdtBR_Demographics_Br_demographics_education_N = 0;
            gxTv_SdtBR_Demographics_Br_demographics_education = value;
            SetDirty("Br_demographics_education");
         }

      }

      public void gxTv_SdtBR_Demographics_Br_demographics_education_SetNull( )
      {
         gxTv_SdtBR_Demographics_Br_demographics_education_N = 1;
         gxTv_SdtBR_Demographics_Br_demographics_education = "";
         return  ;
      }

      public bool gxTv_SdtBR_Demographics_Br_demographics_education_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Demographics_Education_Code" )]
      [  XmlElement( ElementName = "BR_Demographics_Education_Code"   )]
      public String gxTpr_Br_demographics_education_code
      {
         get {
            return gxTv_SdtBR_Demographics_Br_demographics_education_code ;
         }

         set {
            gxTv_SdtBR_Demographics_Br_demographics_education_code_N = 0;
            gxTv_SdtBR_Demographics_Br_demographics_education_code = value;
            SetDirty("Br_demographics_education_code");
         }

      }

      public void gxTv_SdtBR_Demographics_Br_demographics_education_code_SetNull( )
      {
         gxTv_SdtBR_Demographics_Br_demographics_education_code_N = 1;
         gxTv_SdtBR_Demographics_Br_demographics_education_code = "";
         return  ;
      }

      public bool gxTv_SdtBR_Demographics_Br_demographics_education_code_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Demographics_Occupation" )]
      [  XmlElement( ElementName = "BR_Demographics_Occupation"   )]
      public String gxTpr_Br_demographics_occupation
      {
         get {
            return gxTv_SdtBR_Demographics_Br_demographics_occupation ;
         }

         set {
            gxTv_SdtBR_Demographics_Br_demographics_occupation_N = 0;
            gxTv_SdtBR_Demographics_Br_demographics_occupation = value;
            SetDirty("Br_demographics_occupation");
         }

      }

      public void gxTv_SdtBR_Demographics_Br_demographics_occupation_SetNull( )
      {
         gxTv_SdtBR_Demographics_Br_demographics_occupation_N = 1;
         gxTv_SdtBR_Demographics_Br_demographics_occupation = "";
         return  ;
      }

      public bool gxTv_SdtBR_Demographics_Br_demographics_occupation_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Demographics_Insurance" )]
      [  XmlElement( ElementName = "BR_Demographics_Insurance"   )]
      public String gxTpr_Br_demographics_insurance
      {
         get {
            return gxTv_SdtBR_Demographics_Br_demographics_insurance ;
         }

         set {
            gxTv_SdtBR_Demographics_Br_demographics_insurance_N = 0;
            gxTv_SdtBR_Demographics_Br_demographics_insurance = value;
            SetDirty("Br_demographics_insurance");
         }

      }

      public void gxTv_SdtBR_Demographics_Br_demographics_insurance_SetNull( )
      {
         gxTv_SdtBR_Demographics_Br_demographics_insurance_N = 1;
         gxTv_SdtBR_Demographics_Br_demographics_insurance = "";
         return  ;
      }

      public bool gxTv_SdtBR_Demographics_Br_demographics_insurance_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Demographics_Insurance_Code" )]
      [  XmlElement( ElementName = "BR_Demographics_Insurance_Code"   )]
      public String gxTpr_Br_demographics_insurance_code
      {
         get {
            return gxTv_SdtBR_Demographics_Br_demographics_insurance_code ;
         }

         set {
            gxTv_SdtBR_Demographics_Br_demographics_insurance_code_N = 0;
            gxTv_SdtBR_Demographics_Br_demographics_insurance_code = value;
            SetDirty("Br_demographics_insurance_code");
         }

      }

      public void gxTv_SdtBR_Demographics_Br_demographics_insurance_code_SetNull( )
      {
         gxTv_SdtBR_Demographics_Br_demographics_insurance_code_N = 1;
         gxTv_SdtBR_Demographics_Br_demographics_insurance_code = "";
         return  ;
      }

      public bool gxTv_SdtBR_Demographics_Br_demographics_insurance_code_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Demographics_Province" )]
      [  XmlElement( ElementName = "BR_Demographics_Province"   )]
      public String gxTpr_Br_demographics_province
      {
         get {
            return gxTv_SdtBR_Demographics_Br_demographics_province ;
         }

         set {
            gxTv_SdtBR_Demographics_Br_demographics_province_N = 0;
            gxTv_SdtBR_Demographics_Br_demographics_province = value;
            SetDirty("Br_demographics_province");
         }

      }

      public void gxTv_SdtBR_Demographics_Br_demographics_province_SetNull( )
      {
         gxTv_SdtBR_Demographics_Br_demographics_province_N = 1;
         gxTv_SdtBR_Demographics_Br_demographics_province = "";
         return  ;
      }

      public bool gxTv_SdtBR_Demographics_Br_demographics_province_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Demographics_City" )]
      [  XmlElement( ElementName = "BR_Demographics_City"   )]
      public String gxTpr_Br_demographics_city
      {
         get {
            return gxTv_SdtBR_Demographics_Br_demographics_city ;
         }

         set {
            gxTv_SdtBR_Demographics_Br_demographics_city_N = 0;
            gxTv_SdtBR_Demographics_Br_demographics_city = value;
            SetDirty("Br_demographics_city");
         }

      }

      public void gxTv_SdtBR_Demographics_Br_demographics_city_SetNull( )
      {
         gxTv_SdtBR_Demographics_Br_demographics_city_N = 1;
         gxTv_SdtBR_Demographics_Br_demographics_city = "";
         return  ;
      }

      public bool gxTv_SdtBR_Demographics_Br_demographics_city_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Mode" )]
      [  XmlElement( ElementName = "Mode"   )]
      public String gxTpr_Mode
      {
         get {
            return gxTv_SdtBR_Demographics_Mode ;
         }

         set {
            gxTv_SdtBR_Demographics_Mode = value;
            SetDirty("Mode");
         }

      }

      public void gxTv_SdtBR_Demographics_Mode_SetNull( )
      {
         gxTv_SdtBR_Demographics_Mode = "";
         return  ;
      }

      public bool gxTv_SdtBR_Demographics_Mode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Initialized" )]
      [  XmlElement( ElementName = "Initialized"   )]
      public short gxTpr_Initialized
      {
         get {
            return gxTv_SdtBR_Demographics_Initialized ;
         }

         set {
            gxTv_SdtBR_Demographics_Initialized = value;
            SetDirty("Initialized");
         }

      }

      public void gxTv_SdtBR_Demographics_Initialized_SetNull( )
      {
         gxTv_SdtBR_Demographics_Initialized = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Demographics_Initialized_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Demographics_ID_Z" )]
      [  XmlElement( ElementName = "BR_Demographics_ID_Z"   )]
      public long gxTpr_Br_demographics_id_Z
      {
         get {
            return gxTv_SdtBR_Demographics_Br_demographics_id_Z ;
         }

         set {
            gxTv_SdtBR_Demographics_Br_demographics_id_Z = value;
            SetDirty("Br_demographics_id_Z");
         }

      }

      public void gxTv_SdtBR_Demographics_Br_demographics_id_Z_SetNull( )
      {
         gxTv_SdtBR_Demographics_Br_demographics_id_Z = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Demographics_Br_demographics_id_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_EncounterID_Z" )]
      [  XmlElement( ElementName = "BR_EncounterID_Z"   )]
      public long gxTpr_Br_encounterid_Z
      {
         get {
            return gxTv_SdtBR_Demographics_Br_encounterid_Z ;
         }

         set {
            gxTv_SdtBR_Demographics_Br_encounterid_Z = value;
            SetDirty("Br_encounterid_Z");
         }

      }

      public void gxTv_SdtBR_Demographics_Br_encounterid_Z_SetNull( )
      {
         gxTv_SdtBR_Demographics_Br_encounterid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Demographics_Br_encounterid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Information_PatientNo_Z" )]
      [  XmlElement( ElementName = "BR_Information_PatientNo_Z"   )]
      public String gxTpr_Br_information_patientno_Z
      {
         get {
            return gxTv_SdtBR_Demographics_Br_information_patientno_Z ;
         }

         set {
            gxTv_SdtBR_Demographics_Br_information_patientno_Z = value;
            SetDirty("Br_information_patientno_Z");
         }

      }

      public void gxTv_SdtBR_Demographics_Br_information_patientno_Z_SetNull( )
      {
         gxTv_SdtBR_Demographics_Br_information_patientno_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Demographics_Br_information_patientno_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Demographics_BirthDate_Z" )]
      [  XmlElement( ElementName = "BR_Demographics_BirthDate_Z"  , IsNullable=true )]
      public string gxTpr_Br_demographics_birthdate_Z_Nullable
      {
         get {
            if ( gxTv_SdtBR_Demographics_Br_demographics_birthdate_Z == DateTime.MinValue)
               return null;
            return new GxDateString(gxTv_SdtBR_Demographics_Br_demographics_birthdate_Z).value ;
         }

         set {
            if (String.IsNullOrEmpty(value) || value == GxDateString.NullValue )
               gxTv_SdtBR_Demographics_Br_demographics_birthdate_Z = DateTime.MinValue;
            else
               gxTv_SdtBR_Demographics_Br_demographics_birthdate_Z = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Br_demographics_birthdate_Z
      {
         get {
            return gxTv_SdtBR_Demographics_Br_demographics_birthdate_Z ;
         }

         set {
            gxTv_SdtBR_Demographics_Br_demographics_birthdate_Z = value;
            SetDirty("Br_demographics_birthdate_Z");
         }

      }

      public void gxTv_SdtBR_Demographics_Br_demographics_birthdate_Z_SetNull( )
      {
         gxTv_SdtBR_Demographics_Br_demographics_birthdate_Z = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_SdtBR_Demographics_Br_demographics_birthdate_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Demographics_Sex_Z" )]
      [  XmlElement( ElementName = "BR_Demographics_Sex_Z"   )]
      public String gxTpr_Br_demographics_sex_Z
      {
         get {
            return gxTv_SdtBR_Demographics_Br_demographics_sex_Z ;
         }

         set {
            gxTv_SdtBR_Demographics_Br_demographics_sex_Z = value;
            SetDirty("Br_demographics_sex_Z");
         }

      }

      public void gxTv_SdtBR_Demographics_Br_demographics_sex_Z_SetNull( )
      {
         gxTv_SdtBR_Demographics_Br_demographics_sex_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Demographics_Br_demographics_sex_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Demographics_Sex_Code_Z" )]
      [  XmlElement( ElementName = "BR_Demographics_Sex_Code_Z"   )]
      public String gxTpr_Br_demographics_sex_code_Z
      {
         get {
            return gxTv_SdtBR_Demographics_Br_demographics_sex_code_Z ;
         }

         set {
            gxTv_SdtBR_Demographics_Br_demographics_sex_code_Z = value;
            SetDirty("Br_demographics_sex_code_Z");
         }

      }

      public void gxTv_SdtBR_Demographics_Br_demographics_sex_code_Z_SetNull( )
      {
         gxTv_SdtBR_Demographics_Br_demographics_sex_code_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Demographics_Br_demographics_sex_code_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Demographics_MarritalStatus_Z" )]
      [  XmlElement( ElementName = "BR_Demographics_MarritalStatus_Z"   )]
      public String gxTpr_Br_demographics_marritalstatus_Z
      {
         get {
            return gxTv_SdtBR_Demographics_Br_demographics_marritalstatus_Z ;
         }

         set {
            gxTv_SdtBR_Demographics_Br_demographics_marritalstatus_Z = value;
            SetDirty("Br_demographics_marritalstatus_Z");
         }

      }

      public void gxTv_SdtBR_Demographics_Br_demographics_marritalstatus_Z_SetNull( )
      {
         gxTv_SdtBR_Demographics_Br_demographics_marritalstatus_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Demographics_Br_demographics_marritalstatus_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Demographics_MarritalStatus_Code_Z" )]
      [  XmlElement( ElementName = "BR_Demographics_MarritalStatus_Code_Z"   )]
      public String gxTpr_Br_demographics_marritalstatus_code_Z
      {
         get {
            return gxTv_SdtBR_Demographics_Br_demographics_marritalstatus_code_Z ;
         }

         set {
            gxTv_SdtBR_Demographics_Br_demographics_marritalstatus_code_Z = value;
            SetDirty("Br_demographics_marritalstatus_code_Z");
         }

      }

      public void gxTv_SdtBR_Demographics_Br_demographics_marritalstatus_code_Z_SetNull( )
      {
         gxTv_SdtBR_Demographics_Br_demographics_marritalstatus_code_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Demographics_Br_demographics_marritalstatus_code_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Demographics_Ethnic_Z" )]
      [  XmlElement( ElementName = "BR_Demographics_Ethnic_Z"   )]
      public String gxTpr_Br_demographics_ethnic_Z
      {
         get {
            return gxTv_SdtBR_Demographics_Br_demographics_ethnic_Z ;
         }

         set {
            gxTv_SdtBR_Demographics_Br_demographics_ethnic_Z = value;
            SetDirty("Br_demographics_ethnic_Z");
         }

      }

      public void gxTv_SdtBR_Demographics_Br_demographics_ethnic_Z_SetNull( )
      {
         gxTv_SdtBR_Demographics_Br_demographics_ethnic_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Demographics_Br_demographics_ethnic_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Demographics_Ethnic_Code_Z" )]
      [  XmlElement( ElementName = "BR_Demographics_Ethnic_Code_Z"   )]
      public String gxTpr_Br_demographics_ethnic_code_Z
      {
         get {
            return gxTv_SdtBR_Demographics_Br_demographics_ethnic_code_Z ;
         }

         set {
            gxTv_SdtBR_Demographics_Br_demographics_ethnic_code_Z = value;
            SetDirty("Br_demographics_ethnic_code_Z");
         }

      }

      public void gxTv_SdtBR_Demographics_Br_demographics_ethnic_code_Z_SetNull( )
      {
         gxTv_SdtBR_Demographics_Br_demographics_ethnic_code_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Demographics_Br_demographics_ethnic_code_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Demographics_Education_Z" )]
      [  XmlElement( ElementName = "BR_Demographics_Education_Z"   )]
      public String gxTpr_Br_demographics_education_Z
      {
         get {
            return gxTv_SdtBR_Demographics_Br_demographics_education_Z ;
         }

         set {
            gxTv_SdtBR_Demographics_Br_demographics_education_Z = value;
            SetDirty("Br_demographics_education_Z");
         }

      }

      public void gxTv_SdtBR_Demographics_Br_demographics_education_Z_SetNull( )
      {
         gxTv_SdtBR_Demographics_Br_demographics_education_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Demographics_Br_demographics_education_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Demographics_Education_Code_Z" )]
      [  XmlElement( ElementName = "BR_Demographics_Education_Code_Z"   )]
      public String gxTpr_Br_demographics_education_code_Z
      {
         get {
            return gxTv_SdtBR_Demographics_Br_demographics_education_code_Z ;
         }

         set {
            gxTv_SdtBR_Demographics_Br_demographics_education_code_Z = value;
            SetDirty("Br_demographics_education_code_Z");
         }

      }

      public void gxTv_SdtBR_Demographics_Br_demographics_education_code_Z_SetNull( )
      {
         gxTv_SdtBR_Demographics_Br_demographics_education_code_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Demographics_Br_demographics_education_code_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Demographics_Occupation_Z" )]
      [  XmlElement( ElementName = "BR_Demographics_Occupation_Z"   )]
      public String gxTpr_Br_demographics_occupation_Z
      {
         get {
            return gxTv_SdtBR_Demographics_Br_demographics_occupation_Z ;
         }

         set {
            gxTv_SdtBR_Demographics_Br_demographics_occupation_Z = value;
            SetDirty("Br_demographics_occupation_Z");
         }

      }

      public void gxTv_SdtBR_Demographics_Br_demographics_occupation_Z_SetNull( )
      {
         gxTv_SdtBR_Demographics_Br_demographics_occupation_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Demographics_Br_demographics_occupation_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Demographics_Insurance_Z" )]
      [  XmlElement( ElementName = "BR_Demographics_Insurance_Z"   )]
      public String gxTpr_Br_demographics_insurance_Z
      {
         get {
            return gxTv_SdtBR_Demographics_Br_demographics_insurance_Z ;
         }

         set {
            gxTv_SdtBR_Demographics_Br_demographics_insurance_Z = value;
            SetDirty("Br_demographics_insurance_Z");
         }

      }

      public void gxTv_SdtBR_Demographics_Br_demographics_insurance_Z_SetNull( )
      {
         gxTv_SdtBR_Demographics_Br_demographics_insurance_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Demographics_Br_demographics_insurance_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Demographics_Insurance_Code_Z" )]
      [  XmlElement( ElementName = "BR_Demographics_Insurance_Code_Z"   )]
      public String gxTpr_Br_demographics_insurance_code_Z
      {
         get {
            return gxTv_SdtBR_Demographics_Br_demographics_insurance_code_Z ;
         }

         set {
            gxTv_SdtBR_Demographics_Br_demographics_insurance_code_Z = value;
            SetDirty("Br_demographics_insurance_code_Z");
         }

      }

      public void gxTv_SdtBR_Demographics_Br_demographics_insurance_code_Z_SetNull( )
      {
         gxTv_SdtBR_Demographics_Br_demographics_insurance_code_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Demographics_Br_demographics_insurance_code_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Demographics_Province_Z" )]
      [  XmlElement( ElementName = "BR_Demographics_Province_Z"   )]
      public String gxTpr_Br_demographics_province_Z
      {
         get {
            return gxTv_SdtBR_Demographics_Br_demographics_province_Z ;
         }

         set {
            gxTv_SdtBR_Demographics_Br_demographics_province_Z = value;
            SetDirty("Br_demographics_province_Z");
         }

      }

      public void gxTv_SdtBR_Demographics_Br_demographics_province_Z_SetNull( )
      {
         gxTv_SdtBR_Demographics_Br_demographics_province_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Demographics_Br_demographics_province_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Demographics_City_Z" )]
      [  XmlElement( ElementName = "BR_Demographics_City_Z"   )]
      public String gxTpr_Br_demographics_city_Z
      {
         get {
            return gxTv_SdtBR_Demographics_Br_demographics_city_Z ;
         }

         set {
            gxTv_SdtBR_Demographics_Br_demographics_city_Z = value;
            SetDirty("Br_demographics_city_Z");
         }

      }

      public void gxTv_SdtBR_Demographics_Br_demographics_city_Z_SetNull( )
      {
         gxTv_SdtBR_Demographics_Br_demographics_city_Z = "";
         return  ;
      }

      public bool gxTv_SdtBR_Demographics_Br_demographics_city_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Information_PatientNo_N" )]
      [  XmlElement( ElementName = "BR_Information_PatientNo_N"   )]
      public short gxTpr_Br_information_patientno_N
      {
         get {
            return gxTv_SdtBR_Demographics_Br_information_patientno_N ;
         }

         set {
            gxTv_SdtBR_Demographics_Br_information_patientno_N = value;
            SetDirty("Br_information_patientno_N");
         }

      }

      public void gxTv_SdtBR_Demographics_Br_information_patientno_N_SetNull( )
      {
         gxTv_SdtBR_Demographics_Br_information_patientno_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Demographics_Br_information_patientno_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Demographics_BirthDate_N" )]
      [  XmlElement( ElementName = "BR_Demographics_BirthDate_N"   )]
      public short gxTpr_Br_demographics_birthdate_N
      {
         get {
            return gxTv_SdtBR_Demographics_Br_demographics_birthdate_N ;
         }

         set {
            gxTv_SdtBR_Demographics_Br_demographics_birthdate_N = value;
            SetDirty("Br_demographics_birthdate_N");
         }

      }

      public void gxTv_SdtBR_Demographics_Br_demographics_birthdate_N_SetNull( )
      {
         gxTv_SdtBR_Demographics_Br_demographics_birthdate_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Demographics_Br_demographics_birthdate_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Demographics_Sex_N" )]
      [  XmlElement( ElementName = "BR_Demographics_Sex_N"   )]
      public short gxTpr_Br_demographics_sex_N
      {
         get {
            return gxTv_SdtBR_Demographics_Br_demographics_sex_N ;
         }

         set {
            gxTv_SdtBR_Demographics_Br_demographics_sex_N = value;
            SetDirty("Br_demographics_sex_N");
         }

      }

      public void gxTv_SdtBR_Demographics_Br_demographics_sex_N_SetNull( )
      {
         gxTv_SdtBR_Demographics_Br_demographics_sex_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Demographics_Br_demographics_sex_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Demographics_Sex_Code_N" )]
      [  XmlElement( ElementName = "BR_Demographics_Sex_Code_N"   )]
      public short gxTpr_Br_demographics_sex_code_N
      {
         get {
            return gxTv_SdtBR_Demographics_Br_demographics_sex_code_N ;
         }

         set {
            gxTv_SdtBR_Demographics_Br_demographics_sex_code_N = value;
            SetDirty("Br_demographics_sex_code_N");
         }

      }

      public void gxTv_SdtBR_Demographics_Br_demographics_sex_code_N_SetNull( )
      {
         gxTv_SdtBR_Demographics_Br_demographics_sex_code_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Demographics_Br_demographics_sex_code_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Demographics_MarritalStatus_N" )]
      [  XmlElement( ElementName = "BR_Demographics_MarritalStatus_N"   )]
      public short gxTpr_Br_demographics_marritalstatus_N
      {
         get {
            return gxTv_SdtBR_Demographics_Br_demographics_marritalstatus_N ;
         }

         set {
            gxTv_SdtBR_Demographics_Br_demographics_marritalstatus_N = value;
            SetDirty("Br_demographics_marritalstatus_N");
         }

      }

      public void gxTv_SdtBR_Demographics_Br_demographics_marritalstatus_N_SetNull( )
      {
         gxTv_SdtBR_Demographics_Br_demographics_marritalstatus_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Demographics_Br_demographics_marritalstatus_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Demographics_MarritalStatus_Code_N" )]
      [  XmlElement( ElementName = "BR_Demographics_MarritalStatus_Code_N"   )]
      public short gxTpr_Br_demographics_marritalstatus_code_N
      {
         get {
            return gxTv_SdtBR_Demographics_Br_demographics_marritalstatus_code_N ;
         }

         set {
            gxTv_SdtBR_Demographics_Br_demographics_marritalstatus_code_N = value;
            SetDirty("Br_demographics_marritalstatus_code_N");
         }

      }

      public void gxTv_SdtBR_Demographics_Br_demographics_marritalstatus_code_N_SetNull( )
      {
         gxTv_SdtBR_Demographics_Br_demographics_marritalstatus_code_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Demographics_Br_demographics_marritalstatus_code_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Demographics_Ethnic_N" )]
      [  XmlElement( ElementName = "BR_Demographics_Ethnic_N"   )]
      public short gxTpr_Br_demographics_ethnic_N
      {
         get {
            return gxTv_SdtBR_Demographics_Br_demographics_ethnic_N ;
         }

         set {
            gxTv_SdtBR_Demographics_Br_demographics_ethnic_N = value;
            SetDirty("Br_demographics_ethnic_N");
         }

      }

      public void gxTv_SdtBR_Demographics_Br_demographics_ethnic_N_SetNull( )
      {
         gxTv_SdtBR_Demographics_Br_demographics_ethnic_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Demographics_Br_demographics_ethnic_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Demographics_Ethnic_Code_N" )]
      [  XmlElement( ElementName = "BR_Demographics_Ethnic_Code_N"   )]
      public short gxTpr_Br_demographics_ethnic_code_N
      {
         get {
            return gxTv_SdtBR_Demographics_Br_demographics_ethnic_code_N ;
         }

         set {
            gxTv_SdtBR_Demographics_Br_demographics_ethnic_code_N = value;
            SetDirty("Br_demographics_ethnic_code_N");
         }

      }

      public void gxTv_SdtBR_Demographics_Br_demographics_ethnic_code_N_SetNull( )
      {
         gxTv_SdtBR_Demographics_Br_demographics_ethnic_code_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Demographics_Br_demographics_ethnic_code_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Demographics_Education_N" )]
      [  XmlElement( ElementName = "BR_Demographics_Education_N"   )]
      public short gxTpr_Br_demographics_education_N
      {
         get {
            return gxTv_SdtBR_Demographics_Br_demographics_education_N ;
         }

         set {
            gxTv_SdtBR_Demographics_Br_demographics_education_N = value;
            SetDirty("Br_demographics_education_N");
         }

      }

      public void gxTv_SdtBR_Demographics_Br_demographics_education_N_SetNull( )
      {
         gxTv_SdtBR_Demographics_Br_demographics_education_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Demographics_Br_demographics_education_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Demographics_Education_Code_N" )]
      [  XmlElement( ElementName = "BR_Demographics_Education_Code_N"   )]
      public short gxTpr_Br_demographics_education_code_N
      {
         get {
            return gxTv_SdtBR_Demographics_Br_demographics_education_code_N ;
         }

         set {
            gxTv_SdtBR_Demographics_Br_demographics_education_code_N = value;
            SetDirty("Br_demographics_education_code_N");
         }

      }

      public void gxTv_SdtBR_Demographics_Br_demographics_education_code_N_SetNull( )
      {
         gxTv_SdtBR_Demographics_Br_demographics_education_code_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Demographics_Br_demographics_education_code_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Demographics_Occupation_N" )]
      [  XmlElement( ElementName = "BR_Demographics_Occupation_N"   )]
      public short gxTpr_Br_demographics_occupation_N
      {
         get {
            return gxTv_SdtBR_Demographics_Br_demographics_occupation_N ;
         }

         set {
            gxTv_SdtBR_Demographics_Br_demographics_occupation_N = value;
            SetDirty("Br_demographics_occupation_N");
         }

      }

      public void gxTv_SdtBR_Demographics_Br_demographics_occupation_N_SetNull( )
      {
         gxTv_SdtBR_Demographics_Br_demographics_occupation_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Demographics_Br_demographics_occupation_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Demographics_Insurance_N" )]
      [  XmlElement( ElementName = "BR_Demographics_Insurance_N"   )]
      public short gxTpr_Br_demographics_insurance_N
      {
         get {
            return gxTv_SdtBR_Demographics_Br_demographics_insurance_N ;
         }

         set {
            gxTv_SdtBR_Demographics_Br_demographics_insurance_N = value;
            SetDirty("Br_demographics_insurance_N");
         }

      }

      public void gxTv_SdtBR_Demographics_Br_demographics_insurance_N_SetNull( )
      {
         gxTv_SdtBR_Demographics_Br_demographics_insurance_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Demographics_Br_demographics_insurance_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Demographics_Insurance_Code_N" )]
      [  XmlElement( ElementName = "BR_Demographics_Insurance_Code_N"   )]
      public short gxTpr_Br_demographics_insurance_code_N
      {
         get {
            return gxTv_SdtBR_Demographics_Br_demographics_insurance_code_N ;
         }

         set {
            gxTv_SdtBR_Demographics_Br_demographics_insurance_code_N = value;
            SetDirty("Br_demographics_insurance_code_N");
         }

      }

      public void gxTv_SdtBR_Demographics_Br_demographics_insurance_code_N_SetNull( )
      {
         gxTv_SdtBR_Demographics_Br_demographics_insurance_code_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Demographics_Br_demographics_insurance_code_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Demographics_Province_N" )]
      [  XmlElement( ElementName = "BR_Demographics_Province_N"   )]
      public short gxTpr_Br_demographics_province_N
      {
         get {
            return gxTv_SdtBR_Demographics_Br_demographics_province_N ;
         }

         set {
            gxTv_SdtBR_Demographics_Br_demographics_province_N = value;
            SetDirty("Br_demographics_province_N");
         }

      }

      public void gxTv_SdtBR_Demographics_Br_demographics_province_N_SetNull( )
      {
         gxTv_SdtBR_Demographics_Br_demographics_province_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Demographics_Br_demographics_province_N_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "BR_Demographics_City_N" )]
      [  XmlElement( ElementName = "BR_Demographics_City_N"   )]
      public short gxTpr_Br_demographics_city_N
      {
         get {
            return gxTv_SdtBR_Demographics_Br_demographics_city_N ;
         }

         set {
            gxTv_SdtBR_Demographics_Br_demographics_city_N = value;
            SetDirty("Br_demographics_city_N");
         }

      }

      public void gxTv_SdtBR_Demographics_Br_demographics_city_N_SetNull( )
      {
         gxTv_SdtBR_Demographics_Br_demographics_city_N = 0;
         return  ;
      }

      public bool gxTv_SdtBR_Demographics_Br_demographics_city_N_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_SdtBR_Demographics_Br_information_patientno = "";
         gxTv_SdtBR_Demographics_Br_demographics_birthdate = DateTime.MinValue;
         gxTv_SdtBR_Demographics_Br_demographics_sex = "";
         gxTv_SdtBR_Demographics_Br_demographics_sex_code = "";
         gxTv_SdtBR_Demographics_Br_demographics_marritalstatus = "";
         gxTv_SdtBR_Demographics_Br_demographics_marritalstatus_code = "";
         gxTv_SdtBR_Demographics_Br_demographics_ethnic = "";
         gxTv_SdtBR_Demographics_Br_demographics_ethnic_code = "";
         gxTv_SdtBR_Demographics_Br_demographics_education = "";
         gxTv_SdtBR_Demographics_Br_demographics_education_code = "";
         gxTv_SdtBR_Demographics_Br_demographics_occupation = "";
         gxTv_SdtBR_Demographics_Br_demographics_insurance = "";
         gxTv_SdtBR_Demographics_Br_demographics_insurance_code = "";
         gxTv_SdtBR_Demographics_Br_demographics_province = "";
         gxTv_SdtBR_Demographics_Br_demographics_city = "";
         gxTv_SdtBR_Demographics_Mode = "";
         gxTv_SdtBR_Demographics_Br_information_patientno_Z = "";
         gxTv_SdtBR_Demographics_Br_demographics_birthdate_Z = DateTime.MinValue;
         gxTv_SdtBR_Demographics_Br_demographics_sex_Z = "";
         gxTv_SdtBR_Demographics_Br_demographics_sex_code_Z = "";
         gxTv_SdtBR_Demographics_Br_demographics_marritalstatus_Z = "";
         gxTv_SdtBR_Demographics_Br_demographics_marritalstatus_code_Z = "";
         gxTv_SdtBR_Demographics_Br_demographics_ethnic_Z = "";
         gxTv_SdtBR_Demographics_Br_demographics_ethnic_code_Z = "";
         gxTv_SdtBR_Demographics_Br_demographics_education_Z = "";
         gxTv_SdtBR_Demographics_Br_demographics_education_code_Z = "";
         gxTv_SdtBR_Demographics_Br_demographics_occupation_Z = "";
         gxTv_SdtBR_Demographics_Br_demographics_insurance_Z = "";
         gxTv_SdtBR_Demographics_Br_demographics_insurance_code_Z = "";
         gxTv_SdtBR_Demographics_Br_demographics_province_Z = "";
         gxTv_SdtBR_Demographics_Br_demographics_city_Z = "";
         sDateCnv = "";
         sNumToPad = "";
         IGxSilentTrn obj ;
         obj = (IGxSilentTrn)ClassLoader.FindInstance( "br_demographics", "GeneXus.Programs.br_demographics_bc", new Object[] {context}, constructorCallingAssembly);;
         obj.initialize();
         obj.SetSDT(this, 1);
         setTransaction( obj) ;
         obj.SetMode("INS");
         return  ;
      }

      private short gxTv_SdtBR_Demographics_Initialized ;
      private short gxTv_SdtBR_Demographics_Br_information_patientno_N ;
      private short gxTv_SdtBR_Demographics_Br_demographics_birthdate_N ;
      private short gxTv_SdtBR_Demographics_Br_demographics_sex_N ;
      private short gxTv_SdtBR_Demographics_Br_demographics_sex_code_N ;
      private short gxTv_SdtBR_Demographics_Br_demographics_marritalstatus_N ;
      private short gxTv_SdtBR_Demographics_Br_demographics_marritalstatus_code_N ;
      private short gxTv_SdtBR_Demographics_Br_demographics_ethnic_N ;
      private short gxTv_SdtBR_Demographics_Br_demographics_ethnic_code_N ;
      private short gxTv_SdtBR_Demographics_Br_demographics_education_N ;
      private short gxTv_SdtBR_Demographics_Br_demographics_education_code_N ;
      private short gxTv_SdtBR_Demographics_Br_demographics_occupation_N ;
      private short gxTv_SdtBR_Demographics_Br_demographics_insurance_N ;
      private short gxTv_SdtBR_Demographics_Br_demographics_insurance_code_N ;
      private short gxTv_SdtBR_Demographics_Br_demographics_province_N ;
      private short gxTv_SdtBR_Demographics_Br_demographics_city_N ;
      private long gxTv_SdtBR_Demographics_Br_demographics_id ;
      private long gxTv_SdtBR_Demographics_Br_encounterid ;
      private long gxTv_SdtBR_Demographics_Br_demographics_id_Z ;
      private long gxTv_SdtBR_Demographics_Br_encounterid_Z ;
      private String gxTv_SdtBR_Demographics_Mode ;
      private String sDateCnv ;
      private String sNumToPad ;
      private DateTime gxTv_SdtBR_Demographics_Br_demographics_birthdate ;
      private DateTime gxTv_SdtBR_Demographics_Br_demographics_birthdate_Z ;
      private String gxTv_SdtBR_Demographics_Br_information_patientno ;
      private String gxTv_SdtBR_Demographics_Br_demographics_sex ;
      private String gxTv_SdtBR_Demographics_Br_demographics_sex_code ;
      private String gxTv_SdtBR_Demographics_Br_demographics_marritalstatus ;
      private String gxTv_SdtBR_Demographics_Br_demographics_marritalstatus_code ;
      private String gxTv_SdtBR_Demographics_Br_demographics_ethnic ;
      private String gxTv_SdtBR_Demographics_Br_demographics_ethnic_code ;
      private String gxTv_SdtBR_Demographics_Br_demographics_education ;
      private String gxTv_SdtBR_Demographics_Br_demographics_education_code ;
      private String gxTv_SdtBR_Demographics_Br_demographics_occupation ;
      private String gxTv_SdtBR_Demographics_Br_demographics_insurance ;
      private String gxTv_SdtBR_Demographics_Br_demographics_insurance_code ;
      private String gxTv_SdtBR_Demographics_Br_demographics_province ;
      private String gxTv_SdtBR_Demographics_Br_demographics_city ;
      private String gxTv_SdtBR_Demographics_Br_information_patientno_Z ;
      private String gxTv_SdtBR_Demographics_Br_demographics_sex_Z ;
      private String gxTv_SdtBR_Demographics_Br_demographics_sex_code_Z ;
      private String gxTv_SdtBR_Demographics_Br_demographics_marritalstatus_Z ;
      private String gxTv_SdtBR_Demographics_Br_demographics_marritalstatus_code_Z ;
      private String gxTv_SdtBR_Demographics_Br_demographics_ethnic_Z ;
      private String gxTv_SdtBR_Demographics_Br_demographics_ethnic_code_Z ;
      private String gxTv_SdtBR_Demographics_Br_demographics_education_Z ;
      private String gxTv_SdtBR_Demographics_Br_demographics_education_code_Z ;
      private String gxTv_SdtBR_Demographics_Br_demographics_occupation_Z ;
      private String gxTv_SdtBR_Demographics_Br_demographics_insurance_Z ;
      private String gxTv_SdtBR_Demographics_Br_demographics_insurance_code_Z ;
      private String gxTv_SdtBR_Demographics_Br_demographics_province_Z ;
      private String gxTv_SdtBR_Demographics_Br_demographics_city_Z ;
   }

   [DataContract(Name = @"BR_Demographics", Namespace = "DataAnalysisPlatform")]
   public class SdtBR_Demographics_RESTInterface : GxGenericCollectionItem<SdtBR_Demographics>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtBR_Demographics_RESTInterface( ) : base()
      {
      }

      public SdtBR_Demographics_RESTInterface( SdtBR_Demographics psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "BR_Demographics_ID" , Order = 0 )]
      [GxSeudo()]
      public String gxTpr_Br_demographics_id
      {
         get {
            return StringUtil.LTrim( StringUtil.Str( (decimal)(sdt.gxTpr_Br_demographics_id), 18, 0)) ;
         }

         set {
            sdt.gxTpr_Br_demographics_id = (long)(NumberUtil.Val( value, "."));
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

      [DataMember( Name = "BR_Demographics_BirthDate" , Order = 3 )]
      [GxSeudo()]
      public String gxTpr_Br_demographics_birthdate
      {
         get {
            return DateTimeUtil.DToC2( sdt.gxTpr_Br_demographics_birthdate) ;
         }

         set {
            sdt.gxTpr_Br_demographics_birthdate = DateTimeUtil.CToD2( value);
         }

      }

      [DataMember( Name = "BR_Demographics_Sex" , Order = 4 )]
      [GxSeudo()]
      public String gxTpr_Br_demographics_sex
      {
         get {
            return sdt.gxTpr_Br_demographics_sex ;
         }

         set {
            sdt.gxTpr_Br_demographics_sex = value;
         }

      }

      [DataMember( Name = "BR_Demographics_Sex_Code" , Order = 5 )]
      [GxSeudo()]
      public String gxTpr_Br_demographics_sex_code
      {
         get {
            return sdt.gxTpr_Br_demographics_sex_code ;
         }

         set {
            sdt.gxTpr_Br_demographics_sex_code = value;
         }

      }

      [DataMember( Name = "BR_Demographics_MarritalStatus" , Order = 6 )]
      [GxSeudo()]
      public String gxTpr_Br_demographics_marritalstatus
      {
         get {
            return sdt.gxTpr_Br_demographics_marritalstatus ;
         }

         set {
            sdt.gxTpr_Br_demographics_marritalstatus = value;
         }

      }

      [DataMember( Name = "BR_Demographics_MarritalStatus_Code" , Order = 7 )]
      [GxSeudo()]
      public String gxTpr_Br_demographics_marritalstatus_code
      {
         get {
            return sdt.gxTpr_Br_demographics_marritalstatus_code ;
         }

         set {
            sdt.gxTpr_Br_demographics_marritalstatus_code = value;
         }

      }

      [DataMember( Name = "BR_Demographics_Ethnic" , Order = 8 )]
      [GxSeudo()]
      public String gxTpr_Br_demographics_ethnic
      {
         get {
            return sdt.gxTpr_Br_demographics_ethnic ;
         }

         set {
            sdt.gxTpr_Br_demographics_ethnic = value;
         }

      }

      [DataMember( Name = "BR_Demographics_Ethnic_Code" , Order = 9 )]
      [GxSeudo()]
      public String gxTpr_Br_demographics_ethnic_code
      {
         get {
            return sdt.gxTpr_Br_demographics_ethnic_code ;
         }

         set {
            sdt.gxTpr_Br_demographics_ethnic_code = value;
         }

      }

      [DataMember( Name = "BR_Demographics_Education" , Order = 10 )]
      [GxSeudo()]
      public String gxTpr_Br_demographics_education
      {
         get {
            return sdt.gxTpr_Br_demographics_education ;
         }

         set {
            sdt.gxTpr_Br_demographics_education = value;
         }

      }

      [DataMember( Name = "BR_Demographics_Education_Code" , Order = 11 )]
      [GxSeudo()]
      public String gxTpr_Br_demographics_education_code
      {
         get {
            return sdt.gxTpr_Br_demographics_education_code ;
         }

         set {
            sdt.gxTpr_Br_demographics_education_code = value;
         }

      }

      [DataMember( Name = "BR_Demographics_Occupation" , Order = 12 )]
      [GxSeudo()]
      public String gxTpr_Br_demographics_occupation
      {
         get {
            return sdt.gxTpr_Br_demographics_occupation ;
         }

         set {
            sdt.gxTpr_Br_demographics_occupation = value;
         }

      }

      [DataMember( Name = "BR_Demographics_Insurance" , Order = 13 )]
      [GxSeudo()]
      public String gxTpr_Br_demographics_insurance
      {
         get {
            return sdt.gxTpr_Br_demographics_insurance ;
         }

         set {
            sdt.gxTpr_Br_demographics_insurance = value;
         }

      }

      [DataMember( Name = "BR_Demographics_Insurance_Code" , Order = 14 )]
      [GxSeudo()]
      public String gxTpr_Br_demographics_insurance_code
      {
         get {
            return sdt.gxTpr_Br_demographics_insurance_code ;
         }

         set {
            sdt.gxTpr_Br_demographics_insurance_code = value;
         }

      }

      [DataMember( Name = "BR_Demographics_Province" , Order = 15 )]
      [GxSeudo()]
      public String gxTpr_Br_demographics_province
      {
         get {
            return sdt.gxTpr_Br_demographics_province ;
         }

         set {
            sdt.gxTpr_Br_demographics_province = value;
         }

      }

      [DataMember( Name = "BR_Demographics_City" , Order = 16 )]
      [GxSeudo()]
      public String gxTpr_Br_demographics_city
      {
         get {
            return sdt.gxTpr_Br_demographics_city ;
         }

         set {
            sdt.gxTpr_Br_demographics_city = value;
         }

      }

      public SdtBR_Demographics sdt
      {
         get {
            return (SdtBR_Demographics)Sdt ;
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
            sdt = new SdtBR_Demographics() ;
         }
      }

      [DataMember( Name = "gx_md5_hash", Order = 17 )]
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
