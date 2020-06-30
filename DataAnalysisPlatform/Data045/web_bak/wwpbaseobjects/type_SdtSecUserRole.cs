/*
               File: wwpbaseobjects.type_SdtSecUserRole
        Description: 用户角色关系表
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:35:52.72
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
namespace GeneXus.Programs.wwpbaseobjects {
   [XmlSerializerFormat]
   [XmlRoot(ElementName = "SecUserRole" )]
   [XmlType(TypeName =  "SecUserRole" , Namespace = "DataAnalysisPlatform" )]
   [Serializable]
   public class SdtSecUserRole : GxSilentTrnSdt, System.Web.SessionState.IRequiresSessionState
   {
      public SdtSecUserRole( )
      {
      }

      public SdtSecUserRole( IGxContext context )
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

      public void Load( short AV6SecUserId ,
                        short AV4SecRoleId )
      {
         IGxSilentTrn obj ;
         obj = getTransaction();
         obj.LoadKey(new Object[] {(short)AV6SecUserId,(short)AV4SecRoleId});
         return  ;
      }

      public override Object[][] GetBCKey( )
      {
         return (Object[][])(new Object[][]{new Object[]{"SecUserId", typeof(short)}, new Object[]{"SecRoleId", typeof(short)}}) ;
      }

      public override GXProperties GetMetadata( )
      {
         GXProperties metadata = new GXProperties() ;
         metadata.Set("Name", "WWPBaseObjects\\SecUserRole");
         metadata.Set("BT", "SecUserRole");
         metadata.Set("PK", "[ \"SecUserId\",\"SecRoleId\" ]");
         metadata.Set("FKList", "[ { \"FK\":[ \"SecRoleId\" ],\"FKMap\":[  ] },{ \"FK\":[ \"SecUserId\" ],\"FKMap\":[  ] } ]");
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
         state.Add("gxTpr_Secuserid_Z");
         state.Add("gxTpr_Secroleid_Z");
         state.Add("gxTpr_Secusername_Z");
         state.Add("gxTpr_Secrolename_Z");
         state.Add("gxTpr_Secroledescription_Z");
         return state ;
      }

      public override void Copy( GxUserType source )
      {
         GeneXus.Programs.wwpbaseobjects.SdtSecUserRole sdt ;
         sdt = (GeneXus.Programs.wwpbaseobjects.SdtSecUserRole)(source);
         gxTv_SdtSecUserRole_Secuserid = sdt.gxTv_SdtSecUserRole_Secuserid ;
         gxTv_SdtSecUserRole_Secroleid = sdt.gxTv_SdtSecUserRole_Secroleid ;
         gxTv_SdtSecUserRole_Secusername = sdt.gxTv_SdtSecUserRole_Secusername ;
         gxTv_SdtSecUserRole_Secrolename = sdt.gxTv_SdtSecUserRole_Secrolename ;
         gxTv_SdtSecUserRole_Secroledescription = sdt.gxTv_SdtSecUserRole_Secroledescription ;
         gxTv_SdtSecUserRole_Mode = sdt.gxTv_SdtSecUserRole_Mode ;
         gxTv_SdtSecUserRole_Initialized = sdt.gxTv_SdtSecUserRole_Initialized ;
         gxTv_SdtSecUserRole_Secuserid_Z = sdt.gxTv_SdtSecUserRole_Secuserid_Z ;
         gxTv_SdtSecUserRole_Secroleid_Z = sdt.gxTv_SdtSecUserRole_Secroleid_Z ;
         gxTv_SdtSecUserRole_Secusername_Z = sdt.gxTv_SdtSecUserRole_Secusername_Z ;
         gxTv_SdtSecUserRole_Secrolename_Z = sdt.gxTv_SdtSecUserRole_Secrolename_Z ;
         gxTv_SdtSecUserRole_Secroledescription_Z = sdt.gxTv_SdtSecUserRole_Secroledescription_Z ;
         return  ;
      }

      public override void ToJSON( )
      {
         ToJSON( true) ;
         return  ;
      }

      public override void ToJSON( bool includeState )
      {
         AddObjectProperty("SecUserId", gxTv_SdtSecUserRole_Secuserid, false);
         AddObjectProperty("SecRoleId", gxTv_SdtSecUserRole_Secroleid, false);
         AddObjectProperty("SecUserName", gxTv_SdtSecUserRole_Secusername, false);
         AddObjectProperty("SecRoleName", gxTv_SdtSecUserRole_Secrolename, false);
         AddObjectProperty("SecRoleDescription", gxTv_SdtSecUserRole_Secroledescription, false);
         if ( includeState )
         {
            AddObjectProperty("Mode", gxTv_SdtSecUserRole_Mode, false);
            AddObjectProperty("Initialized", gxTv_SdtSecUserRole_Initialized, false);
            AddObjectProperty("SecUserId_Z", gxTv_SdtSecUserRole_Secuserid_Z, false);
            AddObjectProperty("SecRoleId_Z", gxTv_SdtSecUserRole_Secroleid_Z, false);
            AddObjectProperty("SecUserName_Z", gxTv_SdtSecUserRole_Secusername_Z, false);
            AddObjectProperty("SecRoleName_Z", gxTv_SdtSecUserRole_Secrolename_Z, false);
            AddObjectProperty("SecRoleDescription_Z", gxTv_SdtSecUserRole_Secroledescription_Z, false);
         }
         return  ;
      }

      public void UpdateDirties( GeneXus.Programs.wwpbaseobjects.SdtSecUserRole sdt )
      {
         if ( sdt.IsDirty("SecUserId") )
         {
            gxTv_SdtSecUserRole_Secuserid = sdt.gxTv_SdtSecUserRole_Secuserid ;
         }
         if ( sdt.IsDirty("SecRoleId") )
         {
            gxTv_SdtSecUserRole_Secroleid = sdt.gxTv_SdtSecUserRole_Secroleid ;
         }
         if ( sdt.IsDirty("SecUserName") )
         {
            gxTv_SdtSecUserRole_Secusername = sdt.gxTv_SdtSecUserRole_Secusername ;
         }
         if ( sdt.IsDirty("SecRoleName") )
         {
            gxTv_SdtSecUserRole_Secrolename = sdt.gxTv_SdtSecUserRole_Secrolename ;
         }
         if ( sdt.IsDirty("SecRoleDescription") )
         {
            gxTv_SdtSecUserRole_Secroledescription = sdt.gxTv_SdtSecUserRole_Secroledescription ;
         }
         return  ;
      }

      [  SoapElement( ElementName = "SecUserId" )]
      [  XmlElement( ElementName = "SecUserId"   )]
      public short gxTpr_Secuserid
      {
         get {
            return gxTv_SdtSecUserRole_Secuserid ;
         }

         set {
            if ( gxTv_SdtSecUserRole_Secuserid != value )
            {
               gxTv_SdtSecUserRole_Mode = "INS";
               this.gxTv_SdtSecUserRole_Secuserid_Z_SetNull( );
               this.gxTv_SdtSecUserRole_Secroleid_Z_SetNull( );
               this.gxTv_SdtSecUserRole_Secusername_Z_SetNull( );
               this.gxTv_SdtSecUserRole_Secrolename_Z_SetNull( );
               this.gxTv_SdtSecUserRole_Secroledescription_Z_SetNull( );
            }
            gxTv_SdtSecUserRole_Secuserid = value;
            SetDirty("Secuserid");
         }

      }

      [  SoapElement( ElementName = "SecRoleId" )]
      [  XmlElement( ElementName = "SecRoleId"   )]
      public short gxTpr_Secroleid
      {
         get {
            return gxTv_SdtSecUserRole_Secroleid ;
         }

         set {
            if ( gxTv_SdtSecUserRole_Secroleid != value )
            {
               gxTv_SdtSecUserRole_Mode = "INS";
               this.gxTv_SdtSecUserRole_Secuserid_Z_SetNull( );
               this.gxTv_SdtSecUserRole_Secroleid_Z_SetNull( );
               this.gxTv_SdtSecUserRole_Secusername_Z_SetNull( );
               this.gxTv_SdtSecUserRole_Secrolename_Z_SetNull( );
               this.gxTv_SdtSecUserRole_Secroledescription_Z_SetNull( );
            }
            gxTv_SdtSecUserRole_Secroleid = value;
            SetDirty("Secroleid");
         }

      }

      [  SoapElement( ElementName = "SecUserName" )]
      [  XmlElement( ElementName = "SecUserName"   )]
      public String gxTpr_Secusername
      {
         get {
            return gxTv_SdtSecUserRole_Secusername ;
         }

         set {
            gxTv_SdtSecUserRole_Secusername = value;
            SetDirty("Secusername");
         }

      }

      [  SoapElement( ElementName = "SecRoleName" )]
      [  XmlElement( ElementName = "SecRoleName"   )]
      public String gxTpr_Secrolename
      {
         get {
            return gxTv_SdtSecUserRole_Secrolename ;
         }

         set {
            gxTv_SdtSecUserRole_Secrolename = value;
            SetDirty("Secrolename");
         }

      }

      [  SoapElement( ElementName = "SecRoleDescription" )]
      [  XmlElement( ElementName = "SecRoleDescription"   )]
      public String gxTpr_Secroledescription
      {
         get {
            return gxTv_SdtSecUserRole_Secroledescription ;
         }

         set {
            gxTv_SdtSecUserRole_Secroledescription = value;
            SetDirty("Secroledescription");
         }

      }

      [  SoapElement( ElementName = "Mode" )]
      [  XmlElement( ElementName = "Mode"   )]
      public String gxTpr_Mode
      {
         get {
            return gxTv_SdtSecUserRole_Mode ;
         }

         set {
            gxTv_SdtSecUserRole_Mode = value;
            SetDirty("Mode");
         }

      }

      public void gxTv_SdtSecUserRole_Mode_SetNull( )
      {
         gxTv_SdtSecUserRole_Mode = "";
         return  ;
      }

      public bool gxTv_SdtSecUserRole_Mode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Initialized" )]
      [  XmlElement( ElementName = "Initialized"   )]
      public short gxTpr_Initialized
      {
         get {
            return gxTv_SdtSecUserRole_Initialized ;
         }

         set {
            gxTv_SdtSecUserRole_Initialized = value;
            SetDirty("Initialized");
         }

      }

      public void gxTv_SdtSecUserRole_Initialized_SetNull( )
      {
         gxTv_SdtSecUserRole_Initialized = 0;
         return  ;
      }

      public bool gxTv_SdtSecUserRole_Initialized_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SecUserId_Z" )]
      [  XmlElement( ElementName = "SecUserId_Z"   )]
      public short gxTpr_Secuserid_Z
      {
         get {
            return gxTv_SdtSecUserRole_Secuserid_Z ;
         }

         set {
            gxTv_SdtSecUserRole_Secuserid_Z = value;
            SetDirty("Secuserid_Z");
         }

      }

      public void gxTv_SdtSecUserRole_Secuserid_Z_SetNull( )
      {
         gxTv_SdtSecUserRole_Secuserid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtSecUserRole_Secuserid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SecRoleId_Z" )]
      [  XmlElement( ElementName = "SecRoleId_Z"   )]
      public short gxTpr_Secroleid_Z
      {
         get {
            return gxTv_SdtSecUserRole_Secroleid_Z ;
         }

         set {
            gxTv_SdtSecUserRole_Secroleid_Z = value;
            SetDirty("Secroleid_Z");
         }

      }

      public void gxTv_SdtSecUserRole_Secroleid_Z_SetNull( )
      {
         gxTv_SdtSecUserRole_Secroleid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtSecUserRole_Secroleid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SecUserName_Z" )]
      [  XmlElement( ElementName = "SecUserName_Z"   )]
      public String gxTpr_Secusername_Z
      {
         get {
            return gxTv_SdtSecUserRole_Secusername_Z ;
         }

         set {
            gxTv_SdtSecUserRole_Secusername_Z = value;
            SetDirty("Secusername_Z");
         }

      }

      public void gxTv_SdtSecUserRole_Secusername_Z_SetNull( )
      {
         gxTv_SdtSecUserRole_Secusername_Z = "";
         return  ;
      }

      public bool gxTv_SdtSecUserRole_Secusername_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SecRoleName_Z" )]
      [  XmlElement( ElementName = "SecRoleName_Z"   )]
      public String gxTpr_Secrolename_Z
      {
         get {
            return gxTv_SdtSecUserRole_Secrolename_Z ;
         }

         set {
            gxTv_SdtSecUserRole_Secrolename_Z = value;
            SetDirty("Secrolename_Z");
         }

      }

      public void gxTv_SdtSecUserRole_Secrolename_Z_SetNull( )
      {
         gxTv_SdtSecUserRole_Secrolename_Z = "";
         return  ;
      }

      public bool gxTv_SdtSecUserRole_Secrolename_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SecRoleDescription_Z" )]
      [  XmlElement( ElementName = "SecRoleDescription_Z"   )]
      public String gxTpr_Secroledescription_Z
      {
         get {
            return gxTv_SdtSecUserRole_Secroledescription_Z ;
         }

         set {
            gxTv_SdtSecUserRole_Secroledescription_Z = value;
            SetDirty("Secroledescription_Z");
         }

      }

      public void gxTv_SdtSecUserRole_Secroledescription_Z_SetNull( )
      {
         gxTv_SdtSecUserRole_Secroledescription_Z = "";
         return  ;
      }

      public bool gxTv_SdtSecUserRole_Secroledescription_Z_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_SdtSecUserRole_Secusername = "";
         gxTv_SdtSecUserRole_Secrolename = "";
         gxTv_SdtSecUserRole_Secroledescription = "";
         gxTv_SdtSecUserRole_Mode = "";
         gxTv_SdtSecUserRole_Secusername_Z = "";
         gxTv_SdtSecUserRole_Secrolename_Z = "";
         gxTv_SdtSecUserRole_Secroledescription_Z = "";
         IGxSilentTrn obj ;
         obj = (IGxSilentTrn)ClassLoader.FindInstance( "secuserrole", "GeneXus.Programs.wwpbaseobjects.secuserrole_bc", new Object[] {context}, constructorCallingAssembly);;
         obj.initialize();
         obj.SetSDT(this, 1);
         setTransaction( obj) ;
         obj.SetMode("INS");
         return  ;
      }

      private short gxTv_SdtSecUserRole_Secuserid ;
      private short gxTv_SdtSecUserRole_Secroleid ;
      private short gxTv_SdtSecUserRole_Initialized ;
      private short gxTv_SdtSecUserRole_Secuserid_Z ;
      private short gxTv_SdtSecUserRole_Secroleid_Z ;
      private String gxTv_SdtSecUserRole_Mode ;
      private String gxTv_SdtSecUserRole_Secusername ;
      private String gxTv_SdtSecUserRole_Secrolename ;
      private String gxTv_SdtSecUserRole_Secroledescription ;
      private String gxTv_SdtSecUserRole_Secusername_Z ;
      private String gxTv_SdtSecUserRole_Secrolename_Z ;
      private String gxTv_SdtSecUserRole_Secroledescription_Z ;
   }

   [DataContract(Name = @"WWPBaseObjects\SecUserRole", Namespace = "DataAnalysisPlatform")]
   public class SdtSecUserRole_RESTInterface : GxGenericCollectionItem<GeneXus.Programs.wwpbaseobjects.SdtSecUserRole>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtSecUserRole_RESTInterface( ) : base()
      {
      }

      public SdtSecUserRole_RESTInterface( GeneXus.Programs.wwpbaseobjects.SdtSecUserRole psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "SecUserId" , Order = 0 )]
      [GxSeudo()]
      public Nullable<short> gxTpr_Secuserid
      {
         get {
            return sdt.gxTpr_Secuserid ;
         }

         set {
            sdt.gxTpr_Secuserid = (short)(value.HasValue ? value.Value : 0);
         }

      }

      [DataMember( Name = "SecRoleId" , Order = 1 )]
      [GxSeudo()]
      public Nullable<short> gxTpr_Secroleid
      {
         get {
            return sdt.gxTpr_Secroleid ;
         }

         set {
            sdt.gxTpr_Secroleid = (short)(value.HasValue ? value.Value : 0);
         }

      }

      [DataMember( Name = "SecUserName" , Order = 2 )]
      [GxSeudo()]
      public String gxTpr_Secusername
      {
         get {
            return sdt.gxTpr_Secusername ;
         }

         set {
            sdt.gxTpr_Secusername = value;
         }

      }

      [DataMember( Name = "SecRoleName" , Order = 3 )]
      [GxSeudo()]
      public String gxTpr_Secrolename
      {
         get {
            return sdt.gxTpr_Secrolename ;
         }

         set {
            sdt.gxTpr_Secrolename = value;
         }

      }

      [DataMember( Name = "SecRoleDescription" , Order = 4 )]
      [GxSeudo()]
      public String gxTpr_Secroledescription
      {
         get {
            return sdt.gxTpr_Secroledescription ;
         }

         set {
            sdt.gxTpr_Secroledescription = value;
         }

      }

      public GeneXus.Programs.wwpbaseobjects.SdtSecUserRole sdt
      {
         get {
            return (GeneXus.Programs.wwpbaseobjects.SdtSecUserRole)Sdt ;
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
            sdt = new GeneXus.Programs.wwpbaseobjects.SdtSecUserRole() ;
         }
      }

      [DataMember( Name = "gx_md5_hash", Order = 5 )]
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
