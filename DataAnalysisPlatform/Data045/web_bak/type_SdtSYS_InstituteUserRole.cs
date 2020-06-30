/*
               File: type_SdtSYS_InstituteUserRole
        Description: SYS_Institute User Role
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:38:55.60
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
   [XmlRoot(ElementName = "SYS_InstituteUserRole" )]
   [XmlType(TypeName =  "SYS_InstituteUserRole" , Namespace = "DataAnalysisPlatform" )]
   [Serializable]
   public class SdtSYS_InstituteUserRole : GxSilentTrnSdt, System.Web.SessionState.IRequiresSessionState
   {
      public SdtSYS_InstituteUserRole( )
      {
      }

      public SdtSYS_InstituteUserRole( IGxContext context )
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

      public void Load( Guid AV363SYS_InstituteUserRoleUserRoleID )
      {
         IGxSilentTrn obj ;
         obj = getTransaction();
         obj.LoadKey(new Object[] {(Guid)AV363SYS_InstituteUserRoleUserRoleID});
         return  ;
      }

      public override Object[][] GetBCKey( )
      {
         return (Object[][])(new Object[][]{new Object[]{"SYS_InstituteUserRoleUserRoleID", typeof(Guid)}}) ;
      }

      public override GXProperties GetMetadata( )
      {
         GXProperties metadata = new GXProperties() ;
         metadata.Set("Name", "SYS_InstituteUserRole");
         metadata.Set("BT", "SYS_INSTITUTEUSERROLE");
         metadata.Set("PK", "[ \"SYS_InstituteUserRoleUserRoleID\" ]");
         metadata.Set("PKAssigned", "[ \"SYS_InstituteUserRoleUserRoleID\" ]");
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
         state.Add("gxTpr_Sys_instituteuserroleuserroleid_Z");
         state.Add("gxTpr_Sys_instituteuserroleroleid_Z");
         state.Add("gxTpr_Sys_instituteuserroleinstitutecode_Z");
         state.Add("gxTpr_Sys_instituteuserroleuserid_Z");
         return state ;
      }

      public override void Copy( GxUserType source )
      {
         SdtSYS_InstituteUserRole sdt ;
         sdt = (SdtSYS_InstituteUserRole)(source);
         gxTv_SdtSYS_InstituteUserRole_Sys_instituteuserroleuserroleid = sdt.gxTv_SdtSYS_InstituteUserRole_Sys_instituteuserroleuserroleid ;
         gxTv_SdtSYS_InstituteUserRole_Sys_instituteuserroleroleid = sdt.gxTv_SdtSYS_InstituteUserRole_Sys_instituteuserroleroleid ;
         gxTv_SdtSYS_InstituteUserRole_Sys_instituteuserroleinstitutecode = sdt.gxTv_SdtSYS_InstituteUserRole_Sys_instituteuserroleinstitutecode ;
         gxTv_SdtSYS_InstituteUserRole_Sys_instituteuserroleuserid = sdt.gxTv_SdtSYS_InstituteUserRole_Sys_instituteuserroleuserid ;
         gxTv_SdtSYS_InstituteUserRole_Mode = sdt.gxTv_SdtSYS_InstituteUserRole_Mode ;
         gxTv_SdtSYS_InstituteUserRole_Initialized = sdt.gxTv_SdtSYS_InstituteUserRole_Initialized ;
         gxTv_SdtSYS_InstituteUserRole_Sys_instituteuserroleuserroleid_Z = sdt.gxTv_SdtSYS_InstituteUserRole_Sys_instituteuserroleuserroleid_Z ;
         gxTv_SdtSYS_InstituteUserRole_Sys_instituteuserroleroleid_Z = sdt.gxTv_SdtSYS_InstituteUserRole_Sys_instituteuserroleroleid_Z ;
         gxTv_SdtSYS_InstituteUserRole_Sys_instituteuserroleinstitutecode_Z = sdt.gxTv_SdtSYS_InstituteUserRole_Sys_instituteuserroleinstitutecode_Z ;
         gxTv_SdtSYS_InstituteUserRole_Sys_instituteuserroleuserid_Z = sdt.gxTv_SdtSYS_InstituteUserRole_Sys_instituteuserroleuserid_Z ;
         return  ;
      }

      public override void ToJSON( )
      {
         ToJSON( true) ;
         return  ;
      }

      public override void ToJSON( bool includeState )
      {
         AddObjectProperty("SYS_InstituteUserRoleUserRoleID", gxTv_SdtSYS_InstituteUserRole_Sys_instituteuserroleuserroleid, false);
         AddObjectProperty("SYS_InstituteUserRoleRoleID", gxTv_SdtSYS_InstituteUserRole_Sys_instituteuserroleroleid, false);
         AddObjectProperty("SYS_InstituteUserRoleInstituteCode", gxTv_SdtSYS_InstituteUserRole_Sys_instituteuserroleinstitutecode, false);
         AddObjectProperty("SYS_InstituteUserRoleUserID", gxTv_SdtSYS_InstituteUserRole_Sys_instituteuserroleuserid, false);
         if ( includeState )
         {
            AddObjectProperty("Mode", gxTv_SdtSYS_InstituteUserRole_Mode, false);
            AddObjectProperty("Initialized", gxTv_SdtSYS_InstituteUserRole_Initialized, false);
            AddObjectProperty("SYS_InstituteUserRoleUserRoleID_Z", gxTv_SdtSYS_InstituteUserRole_Sys_instituteuserroleuserroleid_Z, false);
            AddObjectProperty("SYS_InstituteUserRoleRoleID_Z", gxTv_SdtSYS_InstituteUserRole_Sys_instituteuserroleroleid_Z, false);
            AddObjectProperty("SYS_InstituteUserRoleInstituteCode_Z", gxTv_SdtSYS_InstituteUserRole_Sys_instituteuserroleinstitutecode_Z, false);
            AddObjectProperty("SYS_InstituteUserRoleUserID_Z", gxTv_SdtSYS_InstituteUserRole_Sys_instituteuserroleuserid_Z, false);
         }
         return  ;
      }

      public void UpdateDirties( SdtSYS_InstituteUserRole sdt )
      {
         if ( sdt.IsDirty("SYS_InstituteUserRoleUserRoleID") )
         {
            gxTv_SdtSYS_InstituteUserRole_Sys_instituteuserroleuserroleid = sdt.gxTv_SdtSYS_InstituteUserRole_Sys_instituteuserroleuserroleid ;
         }
         if ( sdt.IsDirty("SYS_InstituteUserRoleRoleID") )
         {
            gxTv_SdtSYS_InstituteUserRole_Sys_instituteuserroleroleid = sdt.gxTv_SdtSYS_InstituteUserRole_Sys_instituteuserroleroleid ;
         }
         if ( sdt.IsDirty("SYS_InstituteUserRoleInstituteCode") )
         {
            gxTv_SdtSYS_InstituteUserRole_Sys_instituteuserroleinstitutecode = sdt.gxTv_SdtSYS_InstituteUserRole_Sys_instituteuserroleinstitutecode ;
         }
         if ( sdt.IsDirty("SYS_InstituteUserRoleUserID") )
         {
            gxTv_SdtSYS_InstituteUserRole_Sys_instituteuserroleuserid = sdt.gxTv_SdtSYS_InstituteUserRole_Sys_instituteuserroleuserid ;
         }
         return  ;
      }

      [  SoapElement( ElementName = "SYS_InstituteUserRoleUserRoleID" )]
      [  XmlElement( ElementName = "SYS_InstituteUserRoleUserRoleID"   )]
      public Guid gxTpr_Sys_instituteuserroleuserroleid
      {
         get {
            return gxTv_SdtSYS_InstituteUserRole_Sys_instituteuserroleuserroleid ;
         }

         set {
            if ( gxTv_SdtSYS_InstituteUserRole_Sys_instituteuserroleuserroleid != value )
            {
               gxTv_SdtSYS_InstituteUserRole_Mode = "INS";
               this.gxTv_SdtSYS_InstituteUserRole_Sys_instituteuserroleuserroleid_Z_SetNull( );
               this.gxTv_SdtSYS_InstituteUserRole_Sys_instituteuserroleroleid_Z_SetNull( );
               this.gxTv_SdtSYS_InstituteUserRole_Sys_instituteuserroleinstitutecode_Z_SetNull( );
               this.gxTv_SdtSYS_InstituteUserRole_Sys_instituteuserroleuserid_Z_SetNull( );
            }
            gxTv_SdtSYS_InstituteUserRole_Sys_instituteuserroleuserroleid = (Guid)(value);
            SetDirty("Sys_instituteuserroleuserroleid");
         }

      }

      [  SoapElement( ElementName = "SYS_InstituteUserRoleRoleID" )]
      [  XmlElement( ElementName = "SYS_InstituteUserRoleRoleID"   )]
      public Guid gxTpr_Sys_instituteuserroleroleid
      {
         get {
            return gxTv_SdtSYS_InstituteUserRole_Sys_instituteuserroleroleid ;
         }

         set {
            gxTv_SdtSYS_InstituteUserRole_Sys_instituteuserroleroleid = (Guid)(value);
            SetDirty("Sys_instituteuserroleroleid");
         }

      }

      [  SoapElement( ElementName = "SYS_InstituteUserRoleInstituteCode" )]
      [  XmlElement( ElementName = "SYS_InstituteUserRoleInstituteCode"   )]
      public String gxTpr_Sys_instituteuserroleinstitutecode
      {
         get {
            return gxTv_SdtSYS_InstituteUserRole_Sys_instituteuserroleinstitutecode ;
         }

         set {
            gxTv_SdtSYS_InstituteUserRole_Sys_instituteuserroleinstitutecode = value;
            SetDirty("Sys_instituteuserroleinstitutecode");
         }

      }

      [  SoapElement( ElementName = "SYS_InstituteUserRoleUserID" )]
      [  XmlElement( ElementName = "SYS_InstituteUserRoleUserID"   )]
      public Guid gxTpr_Sys_instituteuserroleuserid
      {
         get {
            return gxTv_SdtSYS_InstituteUserRole_Sys_instituteuserroleuserid ;
         }

         set {
            gxTv_SdtSYS_InstituteUserRole_Sys_instituteuserroleuserid = (Guid)(value);
            SetDirty("Sys_instituteuserroleuserid");
         }

      }

      [  SoapElement( ElementName = "Mode" )]
      [  XmlElement( ElementName = "Mode"   )]
      public String gxTpr_Mode
      {
         get {
            return gxTv_SdtSYS_InstituteUserRole_Mode ;
         }

         set {
            gxTv_SdtSYS_InstituteUserRole_Mode = value;
            SetDirty("Mode");
         }

      }

      public void gxTv_SdtSYS_InstituteUserRole_Mode_SetNull( )
      {
         gxTv_SdtSYS_InstituteUserRole_Mode = "";
         return  ;
      }

      public bool gxTv_SdtSYS_InstituteUserRole_Mode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Initialized" )]
      [  XmlElement( ElementName = "Initialized"   )]
      public short gxTpr_Initialized
      {
         get {
            return gxTv_SdtSYS_InstituteUserRole_Initialized ;
         }

         set {
            gxTv_SdtSYS_InstituteUserRole_Initialized = value;
            SetDirty("Initialized");
         }

      }

      public void gxTv_SdtSYS_InstituteUserRole_Initialized_SetNull( )
      {
         gxTv_SdtSYS_InstituteUserRole_Initialized = 0;
         return  ;
      }

      public bool gxTv_SdtSYS_InstituteUserRole_Initialized_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SYS_InstituteUserRoleUserRoleID_Z" )]
      [  XmlElement( ElementName = "SYS_InstituteUserRoleUserRoleID_Z"   )]
      public Guid gxTpr_Sys_instituteuserroleuserroleid_Z
      {
         get {
            return gxTv_SdtSYS_InstituteUserRole_Sys_instituteuserroleuserroleid_Z ;
         }

         set {
            gxTv_SdtSYS_InstituteUserRole_Sys_instituteuserroleuserroleid_Z = (Guid)(value);
            SetDirty("Sys_instituteuserroleuserroleid_Z");
         }

      }

      public void gxTv_SdtSYS_InstituteUserRole_Sys_instituteuserroleuserroleid_Z_SetNull( )
      {
         gxTv_SdtSYS_InstituteUserRole_Sys_instituteuserroleuserroleid_Z = (Guid)(Guid.Empty);
         return  ;
      }

      public bool gxTv_SdtSYS_InstituteUserRole_Sys_instituteuserroleuserroleid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SYS_InstituteUserRoleRoleID_Z" )]
      [  XmlElement( ElementName = "SYS_InstituteUserRoleRoleID_Z"   )]
      public Guid gxTpr_Sys_instituteuserroleroleid_Z
      {
         get {
            return gxTv_SdtSYS_InstituteUserRole_Sys_instituteuserroleroleid_Z ;
         }

         set {
            gxTv_SdtSYS_InstituteUserRole_Sys_instituteuserroleroleid_Z = (Guid)(value);
            SetDirty("Sys_instituteuserroleroleid_Z");
         }

      }

      public void gxTv_SdtSYS_InstituteUserRole_Sys_instituteuserroleroleid_Z_SetNull( )
      {
         gxTv_SdtSYS_InstituteUserRole_Sys_instituteuserroleroleid_Z = (Guid)(Guid.Empty);
         return  ;
      }

      public bool gxTv_SdtSYS_InstituteUserRole_Sys_instituteuserroleroleid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SYS_InstituteUserRoleInstituteCode_Z" )]
      [  XmlElement( ElementName = "SYS_InstituteUserRoleInstituteCode_Z"   )]
      public String gxTpr_Sys_instituteuserroleinstitutecode_Z
      {
         get {
            return gxTv_SdtSYS_InstituteUserRole_Sys_instituteuserroleinstitutecode_Z ;
         }

         set {
            gxTv_SdtSYS_InstituteUserRole_Sys_instituteuserroleinstitutecode_Z = value;
            SetDirty("Sys_instituteuserroleinstitutecode_Z");
         }

      }

      public void gxTv_SdtSYS_InstituteUserRole_Sys_instituteuserroleinstitutecode_Z_SetNull( )
      {
         gxTv_SdtSYS_InstituteUserRole_Sys_instituteuserroleinstitutecode_Z = "";
         return  ;
      }

      public bool gxTv_SdtSYS_InstituteUserRole_Sys_instituteuserroleinstitutecode_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SYS_InstituteUserRoleUserID_Z" )]
      [  XmlElement( ElementName = "SYS_InstituteUserRoleUserID_Z"   )]
      public Guid gxTpr_Sys_instituteuserroleuserid_Z
      {
         get {
            return gxTv_SdtSYS_InstituteUserRole_Sys_instituteuserroleuserid_Z ;
         }

         set {
            gxTv_SdtSYS_InstituteUserRole_Sys_instituteuserroleuserid_Z = (Guid)(value);
            SetDirty("Sys_instituteuserroleuserid_Z");
         }

      }

      public void gxTv_SdtSYS_InstituteUserRole_Sys_instituteuserroleuserid_Z_SetNull( )
      {
         gxTv_SdtSYS_InstituteUserRole_Sys_instituteuserroleuserid_Z = (Guid)(Guid.Empty);
         return  ;
      }

      public bool gxTv_SdtSYS_InstituteUserRole_Sys_instituteuserroleuserid_Z_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_SdtSYS_InstituteUserRole_Sys_instituteuserroleuserroleid = (Guid)(Guid.Empty);
         gxTv_SdtSYS_InstituteUserRole_Sys_instituteuserroleroleid = (Guid)(Guid.Empty);
         gxTv_SdtSYS_InstituteUserRole_Sys_instituteuserroleinstitutecode = "";
         gxTv_SdtSYS_InstituteUserRole_Sys_instituteuserroleuserid = (Guid)(Guid.Empty);
         gxTv_SdtSYS_InstituteUserRole_Mode = "";
         gxTv_SdtSYS_InstituteUserRole_Sys_instituteuserroleuserroleid_Z = (Guid)(Guid.Empty);
         gxTv_SdtSYS_InstituteUserRole_Sys_instituteuserroleroleid_Z = (Guid)(Guid.Empty);
         gxTv_SdtSYS_InstituteUserRole_Sys_instituteuserroleinstitutecode_Z = "";
         gxTv_SdtSYS_InstituteUserRole_Sys_instituteuserroleuserid_Z = (Guid)(Guid.Empty);
         IGxSilentTrn obj ;
         obj = (IGxSilentTrn)ClassLoader.FindInstance( "sys_instituteuserrole", "GeneXus.Programs.sys_instituteuserrole_bc", new Object[] {context}, constructorCallingAssembly);;
         obj.initialize();
         obj.SetSDT(this, 1);
         setTransaction( obj) ;
         obj.SetMode("INS");
         return  ;
      }

      private short gxTv_SdtSYS_InstituteUserRole_Initialized ;
      private String gxTv_SdtSYS_InstituteUserRole_Mode ;
      private String gxTv_SdtSYS_InstituteUserRole_Sys_instituteuserroleinstitutecode ;
      private String gxTv_SdtSYS_InstituteUserRole_Sys_instituteuserroleinstitutecode_Z ;
      private Guid gxTv_SdtSYS_InstituteUserRole_Sys_instituteuserroleuserroleid ;
      private Guid gxTv_SdtSYS_InstituteUserRole_Sys_instituteuserroleroleid ;
      private Guid gxTv_SdtSYS_InstituteUserRole_Sys_instituteuserroleuserid ;
      private Guid gxTv_SdtSYS_InstituteUserRole_Sys_instituteuserroleuserroleid_Z ;
      private Guid gxTv_SdtSYS_InstituteUserRole_Sys_instituteuserroleroleid_Z ;
      private Guid gxTv_SdtSYS_InstituteUserRole_Sys_instituteuserroleuserid_Z ;
   }

   [DataContract(Name = @"SYS_InstituteUserRole", Namespace = "DataAnalysisPlatform")]
   public class SdtSYS_InstituteUserRole_RESTInterface : GxGenericCollectionItem<SdtSYS_InstituteUserRole>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtSYS_InstituteUserRole_RESTInterface( ) : base()
      {
      }

      public SdtSYS_InstituteUserRole_RESTInterface( SdtSYS_InstituteUserRole psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "SYS_InstituteUserRoleUserRoleID" , Order = 0 )]
      [GxSeudo()]
      public Guid gxTpr_Sys_instituteuserroleuserroleid
      {
         get {
            return sdt.gxTpr_Sys_instituteuserroleuserroleid ;
         }

         set {
            sdt.gxTpr_Sys_instituteuserroleuserroleid = (Guid)(value);
         }

      }

      [DataMember( Name = "SYS_InstituteUserRoleRoleID" , Order = 1 )]
      [GxSeudo()]
      public Guid gxTpr_Sys_instituteuserroleroleid
      {
         get {
            return sdt.gxTpr_Sys_instituteuserroleroleid ;
         }

         set {
            sdt.gxTpr_Sys_instituteuserroleroleid = (Guid)(value);
         }

      }

      [DataMember( Name = "SYS_InstituteUserRoleInstituteCode" , Order = 2 )]
      [GxSeudo()]
      public String gxTpr_Sys_instituteuserroleinstitutecode
      {
         get {
            return sdt.gxTpr_Sys_instituteuserroleinstitutecode ;
         }

         set {
            sdt.gxTpr_Sys_instituteuserroleinstitutecode = value;
         }

      }

      [DataMember( Name = "SYS_InstituteUserRoleUserID" , Order = 3 )]
      [GxSeudo()]
      public Guid gxTpr_Sys_instituteuserroleuserid
      {
         get {
            return sdt.gxTpr_Sys_instituteuserroleuserid ;
         }

         set {
            sdt.gxTpr_Sys_instituteuserroleuserid = (Guid)(value);
         }

      }

      public SdtSYS_InstituteUserRole sdt
      {
         get {
            return (SdtSYS_InstituteUserRole)Sdt ;
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
            sdt = new SdtSYS_InstituteUserRole() ;
         }
      }

      [DataMember( Name = "gx_md5_hash", Order = 4 )]
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
