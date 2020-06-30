/*
               File: WWPBaseObjects.GetMenuAuthorizedOptions
        Description:
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 11:55:1.75
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
namespace GeneXus.Programs.wwpbaseobjects {
   public class getmenuauthorizedoptions : GXProcedure
   {
      public getmenuauthorizedoptions( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public getmenuauthorizedoptions( IGxContext context )
      {
         this.context = context;
         IsMain = false;
      }

      public void release( )
      {
      }

      public void execute( ref GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVelop_Menu_Item> aP0_DVelop_Menu )
      {
         this.AV9DVelop_Menu = aP0_DVelop_Menu;
         initialize();
         executePrivate();
         aP0_DVelop_Menu=this.AV9DVelop_Menu;
      }

      public GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVelop_Menu_Item> executeUdp( )
      {
         this.AV9DVelop_Menu = aP0_DVelop_Menu;
         initialize();
         executePrivate();
         aP0_DVelop_Menu=this.AV9DVelop_Menu;
         return AV9DVelop_Menu ;
      }

      public void executeSubmit( ref GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVelop_Menu_Item> aP0_DVelop_Menu )
      {
         getmenuauthorizedoptions objgetmenuauthorizedoptions;
         objgetmenuauthorizedoptions = new getmenuauthorizedoptions();
         objgetmenuauthorizedoptions.AV9DVelop_Menu = aP0_DVelop_Menu;
         objgetmenuauthorizedoptions.context.SetSubmitInitialConfig(context);
         objgetmenuauthorizedoptions.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objgetmenuauthorizedoptions);
         aP0_DVelop_Menu=this.AV9DVelop_Menu;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((getmenuauthorizedoptions)stateInfo).executePrivate();
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
         AV33GXV1 = 1;
         while ( AV33GXV1 <= AV9DVelop_Menu.Count )
         {
            AV10DVelop_Menu_Item = ((GeneXus.Programs.wwpbaseobjects.SdtDVelop_Menu_Item)AV9DVelop_Menu.Item(AV33GXV1));
            GXt_boolean1 = AV17Istrue;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  AV10DVelop_Menu_Item.gxTpr_Authorizationkey, out  GXt_boolean1) ;
            AV17Istrue = GXt_boolean1;
            if ( ! AV17Istrue )
            {
               AV14RemoveIds.Add(AV10DVelop_Menu_Item.gxTpr_Id, 0);
            }
            AV30y = 1;
            while ( AV30y <= AV10DVelop_Menu_Item.gxTpr_Subitems.Count )
            {
               AV29sonItem = ((GeneXus.Programs.wwpbaseobjects.SdtDVelop_Menu_Item)AV10DVelop_Menu_Item.gxTpr_Subitems.Item(AV30y));
               if ( ! new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context).executeUdp(  AV29sonItem.gxTpr_Authorizationkey) )
               {
                  AV14RemoveIds.Add(AV29sonItem.gxTpr_Id, 0);
               }
               AV30y = (short)(AV30y+1);
            }
            AV33GXV1 = (int)(AV33GXV1+1);
         }
         AV11i = 1;
         while ( AV11i <= AV14RemoveIds.Count )
         {
            AV13j = 1;
            while ( AV13j <= AV9DVelop_Menu.Count )
            {
               if ( StringUtil.StrCmp(StringUtil.Trim( ((GeneXus.Programs.wwpbaseobjects.SdtDVelop_Menu_Item)AV9DVelop_Menu.Item(AV13j)).gxTpr_Id), StringUtil.Trim( AV14RemoveIds.GetString(AV11i))) == 0 )
               {
                  AV9DVelop_Menu.RemoveItem(AV13j);
                  if (true) break;
               }
               AV34X = 1;
               while ( AV34X <= ((GeneXus.Programs.wwpbaseobjects.SdtDVelop_Menu_Item)AV9DVelop_Menu.Item(AV13j)).gxTpr_Subitems.Count )
               {
                  AV29sonItem = ((GeneXus.Programs.wwpbaseobjects.SdtDVelop_Menu_Item)((GeneXus.Programs.wwpbaseobjects.SdtDVelop_Menu_Item)AV9DVelop_Menu.Item(AV13j)).gxTpr_Subitems.Item(AV34X));
                  if ( StringUtil.StrCmp(StringUtil.Trim( AV29sonItem.gxTpr_Id), StringUtil.Trim( AV14RemoveIds.GetString(AV11i))) == 0 )
                  {
                     ((GeneXus.Programs.wwpbaseobjects.SdtDVelop_Menu_Item)AV9DVelop_Menu.Item(AV13j)).gxTpr_Subitems.RemoveItem(AV34X);
                  }
                  AV34X = (short)(AV34X+1);
               }
               AV13j = (short)(AV13j+1);
            }
            AV11i = (short)(AV11i+1);
         }
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
         AV10DVelop_Menu_Item = new GeneXus.Programs.wwpbaseobjects.SdtDVelop_Menu_Item(context);
         AV14RemoveIds = new GxSimpleCollection<String>();
         AV29sonItem = new GeneXus.Programs.wwpbaseobjects.SdtDVelop_Menu_Item(context);
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV30y ;
      private short AV11i ;
      private short AV13j ;
      private short AV34X ;
      private int AV33GXV1 ;
      private bool AV17Istrue ;
      private bool GXt_boolean1 ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVelop_Menu_Item> aP0_DVelop_Menu ;
      private GxSimpleCollection<String> AV14RemoveIds ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVelop_Menu_Item> AV9DVelop_Menu ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVelop_Menu_Item AV10DVelop_Menu_Item ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVelop_Menu_Item AV29sonItem ;
   }

}
