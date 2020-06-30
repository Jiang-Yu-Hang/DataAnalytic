/*
               File: WB_Logout
        Description: 退出的方法
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 11:55:18.24
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
   public class wb_logout : GXProcedure
   {
      public wb_logout( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public wb_logout( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( out short aP0_tSetFlag )
      {
         this.AV9tSetFlag = 0 ;
         initialize();
         executePrivate();
         aP0_tSetFlag=this.AV9tSetFlag;
      }

      public short executeUdp( )
      {
         this.AV9tSetFlag = 0 ;
         initialize();
         executePrivate();
         aP0_tSetFlag=this.AV9tSetFlag;
         return AV9tSetFlag ;
      }

      public void executeSubmit( out short aP0_tSetFlag )
      {
         wb_logout objwb_logout;
         objwb_logout = new wb_logout();
         objwb_logout.AV9tSetFlag = 0 ;
         objwb_logout.context.SetSubmitInitialConfig(context);
         objwb_logout.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objwb_logout);
         aP0_tSetFlag=this.AV9tSetFlag;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((wb_logout)stateInfo).executePrivate();
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
         AV10tNowDate = DateTimeUtil.ServerNow( context, pr_default);
         AV11tJWTTokenContent = "";
         AV15tAllCookieName.FromJSonString(new zutil_getallcookiename(context).executeUdp( ), null);
         AV18I = 1;
         while ( AV18I <= AV15tAllCookieName.Count )
         {
            if ( ( StringUtil.StrCmp(StringUtil.Trim( ((String)AV15tAllCookieName.Item(AV18I))), "GX_CLIENT_ID") != 0 ) && ( StringUtil.StrCmp(StringUtil.Trim( ((String)AV15tAllCookieName.Item(AV18I))), "GX_SESSION_ID") != 0 ) && ( StringUtil.StrCmp(StringUtil.Trim( ((String)AV15tAllCookieName.Item(AV18I))), "GxTZOffset") != 0 ) )
            {
               AV9tSetFlag = context.SetCookie( ((String)AV15tAllCookieName.Item(AV18I)), "", "/", DateTimeUtil.TAdd( AV10tNowDate, 86400*(-5)), "", 0);
            }
            AV18I = (short)(AV18I+1);
         }
         AV14websession.Clear();
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
         AV10tNowDate = (DateTime)(DateTime.MinValue);
         AV11tJWTTokenContent = "";
         AV15tAllCookieName = new GxSimpleCollection<String>();
         AV14websession = context.GetSession();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.wb_logout__default(),
            new Object[][] {
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV9tSetFlag ;
      private short AV18I ;
      private DateTime AV10tNowDate ;
      private String AV11tJWTTokenContent ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short aP0_tSetFlag ;
      private IGxSession AV14websession ;
      private GxSimpleCollection<String> AV15tAllCookieName ;
   }

   public class wb_logout__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          def= new CursorDef[] {
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
       }
    }

 }

}
