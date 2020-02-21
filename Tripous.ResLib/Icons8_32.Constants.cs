/*--------------------------------------------------------------------------------------        
                           Copyright © 2013 Theodoros Bebekis
                               teo.bebekis@gmail.com 
--------------------------------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Reflection;
using System.Drawing;

namespace Tripous
{


        /// <summary>
        /// A list of button image constants
        /// </summary>
        static public partial class Icons8_32
        {
            #region Constants

            /// <summary>
            /// Constant
            /// </summary>
            public const string Accommodation_Apartment = "Tripous.ResLib.Icons8_32x32.Icons8_Accommodation_apartment.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Accommodation_Barn = "Tripous.ResLib.Icons8_32x32.Icons8_Accommodation_barn.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Accommodation_Bungalow = "Tripous.ResLib.Icons8_32x32.Icons8_Accommodation_bungalow.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Accommodation_Cottage = "Tripous.ResLib.Icons8_32x32.Icons8_Accommodation_cottage.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Accommodation_Hot_Tube = "Tripous.ResLib.Icons8_32x32.Icons8_Accommodation_hot_tube.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Accommodation_Jacuzzi = "Tripous.ResLib.Icons8_32x32.Icons8_Accommodation_jacuzzi.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Accommodation_Log_Cabin = "Tripous.ResLib.Icons8_32x32.Icons8_Accommodation_log_cabin.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Accommodation_Mobile_Home = "Tripous.ResLib.Icons8_32x32.Icons8_Accommodation_mobile_home.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Accounting_Bill = "Tripous.ResLib.Icons8_32x32.Icons8_Accounting_bill.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Accounting_Check = "Tripous.ResLib.Icons8_32x32.Icons8_Accounting_check.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Accounting_Invoice = "Tripous.ResLib.Icons8_32x32.Icons8_Accounting_invoice.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Accounting_Order = "Tripous.ResLib.Icons8_32x32.Icons8_Accounting_Order.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Add_Delete_Link = "Tripous.ResLib.Icons8_32x32.Icons8_Add_delete_link.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Add_File = "Tripous.ResLib.Icons8_32x32.Icons8_add_file.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Add_Folder = "Tripous.ResLib.Icons8_32x32.Icons8_add_folder.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Add_Link = "Tripous.ResLib.Icons8_32x32.Icons8_add_link.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Add_List = "Tripous.ResLib.Icons8_32x32.Icons8_add_list.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Adobe_Ai = "Tripous.ResLib.Icons8_32x32.Icons8_Adobe_ai.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Adobe_Br = "Tripous.ResLib.Icons8_32x32.Icons8_Adobe_br.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Adobe_Dw = "Tripous.ResLib.Icons8_32x32.Icons8_Adobe_dw.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Adobe_Fl = "Tripous.ResLib.Icons8_32x32.Icons8_Adobe_fl.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Adobe_Fw = "Tripous.ResLib.Icons8_32x32.Icons8_Adobe_fw.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Adobe_Id = "Tripous.ResLib.Icons8_32x32.Icons8_Adobe_id.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Adobe_Ps = "Tripous.ResLib.Icons8_32x32.Icons8_Adobe_ps.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Alien_Grey = "Tripous.ResLib.Icons8_32x32.Icons8_Alien_grey.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Alien_Martian = "Tripous.ResLib.Icons8_32x32.Icons8_Alien_martian.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Alien_Predator = "Tripous.ResLib.Icons8_32x32.Icons8_Alien_predator.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Alphabet_A = "Tripous.ResLib.Icons8_32x32.Icons8_Alphabet_A.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Alphabet_B = "Tripous.ResLib.Icons8_32x32.Icons8_Alphabet_B.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Alphabet_C = "Tripous.ResLib.Icons8_32x32.Icons8_Alphabet_C.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Alphabet_D = "Tripous.ResLib.Icons8_32x32.Icons8_Alphabet_D.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Alphabet_E = "Tripous.ResLib.Icons8_32x32.Icons8_Alphabet_E.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Alphabet_F = "Tripous.ResLib.Icons8_32x32.Icons8_Alphabet_F.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Alphabet_G = "Tripous.ResLib.Icons8_32x32.Icons8_Alphabet_G.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Alphabet_H = "Tripous.ResLib.Icons8_32x32.Icons8_Alphabet_H.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Alphabet_I = "Tripous.ResLib.Icons8_32x32.Icons8_Alphabet_I.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Alphabet_J = "Tripous.ResLib.Icons8_32x32.Icons8_Alphabet_J.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Alphabet_K = "Tripous.ResLib.Icons8_32x32.Icons8_Alphabet_K.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Alphabet_L = "Tripous.ResLib.Icons8_32x32.Icons8_Alphabet_L.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Alphabet_M = "Tripous.ResLib.Icons8_32x32.Icons8_Alphabet_M.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Alphabet_N = "Tripous.ResLib.Icons8_32x32.Icons8_Alphabet_N.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Alphabet_O = "Tripous.ResLib.Icons8_32x32.Icons8_Alphabet_O.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Alphabet_P = "Tripous.ResLib.Icons8_32x32.Icons8_Alphabet_P.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Alphabet_Q = "Tripous.ResLib.Icons8_32x32.Icons8_Alphabet_Q.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Alphabet_R = "Tripous.ResLib.Icons8_32x32.Icons8_Alphabet_R.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Alphabet_S = "Tripous.ResLib.Icons8_32x32.Icons8_Alphabet_S.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Alphabet_T = "Tripous.ResLib.Icons8_32x32.Icons8_Alphabet_T.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Alphabet_U = "Tripous.ResLib.Icons8_32x32.Icons8_Alphabet_U.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Alphabet_V = "Tripous.ResLib.Icons8_32x32.Icons8_Alphabet_V.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Alphabet_W = "Tripous.ResLib.Icons8_32x32.Icons8_Alphabet_W.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Alphabet_X = "Tripous.ResLib.Icons8_32x32.Icons8_Alphabet_X.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Alphabet_Y = "Tripous.ResLib.Icons8_32x32.Icons8_Alphabet_Y.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Alphabet_Z = "Tripous.ResLib.Icons8_32x32.Icons8_Alphabet_Z.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Animal_Chiken = "Tripous.ResLib.Icons8_32x32.Icons8_Animal_chiken.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Animal_Cow = "Tripous.ResLib.Icons8_32x32.Icons8_Animal_cow.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Animal_Crab = "Tripous.ResLib.Icons8_32x32.Icons8_Animal_crab.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Animal_Duck = "Tripous.ResLib.Icons8_32x32.Icons8_Animal_duck.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Animal_Fish = "Tripous.ResLib.Icons8_32x32.Icons8_Animal_fish.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Animal_Pig = "Tripous.ResLib.Icons8_32x32.Icons8_Animal_pig.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Animal_Prawn = "Tripous.ResLib.Icons8_32x32.Icons8_Animal_prawn.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Animal_Sheep = "Tripous.ResLib.Icons8_32x32.Icons8_Animal_sheep.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Animal_Sheep_On_Bike = "Tripous.ResLib.Icons8_32x32.Icons8_Animal_sheep_on_bike.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Animal_Sheep2 = "Tripous.ResLib.Icons8_32x32.Icons8_Animal_sheep2.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Appliance_Armchair = "Tripous.ResLib.Icons8_32x32.Icons8_Appliance_armchair.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Appliance_Bed = "Tripous.ResLib.Icons8_32x32.Icons8_Appliance_bed.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Appliance_Channel_Mosaic = "Tripous.ResLib.Icons8_32x32.Icons8_Appliance_channel_mosaic.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Appliance_Coffe_Maker = "Tripous.ResLib.Icons8_32x32.Icons8_Appliance_coffe_maker.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Appliance_Commode = "Tripous.ResLib.Icons8_32x32.Icons8_Appliance_commode.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Appliance_Electric_Teapot = "Tripous.ResLib.Icons8_32x32.Icons8_Appliance_electric_teapot.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Appliance_Fan = "Tripous.ResLib.Icons8_32x32.Icons8_Appliance_fan.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Appliance_Hdtv = "Tripous.ResLib.Icons8_32x32.Icons8_Appliance_hdtv.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Appliance_Iron = "Tripous.ResLib.Icons8_32x32.Icons8_Appliance_iron.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Appliance_Lamp = "Tripous.ResLib.Icons8_32x32.Icons8_Appliance_lamp.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Appliance_Mixer = "Tripous.ResLib.Icons8_32x32.Icons8_Appliance_mixer.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Appliance_Sdtv = "Tripous.ResLib.Icons8_32x32.Icons8_Appliance_sdtv.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Appliance_Sofa = "Tripous.ResLib.Icons8_32x32.Icons8_Appliance_sofa.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Appliance_Table = "Tripous.ResLib.Icons8_32x32.Icons8_Appliance_table.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Appliance_Tabletop_Radio = "Tripous.ResLib.Icons8_32x32.Icons8_Appliance_tabletop_radio.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Appliance_Tv = "Tripous.ResLib.Icons8_32x32.Icons8_Appliance_tv.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Appliance_Wardrobe = "Tripous.ResLib.Icons8_32x32.Icons8_Appliance_wardrobe.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Appliance_Washing_Machine = "Tripous.ResLib.Icons8_32x32.Icons8_Appliance_washing_machine.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Appliance_Widescreen_Tv = "Tripous.ResLib.Icons8_32x32.Icons8_Appliance_widescreen_tv.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Arrow_Down = "Tripous.ResLib.Icons8_32x32.Icons8_Arrow_down.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Arrow_Down_Circular = "Tripous.ResLib.Icons8_32x32.Icons8_Arrow_down_circular.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Arrow_Left = "Tripous.ResLib.Icons8_32x32.Icons8_Arrow_left.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Arrow_Left_Circular = "Tripous.ResLib.Icons8_32x32.Icons8_Arrow_left_circular.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Arrow_Left_Round = "Tripous.ResLib.Icons8_32x32.Icons8_Arrow_left_round.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Arrow_Right = "Tripous.ResLib.Icons8_32x32.Icons8_Arrow_right.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Arrow_Right_Circular = "Tripous.ResLib.Icons8_32x32.Icons8_Arrow_right_circular.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Arrow_Right_Round = "Tripous.ResLib.Icons8_32x32.Icons8_Arrow_right_round.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Arrow_Up = "Tripous.ResLib.Icons8_32x32.Icons8_Arrow_up.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Arrow_Up_Circular = "Tripous.ResLib.Icons8_32x32.Icons8_Arrow_up_circular.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Baby = "Tripous.ResLib.Icons8_32x32.Icons8_baby.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Baby_Bib = "Tripous.ResLib.Icons8_32x32.Icons8_Baby_bib.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Baby_Bottle = "Tripous.ResLib.Icons8_32x32.Icons8_Baby_bottle.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Baby_Brick = "Tripous.ResLib.Icons8_32x32.Icons8_Baby_brick.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Baby_Crib = "Tripous.ResLib.Icons8_32x32.Icons8_Baby_crib.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Baby_Crying_Baby = "Tripous.ResLib.Icons8_32x32.Icons8_Baby_crying_baby.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Baby_Feet = "Tripous.ResLib.Icons8_32x32.Icons8_baby_feet.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Baby_Flying_Stork = "Tripous.ResLib.Icons8_32x32.Icons8_Baby_flying_stork.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Baby_Flying_Stork_With_Bundle = "Tripous.ResLib.Icons8_32x32.Icons8_Baby_flying_stork_with_bundle.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Baby_Nappy = "Tripous.ResLib.Icons8_32x32.Icons8_Baby_nappy.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Baby_Pacifier = "Tripous.ResLib.Icons8_32x32.Icons8_Baby_pacifier.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Baby_Powder = "Tripous.ResLib.Icons8_32x32.Icons8_Baby_powder.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Baby_Rattle = "Tripous.ResLib.Icons8_32x32.Icons8_Baby_rattle.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Baby_Romper = "Tripous.ResLib.Icons8_32x32.Icons8_Baby_romper.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Baby_Stork = "Tripous.ResLib.Icons8_32x32.Icons8_Baby_stork.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Baby_Stork_With_Bundle = "Tripous.ResLib.Icons8_32x32.Icons8_Baby_stork_with_bundle.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Baby_Stroller = "Tripous.ResLib.Icons8_32x32.Icons8_Baby_stroller.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Baby_Teddybear = "Tripous.ResLib.Icons8_32x32.Icons8_Baby_teddybear.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Baby_Tricycle = "Tripous.ResLib.Icons8_32x32.Icons8_Baby_tricycle.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Basic_Address_Book = "Tripous.ResLib.Icons8_32x32.Icons8_Basic_address_book.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Basic_Audio_File = "Tripous.ResLib.Icons8_32x32.Icons8_Basic_audio_file.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Basic_Bookmark = "Tripous.ResLib.Icons8_32x32.Icons8_Basic_bookmark.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Basic_Broken_Link = "Tripous.ResLib.Icons8_32x32.Icons8_Basic_broken_link.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Basic_Calculator = "Tripous.ResLib.Icons8_32x32.Icons8_Basic_calculator.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Basic_Calendar = "Tripous.ResLib.Icons8_32x32.Icons8_Basic_calendar.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Basic_Cancel = "Tripous.ResLib.Icons8_32x32.Icons8_Basic_cancel.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Basic_Checked_Checkbox = "Tripous.ResLib.Icons8_32x32.Icons8_Basic_checked_checkbox.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Basic_Checkmark = "Tripous.ResLib.Icons8_32x32.Icons8_Basic_checkmark.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Basic_Clock = "Tripous.ResLib.Icons8_32x32.Icons8_Basic_clock.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Basic_Cursor = "Tripous.ResLib.Icons8_32x32.Icons8_Basic_cursor.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Basic_Document = "Tripous.ResLib.Icons8_32x32.Icons8_Basic_document.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Basic_Download = "Tripous.ResLib.Icons8_32x32.Icons8_Basic_download.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Basic_Empty_Trash = "Tripous.ResLib.Icons8_32x32.Icons8_Basic_empty_trash.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Basic_File = "Tripous.ResLib.Icons8_32x32.Icons8_Basic_file.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Basic_Folder = "Tripous.ResLib.Icons8_32x32.Icons8_Basic_folder.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Basic_Frame = "Tripous.ResLib.Icons8_32x32.Icons8_Basic_frame.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Basic_Full_Trash = "Tripous.ResLib.Icons8_32x32.Icons8_Basic_full_trash.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Basic_Globe = "Tripous.ResLib.Icons8_32x32.Icons8_Basic_globe.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Basic_Hand_Cursor = "Tripous.ResLib.Icons8_32x32.Icons8_Basic_hand_cursor.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Basic_Home = "Tripous.ResLib.Icons8_32x32.Icons8_Basic_home.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Basic_Image_File = "Tripous.ResLib.Icons8_32x32.Icons8_Basic_image_file.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Basic_Info = "Tripous.ResLib.Icons8_32x32.Icons8_Basic_info.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Basic_Key = "Tripous.ResLib.Icons8_32x32.Icons8_Basic_key.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Basic_Like = "Tripous.ResLib.Icons8_32x32.Icons8_Basic_like.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Basic_Like_Outline = "Tripous.ResLib.Icons8_32x32.Icons8_Basic_like_outline.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Basic_Link = "Tripous.ResLib.Icons8_32x32.Icons8_Basic_link.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Basic_Lock = "Tripous.ResLib.Icons8_32x32.Icons8_Basic_lock.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Basic_Minus = "Tripous.ResLib.Icons8_32x32.Icons8_Basic_minus.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Basic_Music = "Tripous.ResLib.Icons8_32x32.Icons8_Basic_music.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Basic_Ok = "Tripous.ResLib.Icons8_32x32.Icons8_Basic_ok.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Basic_Picture = "Tripous.ResLib.Icons8_32x32.Icons8_Basic_picture.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Basic_Plus = "Tripous.ResLib.Icons8_32x32.Icons8_Basic_plus.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Basic_Print = "Tripous.ResLib.Icons8_32x32.Icons8_Basic_print.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Basic_Puzzle = "Tripous.ResLib.Icons8_32x32.Icons8_Basic_puzzle.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Basic_Rating = "Tripous.ResLib.Icons8_32x32.Icons8_Basic_rating.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Basic_Redo = "Tripous.ResLib.Icons8_32x32.Icons8_Basic_redo.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Basic_Refresh = "Tripous.ResLib.Icons8_32x32.Icons8_Basic_refresh.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Basic_Ruler = "Tripous.ResLib.Icons8_32x32.Icons8_Basic_ruler.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Basic_Search = "Tripous.ResLib.Icons8_32x32.Icons8_Basic_search.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Basic_Settings = "Tripous.ResLib.Icons8_32x32.Icons8_Basic_settings.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Basic_Settings2 = "Tripous.ResLib.Icons8_32x32.Icons8_Basic_settings2.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Basic_Sinchronize = "Tripous.ResLib.Icons8_32x32.Icons8_Basic_sinchronize.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Basic_Unchecked_Checkbox = "Tripous.ResLib.Icons8_32x32.Icons8_Basic_unchecked_checkbox.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Basic_Undo = "Tripous.ResLib.Icons8_32x32.Icons8_Basic_undo.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Basic_Unlock = "Tripous.ResLib.Icons8_32x32.Icons8_Basic_unlock.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Basic_Upload = "Tripous.ResLib.Icons8_32x32.Icons8_Basic_upload.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Basic_Video_File = "Tripous.ResLib.Icons8_32x32.Icons8_Basic_video_file.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Battery_25_Percent = "Tripous.ResLib.Icons8_32x32.Icons8_Battery_25_percent.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Battery_50_Percent = "Tripous.ResLib.Icons8_32x32.Icons8_Battery_50_percent.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Battery_75_Percent = "Tripous.ResLib.Icons8_32x32.Icons8_Battery_75_percent.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Battery_Almost_Empty = "Tripous.ResLib.Icons8_32x32.Icons8_Battery_almost_empty.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Battery_Almost_Full = "Tripous.ResLib.Icons8_32x32.Icons8_Battery_almost_full.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Battery_Empty_Battery = "Tripous.ResLib.Icons8_32x32.Icons8_Battery_empty_battery.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Battery_Full = "Tripous.ResLib.Icons8_32x32.Icons8_Battery_Full.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Browser_Chrome = "Tripous.ResLib.Icons8_32x32.Icons8_Browser_chrome.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Browser_Firefox = "Tripous.ResLib.Icons8_32x32.Icons8_Browser_firefox.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Browser_Ie = "Tripous.ResLib.Icons8_32x32.Icons8_Browser_ie.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Browser_Netscape = "Tripous.ResLib.Icons8_32x32.Icons8_Browser_netscape.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Browser_Opera = "Tripous.ResLib.Icons8_32x32.Icons8_Browser_opera.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Browser_Safari = "Tripous.ResLib.Icons8_32x32.Icons8_Browser_safari.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Busines_Approval = "Tripous.ResLib.Icons8_32x32.Icons8_Busines_approval.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Busines_Assistant = "Tripous.ResLib.Icons8_32x32.Icons8_Busines_assistant.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Busines_Atm = "Tripous.ResLib.Icons8_32x32.Icons8_Busines_atm.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Busines_Briefcase = "Tripous.ResLib.Icons8_32x32.Icons8_Busines_briefcase.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Busines_Delivery = "Tripous.ResLib.Icons8_32x32.Icons8_Busines_delivery.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Busines_Diploma1 = "Tripous.ResLib.Icons8_32x32.Icons8_Busines_diploma1.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Busines_Diploma2 = "Tripous.ResLib.Icons8_32x32.Icons8_Busines_diploma2.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Busines_Graduation_Cap = "Tripous.ResLib.Icons8_32x32.Icons8_Busines_graduation_cap.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Busines_Money_Bag = "Tripous.ResLib.Icons8_32x32.Icons8_Busines_money_bag.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Busines_Organization = "Tripous.ResLib.Icons8_32x32.Icons8_Busines_organization.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Busines_Package = "Tripous.ResLib.Icons8_32x32.Icons8_Busines_package.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Busines_Parallel_Tasks = "Tripous.ResLib.Icons8_32x32.Icons8_Busines_parallel_tasks.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Busines_Reuse = "Tripous.ResLib.Icons8_32x32.Icons8_Busines_reuse.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Busines_Safe = "Tripous.ResLib.Icons8_32x32.Icons8_Busines_safe.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Busines_Sale = "Tripous.ResLib.Icons8_32x32.Icons8_Busines_sale.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Busines_Self_Service_Kiosk = "Tripous.ResLib.Icons8_32x32.Icons8_Busines_self_service_kiosk.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Busines_Serial_Tasks = "Tripous.ResLib.Icons8_32x32.Icons8_Busines_serial_tasks.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Busines_Shop = "Tripous.ResLib.Icons8_32x32.Icons8_Busines_shop.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Busines_Tree_Structure = "Tripous.ResLib.Icons8_32x32.Icons8_Busines_tree_structure.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Businessman = "Tripous.ResLib.Icons8_32x32.Icons8_businessman.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Businesswoman = "Tripous.ResLib.Icons8_32x32.Icons8_businesswoman.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Buzz_Activity_Feed = "Tripous.ResLib.Icons8_32x32.Icons8_Buzz_activity_feed.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Buzz_Appointment_Reminders = "Tripous.ResLib.Icons8_32x32.Icons8_Buzz_appointment_reminders.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Buzz_Categorize = "Tripous.ResLib.Icons8_32x32.Icons8_Buzz_categorize.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Buzz_Forward = "Tripous.ResLib.Icons8_32x32.Icons8_Buzz_forward.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Buzz_Gmail_Login = "Tripous.ResLib.Icons8_32x32.Icons8_Buzz_gmail_login.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Buzz_High_Importance = "Tripous.ResLib.Icons8_32x32.Icons8_Buzz_high_importance.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Buzz_Invisible = "Tripous.ResLib.Icons8_32x32.Icons8_Buzz_invisible.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Buzz_Low_Importance = "Tripous.ResLib.Icons8_32x32.Icons8_Buzz_low_importance.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Buzz_Message = "Tripous.ResLib.Icons8_32x32.Icons8_Buzz_message.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Buzz_Message_Outline = "Tripous.ResLib.Icons8_32x32.Icons8_Buzz_message_outline.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Buzz_Outline_Star = "Tripous.ResLib.Icons8_32x32.Icons8_Buzz_outline_star.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Buzz_Private = "Tripous.ResLib.Icons8_32x32.Icons8_Buzz_private.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Buzz_Read_Message = "Tripous.ResLib.Icons8_32x32.Icons8_Buzz_read_message.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Buzz_Recurring_Appointment = "Tripous.ResLib.Icons8_32x32.Icons8_Buzz_recurring_appointment.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Buzz_Reply = "Tripous.ResLib.Icons8_32x32.Icons8_Buzz_reply.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Buzz_Send_File = "Tripous.ResLib.Icons8_32x32.Icons8_Buzz_send_file.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Buzz_Speech_Bubble = "Tripous.ResLib.Icons8_32x32.Icons8_Buzz_speech_bubble.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Buzz_Star = "Tripous.ResLib.Icons8_32x32.Icons8_Buzz_star.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Buzz_Visible = "Tripous.ResLib.Icons8_32x32.Icons8_Buzz_visible.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Camping_Gaiters = "Tripous.ResLib.Icons8_32x32.Icons8_Camping_gaiters.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Camping_Hex_Burner = "Tripous.ResLib.Icons8_32x32.Icons8_Camping_hex_burner.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Camping_Matches = "Tripous.ResLib.Icons8_32x32.Icons8_Camping_matches.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Camping_Mess_Tin = "Tripous.ResLib.Icons8_32x32.Icons8_Camping_mess_tin.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Camping_Sleepin_Mat = "Tripous.ResLib.Icons8_32x32.Icons8_Camping_sleepin_mat.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Camping_Sleeping_Bag = "Tripous.ResLib.Icons8_32x32.Icons8_Camping_sleeping_bag.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Camping_Survival_Bag = "Tripous.ResLib.Icons8_32x32.Icons8_Camping_survival_bag.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Camping_Trangia_Stove = "Tripous.ResLib.Icons8_32x32.Icons8_Camping_trangia_stove.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Camping_Water_Bottle = "Tripous.ResLib.Icons8_32x32.Icons8_Camping_water_bottle.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Catering_Bar = "Tripous.ResLib.Icons8_32x32.Icons8_Catering_bar.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Catering_Cafe = "Tripous.ResLib.Icons8_32x32.Icons8_Catering_cafe.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Catering_Delivery = "Tripous.ResLib.Icons8_32x32.Icons8_Catering_Delivery.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Catering_Restaurant = "Tripous.ResLib.Icons8_32x32.Icons8_Catering_restaurant.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Cell_Phone_Android = "Tripous.ResLib.Icons8_32x32.Icons8_Cell_Phone_android.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Cell_Phone_Blackberry = "Tripous.ResLib.Icons8_32x32.Icons8_Cell_Phone_blackberry.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Cell_Phone_Iphone = "Tripous.ResLib.Icons8_32x32.Icons8_Cell_Phone_iphone.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Cell_Phone_Windows = "Tripous.ResLib.Icons8_32x32.Icons8_Cell_Phone_windows.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Chart_Area = "Tripous.ResLib.Icons8_32x32.Icons8_Chart_area.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Chart_Bar = "Tripous.ResLib.Icons8_32x32.Icons8_Chart_bar.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Chart_Combo = "Tripous.ResLib.Icons8_32x32.Icons8_Chart_combo.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Chart_Donat = "Tripous.ResLib.Icons8_32x32.Icons8_Chart_Donat.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Chart_Flow = "Tripous.ResLib.Icons8_32x32.Icons8_Chart_Flow.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Chart_Genealogy = "Tripous.ResLib.Icons8_32x32.Icons8_Chart_genealogy.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Chart_Heat_Map = "Tripous.ResLib.Icons8_32x32.Icons8_Chart_heat_map.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Chart_Line = "Tripous.ResLib.Icons8_32x32.Icons8_Chart_line.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Chart_Mind_Map = "Tripous.ResLib.Icons8_32x32.Icons8_Chart_mind_map.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Chart_Negative_Dynamic = "Tripous.ResLib.Icons8_32x32.Icons8_Chart_negative_dynamic.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Chart_Pie = "Tripous.ResLib.Icons8_32x32.Icons8_Chart_pie.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Chart_Positive_Dynamic = "Tripous.ResLib.Icons8_32x32.Icons8_Chart_positive_dynamic.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Chart_Radar_Plot = "Tripous.ResLib.Icons8_32x32.Icons8_Chart_radar_plot.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Chart_Scatter_Plot = "Tripous.ResLib.Icons8_32x32.Icons8_Chart_scatter_plot.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Chess_Bishop = "Tripous.ResLib.Icons8_32x32.Icons8_Chess_bishop.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Chess_King = "Tripous.ResLib.Icons8_32x32.Icons8_Chess_king.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Chess_Knight = "Tripous.ResLib.Icons8_32x32.Icons8_Chess_knight.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Chess_Pawn = "Tripous.ResLib.Icons8_32x32.Icons8_Chess_pawn.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Chess_Queen = "Tripous.ResLib.Icons8_32x32.Icons8_Chess_queen.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Chess_Rook = "Tripous.ResLib.Icons8_32x32.Icons8_Chess_rook.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string City_Airport = "Tripous.ResLib.Icons8_32x32.Icons8_City_airport.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string City_Bank = "Tripous.ResLib.Icons8_32x32.Icons8_City_bank.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string City_Church = "Tripous.ResLib.Icons8_32x32.Icons8_City_church.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string City_Gas_Station = "Tripous.ResLib.Icons8_32x32.Icons8_City_gas_station.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string City_Gps_Device = "Tripous.ResLib.Icons8_32x32.Icons8_City_gps_device.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string City_Hospital = "Tripous.ResLib.Icons8_32x32.Icons8_City_hospital.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string City_Hospital2 = "Tripous.ResLib.Icons8_32x32.Icons8_City_hospital2.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string City_Hotel = "Tripous.ResLib.Icons8_32x32.Icons8_City_hotel.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string City_Raiway_Station = "Tripous.ResLib.Icons8_32x32.Icons8_City_raiway_station.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string City_Restaurant = "Tripous.ResLib.Icons8_32x32.Icons8_City_restaurant.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string City_Stadium = "Tripous.ResLib.Icons8_32x32.Icons8_City_stadium.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Civilization_Ankh = "Tripous.ResLib.Icons8_32x32.Icons8_Civilization_ankh.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Civilization_Anubis = "Tripous.ResLib.Icons8_32x32.Icons8_Civilization_anubis.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Civilization_Bowler_Hat = "Tripous.ResLib.Icons8_32x32.Icons8_Civilization_bowler_hat.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Civilization_Brandenburg_Gate = "Tripous.ResLib.Icons8_32x32.Icons8_Civilization_brandenburg_gate.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Civilization_Bull = "Tripous.ResLib.Icons8_32x32.Icons8_Civilization_bull.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Civilization_Chichen_Itza = "Tripous.ResLib.Icons8_32x32.Icons8_Civilization_chichen_itza.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Civilization_Chili_Papper = "Tripous.ResLib.Icons8_32x32.Icons8_Civilization_chili_papper.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Civilization_Cross = "Tripous.ResLib.Icons8_32x32.Icons8_Civilization_cross.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Civilization_Dharmacakra = "Tripous.ResLib.Icons8_32x32.Icons8_Civilization_dharmacakra.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Civilization_Fan2 = "Tripous.ResLib.Icons8_32x32.Icons8_Civilization_fan2.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Civilization_Geisha = "Tripous.ResLib.Icons8_32x32.Icons8_Civilization_geisha.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Civilization_German_Hat = "Tripous.ResLib.Icons8_32x32.Icons8_Civilization_german_hat.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Civilization_Great_Wall = "Tripous.ResLib.Icons8_32x32.Icons8_Civilization_great_wall.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Civilization_Kettle = "Tripous.ResLib.Icons8_32x32.Icons8_Civilization_kettle.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Civilization_Koran = "Tripous.ResLib.Icons8_32x32.Icons8_Civilization_koran.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Civilization_Latern = "Tripous.ResLib.Icons8_32x32.Icons8_Civilization_latern.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Civilization_Menorah = "Tripous.ResLib.Icons8_32x32.Icons8_Civilization_menorah.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Civilization_Mosque = "Tripous.ResLib.Icons8_32x32.Icons8_Civilization_mosque.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Civilization_Origami = "Tripous.ResLib.Icons8_32x32.Icons8_Civilization_origami.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Civilization_Pranava = "Tripous.ResLib.Icons8_32x32.Icons8_Civilization_pranava.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Civilization_Pretzel = "Tripous.ResLib.Icons8_32x32.Icons8_Civilization_pretzel.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Civilization_Pyramids = "Tripous.ResLib.Icons8_32x32.Icons8_Civilization_pyramids.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Civilization_Queen_Gb = "Tripous.ResLib.Icons8_32x32.Icons8_Civilization_queen_gb.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Civilization_Rainy_Weather = "Tripous.ResLib.Icons8_32x32.Icons8_Civilization_rainy_weather.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Civilization_Sagrada_Familia = "Tripous.ResLib.Icons8_32x32.Icons8_Civilization_sagrada_familia.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Civilization_Sombrero = "Tripous.ResLib.Icons8_32x32.Icons8_Civilization_sombrero.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Civilization_Star_Crescent = "Tripous.ResLib.Icons8_32x32.Icons8_Civilization_star_crescent.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Civilization_Star_Of_David = "Tripous.ResLib.Icons8_32x32.Icons8_Civilization_star_of_david.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Civilization_Sushi = "Tripous.ResLib.Icons8_32x32.Icons8_Civilization_sushi.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Civilization_Thor_Hammer = "Tripous.ResLib.Icons8_32x32.Icons8_Civilization_thor_hammer.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Civilization_Torah = "Tripous.ResLib.Icons8_32x32.Icons8_Civilization_torah.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Civilization_Torii = "Tripous.ResLib.Icons8_32x32.Icons8_Civilization_torii.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Civilization_Triskelion = "Tripous.ResLib.Icons8_32x32.Icons8_Civilization_triskelion.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Civilization_Viking_Helmet = "Tripous.ResLib.Icons8_32x32.Icons8_Civilization_viking_helmet.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Civilization_Viking_Ship = "Tripous.ResLib.Icons8_32x32.Icons8_Civilization_viking_ship.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Civilization_Yin_Yang = "Tripous.ResLib.Icons8_32x32.Icons8_Civilization_yin_yang.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Clothe_Baseball_Cap = "Tripous.ResLib.Icons8_32x32.Icons8_Clothe_baseball_cap.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Clothe_Bra = "Tripous.ResLib.Icons8_32x32.Icons8_Clothe_bra.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Clothe_Coat = "Tripous.ResLib.Icons8_32x32.Icons8_Clothe_coat.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Clothe_Flip_Flop = "Tripous.ResLib.Icons8_32x32.Icons8_Clothe_flip_flop.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Clothe_Hat_Beanie = "Tripous.ResLib.Icons8_32x32.Icons8_Clothe_hat_beanie.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Clothe_Jacket = "Tripous.ResLib.Icons8_32x32.Icons8_Clothe_jacket.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Clothe_Jumper = "Tripous.ResLib.Icons8_32x32.Icons8_Clothe_jumper.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Clothe_Mens_Underwear = "Tripous.ResLib.Icons8_32x32.Icons8_Clothe_mens_underwear.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Clothe_Shirt = "Tripous.ResLib.Icons8_32x32.Icons8_Clothe_shirt.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Clothe_Shoe_Man = "Tripous.ResLib.Icons8_32x32.Icons8_Clothe_shoe_man.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Clothe_Shoe_Woman = "Tripous.ResLib.Icons8_32x32.Icons8_Clothe_shoe_woman.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Clothe_Shorts = "Tripous.ResLib.Icons8_32x32.Icons8_Clothe_shorts.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Clothe_Socks = "Tripous.ResLib.Icons8_32x32.Icons8_Clothe_socks.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Clothe_Sun_Glasses = "Tripous.ResLib.Icons8_32x32.Icons8_Clothe_sun_glasses.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Clothe_Trainers = "Tripous.ResLib.Icons8_32x32.Icons8_Clothe_trainers.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Clothe_Trousers = "Tripous.ResLib.Icons8_32x32.Icons8_Clothe_trousers.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Clothe_T_Shirt = "Tripous.ResLib.Icons8_32x32.Icons8_Clothe_t-shirt.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Clothe_Womens_Underwear = "Tripous.ResLib.Icons8_32x32.Icons8_Clothe_womens_underwear.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Contact_Method_Icq = "Tripous.ResLib.Icons8_32x32.Icons8_Contact_Method_icq.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Contact_Method_Phone = "Tripous.ResLib.Icons8_32x32.Icons8_Contact_Method_phone.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Contact_Method_Skype = "Tripous.ResLib.Icons8_32x32.Icons8_Contact_Method_skype.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Data_Accept_Database = "Tripous.ResLib.Icons8_32x32.Icons8_Data_accept_database.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Data_Add_Database = "Tripous.ResLib.Icons8_32x32.Icons8_Data_add_database.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Data_Backup = "Tripous.ResLib.Icons8_32x32.Icons8_data_backup.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Data_Configuration = "Tripous.ResLib.Icons8_32x32.Icons8_data_configuration.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Data_Db = "Tripous.ResLib.Icons8_32x32.Icons8_Data_Db.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Data_Delete_Database = "Tripous.ResLib.Icons8_32x32.Icons8_Data_delete_database.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Data_Delete_Ticket = "Tripous.ResLib.Icons8_32x32.Icons8_Data_delete_ticket.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Data_Encryption = "Tripous.ResLib.Icons8_32x32.Icons8_data_encryption.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Data_Grid_Add_Column = "Tripous.ResLib.Icons8_32x32.Icons8_Data_Grid_Add_Column.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Data_Grid_Add_Row = "Tripous.ResLib.Icons8_32x32.Icons8_Data_Grid_Add_Row.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Data_Grid_Alphabetical_Sorting = "Tripous.ResLib.Icons8_32x32.Icons8_Data_Grid_alphabetical_sorting.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Data_Grid_Alphabetical_Sorting2 = "Tripous.ResLib.Icons8_32x32.Icons8_Data_Grid_Alphabetical_Sorting2.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Data_Grid_Delete_Column = "Tripous.ResLib.Icons8_32x32.Icons8_Data_Grid_Delete_Column.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Data_Grid_Delete_Row = "Tripous.ResLib.Icons8_32x32.Icons8_Data_Grid_Delete_Row.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Data_Grid_Generic_Sorting = "Tripous.ResLib.Icons8_32x32.Icons8_Data_Grid_generic_sorting.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Data_Grid_Generic_Sorting2 = "Tripous.ResLib.Icons8_32x32.Icons8_Data_Grid_Generic_Sorting2.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Data_Grid_Numerical_Sorting = "Tripous.ResLib.Icons8_32x32.Icons8_Data_Grid_numerical_sorting.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Data_Grid_Numerical_Sorting2 = "Tripous.ResLib.Icons8_32x32.Icons8_Data_Grid_Numerical_Sorting2.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Data_Grid_View_Details = "Tripous.ResLib.Icons8_32x32.Icons8_Data_Grid_View_Details.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Data_Mysql = "Tripous.ResLib.Icons8_32x32.Icons8_Data_mysql.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Data_Php = "Tripous.ResLib.Icons8_32x32.Icons8_Data_php.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Data_Protection = "Tripous.ResLib.Icons8_32x32.Icons8_data_protection.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Data_Recovery = "Tripous.ResLib.Icons8_32x32.Icons8_data_recovery.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Data_Tape_Drive = "Tripous.ResLib.Icons8_32x32.Icons8_Data_tape_drive.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Data_Ticket = "Tripous.ResLib.Icons8_32x32.Icons8_Data_ticket.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Data_Zoom_In = "Tripous.ResLib.Icons8_32x32.Icons8_Data_zoom_in.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Data_Zoom_Out = "Tripous.ResLib.Icons8_32x32.Icons8_Data_zoom_out.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Debug_Bug = "Tripous.ResLib.Icons8_32x32.Icons8_Debug_bug.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Debug_Console = "Tripous.ResLib.Icons8_32x32.Icons8_Debug_console.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Debug_Copy_Link = "Tripous.ResLib.Icons8_32x32.Icons8_Debug_copy_link.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Debug_External_Link = "Tripous.ResLib.Icons8_32x32.Icons8_Debug_external_link.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Debug_Open_In_Browser = "Tripous.ResLib.Icons8_32x32.Icons8_Debug_open_in_browser.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Debug_Outline = "Tripous.ResLib.Icons8_32x32.Icons8_Debug_outline.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Debug_Variable = "Tripous.ResLib.Icons8_32x32.Icons8_Debug_variable.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Debug_Watch = "Tripous.ResLib.Icons8_32x32.Icons8_Debug_watch.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Decision = "Tripous.ResLib.Icons8_32x32.Icons8_decision.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Decision_Approve = "Tripous.ResLib.Icons8_32x32.Icons8_Decision_approve.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Decision_Bad = "Tripous.ResLib.Icons8_32x32.Icons8_Decision_bad.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Decision_Disapprove = "Tripous.ResLib.Icons8_32x32.Icons8_Decision_disapprove.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Decision_Good = "Tripous.ResLib.Icons8_32x32.Icons8_Decision_good.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Decision_Make = "Tripous.ResLib.Icons8_32x32.Icons8_Decision_make.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Decision_Neutral = "Tripous.ResLib.Icons8_32x32.Icons8_Decision_neutral.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Easter_Bell = "Tripous.ResLib.Icons8_32x32.Icons8_Easter_bell.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Easter_Cake = "Tripous.ResLib.Icons8_32x32.Icons8_easter_cake.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Easter_Church = "Tripous.ResLib.Icons8_32x32.Icons8_Easter_church.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Easter_Egg = "Tripous.ResLib.Icons8_32x32.Icons8_easter_egg.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Easter_Eggs = "Tripous.ResLib.Icons8_32x32.Icons8_Easter_eggs.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Easter_Holy_Bible = "Tripous.ResLib.Icons8_32x32.Icons8_Easter_holy_bible.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Easter_Pussy_Willow = "Tripous.ResLib.Icons8_32x32.Icons8_Easter_pussy_willow.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Easter_Rabbit = "Tripous.ResLib.Icons8_32x32.Icons8_easter_rabbit.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Ecommerce_Alarm_Clock = "Tripous.ResLib.Icons8_32x32.Icons8_Ecommerce_alarm_clock.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Ecommerce_Average = "Tripous.ResLib.Icons8_32x32.Icons8_Ecommerce_average.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Ecommerce_Box = "Tripous.ResLib.Icons8_32x32.Icons8_Ecommerce_box.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Ecommerce_Buy = "Tripous.ResLib.Icons8_32x32.Icons8_Ecommerce_buy.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Ecommerce_Cheap = "Tripous.ResLib.Icons8_32x32.Icons8_Ecommerce_cheap.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Ecommerce_Checkout = "Tripous.ResLib.Icons8_32x32.Icons8_Ecommerce_checkout.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Ecommerce_Empty_Box = "Tripous.ResLib.Icons8_32x32.Icons8_Ecommerce_empty_box.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Ecommerce_Expensive = "Tripous.ResLib.Icons8_32x32.Icons8_Ecommerce_expensive.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Ecommerce_Filled_Box = "Tripous.ResLib.Icons8_32x32.Icons8_Ecommerce_filled_box.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Ecommerce_Free_Shipping = "Tripous.ResLib.Icons8_32x32.Icons8_Ecommerce_free_shipping.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Ecommerce_Gift = "Tripous.ResLib.Icons8_32x32.Icons8_Ecommerce_gift.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Ecommerce_Handshake = "Tripous.ResLib.Icons8_32x32.Icons8_Ecommerce_handshake.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Ecommerce_Idea = "Tripous.ResLib.Icons8_32x32.Icons8_Ecommerce_idea.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Ecommerce_New = "Tripous.ResLib.Icons8_32x32.Icons8_Ecommerce_new.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Ecommerce_One_Free = "Tripous.ResLib.Icons8_32x32.Icons8_Ecommerce_one_free.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Ecommerce_Paypal = "Tripous.ResLib.Icons8_32x32.Icons8_Ecommerce_paypal.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Ecommerce_Price_Tag = "Tripous.ResLib.Icons8_32x32.Icons8_Ecommerce_price_tag.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Ecommerce_Price_Tag_Euro = "Tripous.ResLib.Icons8_32x32.Icons8_Ecommerce_price_tag_euro.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Ecommerce_Qr_Code = "Tripous.ResLib.Icons8_32x32.Icons8_Ecommerce_qr_code.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Ecommerce_Redeem = "Tripous.ResLib.Icons8_32x32.Icons8_Ecommerce_redeem.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Ecommerce_Return = "Tripous.ResLib.Icons8_32x32.Icons8_Ecommerce_return.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Ecommerce_Sale = "Tripous.ResLib.Icons8_32x32.Icons8_Ecommerce_sale.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Ecommerce_Sell = "Tripous.ResLib.Icons8_32x32.Icons8_Ecommerce_sell.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Ecommerce_Shoping_Bag = "Tripous.ResLib.Icons8_32x32.Icons8_Ecommerce_shoping_bag.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Ecommerce_Shoping_Basket = "Tripous.ResLib.Icons8_32x32.Icons8_Ecommerce_shoping_basket.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Ecommerce_Shoping_Cart = "Tripous.ResLib.Icons8_32x32.Icons8_Ecommerce_shoping_cart.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Ecommerce_Shoping_Cart_Filled = "Tripous.ResLib.Icons8_32x32.Icons8_Ecommerce_shoping_cart_filled.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Ecommerce_Tag = "Tripous.ResLib.Icons8_32x32.Icons8_Ecommerce_tag.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Emoticon_Angel = "Tripous.ResLib.Icons8_32x32.Icons8_Emoticon_angel.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Emoticon_Angry = "Tripous.ResLib.Icons8_32x32.Icons8_Emoticon_angry.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Emoticon_Cool = "Tripous.ResLib.Icons8_32x32.Icons8_Emoticon_cool.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Emoticon_Crying = "Tripous.ResLib.Icons8_32x32.Icons8_Emoticon_crying.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Emoticon_Evil = "Tripous.ResLib.Icons8_32x32.Icons8_Emoticon_evil.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Emoticon_Guestion = "Tripous.ResLib.Icons8_32x32.Icons8_Emoticon_guestion.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Emoticon_Happy = "Tripous.ResLib.Icons8_32x32.Icons8_Emoticon_happy.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Emoticon_In_Love = "Tripous.ResLib.Icons8_32x32.Icons8_Emoticon_in_love.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Emoticon_Kiss = "Tripous.ResLib.Icons8_32x32.Icons8_Emoticon_kiss.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Emoticon_Lol = "Tripous.ResLib.Icons8_32x32.Icons8_Emoticon_lol.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Emoticon_Private = "Tripous.ResLib.Icons8_32x32.Icons8_Emoticon_private.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Emoticon_Sad = "Tripous.ResLib.Icons8_32x32.Icons8_Emoticon_sad.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Emoticon_Sleeping = "Tripous.ResLib.Icons8_32x32.Icons8_Emoticon_sleeping.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Emoticon_Surprised = "Tripous.ResLib.Icons8_32x32.Icons8_Emoticon_surprised.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Emoticon_Tongue = "Tripous.ResLib.Icons8_32x32.Icons8_Emoticon_tongue.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Emoticon_Wink = "Tripous.ResLib.Icons8_32x32.Icons8_Emoticon_wink.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Ethernet_Network_Cable = "Tripous.ResLib.Icons8_32x32.Icons8_Ethernet_network_cable.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Ethernet_Network_Card = "Tripous.ResLib.Icons8_32x32.Icons8_Ethernet_network_card.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Ethernet_Off = "Tripous.ResLib.Icons8_32x32.Icons8_ethernet_off.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Ethernet_On = "Tripous.ResLib.Icons8_32x32.Icons8_ethernet_on.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Ethernet_Rj45 = "Tripous.ResLib.Icons8_32x32.Icons8_Ethernet_rj45.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string File_Type_Ai = "Tripous.ResLib.Icons8_32x32.Icons8_File_Type_ai.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string File_Type_Avi = "Tripous.ResLib.Icons8_32x32.Icons8_File_Type_avi.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string File_Type_Blu_Ray = "Tripous.ResLib.Icons8_32x32.Icons8_File_Type_blu_ray.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string File_Type_Cd = "Tripous.ResLib.Icons8_32x32.Icons8_File_Type_cd.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string File_Type_Csv = "Tripous.ResLib.Icons8_32x32.Icons8_File_Type_csv.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string File_Type_Dll = "Tripous.ResLib.Icons8_32x32.Icons8_File_Type_dll.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string File_Type_Dmg = "Tripous.ResLib.Icons8_32x32.Icons8_File_Type_dmg.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string File_Type_Dvd = "Tripous.ResLib.Icons8_32x32.Icons8_File_Type_dvd.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string File_Type_Exe = "Tripous.ResLib.Icons8_32x32.Icons8_File_Type_exe.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string File_Type_Exel = "Tripous.ResLib.Icons8_32x32.Icons8_File_Type_exel.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string File_Type_Flv = "Tripous.ResLib.Icons8_32x32.Icons8_File_Type_flv.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string File_Type_Gif = "Tripous.ResLib.Icons8_32x32.Icons8_File_Type_gif.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string File_Type_Jpg = "Tripous.ResLib.Icons8_32x32.Icons8_File_Type_jpg.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string File_Type_Mov = "Tripous.ResLib.Icons8_32x32.Icons8_File_Type_mov.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string File_Type_Mp3 = "Tripous.ResLib.Icons8_32x32.Icons8_File_Type_mp3.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string File_Type_Mpg = "Tripous.ResLib.Icons8_32x32.Icons8_File_Type_mpg.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string File_Type_Ogg = "Tripous.ResLib.Icons8_32x32.Icons8_File_Type_ogg.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string File_Type_Pdf = "Tripous.ResLib.Icons8_32x32.Icons8_File_Type_pdf.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string File_Type_Png = "Tripous.ResLib.Icons8_32x32.Icons8_File_Type_png.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string File_Type_Powerpoint = "Tripous.ResLib.Icons8_32x32.Icons8_File_Type_powerpoint.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string File_Type_Psd = "Tripous.ResLib.Icons8_32x32.Icons8_File_Type_psd.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string File_Type_Rar = "Tripous.ResLib.Icons8_32x32.Icons8_File_Type_rar.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string File_Type_Vhs = "Tripous.ResLib.Icons8_32x32.Icons8_File_Type_vhs.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string File_Type_Wma = "Tripous.ResLib.Icons8_32x32.Icons8_File_Type_wma.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string File_Type_Word = "Tripous.ResLib.Icons8_32x32.Icons8_File_Type_word.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string File_Type_Zip = "Tripous.ResLib.Icons8_32x32.Icons8_File_Type_zip.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Folder = "Tripous.ResLib.Icons8_32x32.Icons8_folder.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Folder_Binders = "Tripous.ResLib.Icons8_32x32.Icons8_Folder_binders.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Folder_Burn = "Tripous.ResLib.Icons8_32x32.Icons8_Folder_burn.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Folder_Documents = "Tripous.ResLib.Icons8_32x32.Icons8_Folder_documents.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Folder_Dossier = "Tripous.ResLib.Icons8_32x32.Icons8_Folder_dossier.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Folder_Downloads = "Tripous.ResLib.Icons8_32x32.Icons8_Folder_downloads.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Folder_Extensions = "Tripous.ResLib.Icons8_32x32.Icons8_Folder_extensions.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Folder_Internet = "Tripous.ResLib.Icons8_32x32.Icons8_Folder_internet.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Folder_Likes = "Tripous.ResLib.Icons8_32x32.Icons8_Folder_likes.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Folder_Movies = "Tripous.ResLib.Icons8_32x32.Icons8_Folder_movies.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Folder_Music = "Tripous.ResLib.Icons8_32x32.Icons8_Folder_music.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Folder_Pictures = "Tripous.ResLib.Icons8_32x32.Icons8_Folder_pictures.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Folder_Porn = "Tripous.ResLib.Icons8_32x32.Icons8_Folder_porn.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Folder_User = "Tripous.ResLib.Icons8_32x32.Icons8_Folder_user.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Footprint_Bear = "Tripous.ResLib.Icons8_32x32.Icons8_Footprint_bear.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Footprint_Cat = "Tripous.ResLib.Icons8_32x32.Icons8_Footprint_cat.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Footprint_Dog = "Tripous.ResLib.Icons8_32x32.Icons8_Footprint_dog.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Footprint_Human_Footprints = "Tripous.ResLib.Icons8_32x32.Icons8_Footprint_human_footprints.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Footprint_Left_Footprint = "Tripous.ResLib.Icons8_32x32.Icons8_Footprint_left_footprint.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Footprint_Left_Shoe = "Tripous.ResLib.Icons8_32x32.Icons8_Footprint_left_shoe.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Footprint_Right_Footprint = "Tripous.ResLib.Icons8_32x32.Icons8_Footprint_right_footprint.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Footprint_Right_Shoe = "Tripous.ResLib.Icons8_32x32.Icons8_Footprint_right_shoe.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Footprint_Shoes = "Tripous.ResLib.Icons8_32x32.Icons8_Footprint_shoes.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Forum_Child_New_Post = "Tripous.ResLib.Icons8_32x32.Icons8_Forum_child_new_post.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Forum_Closed_Topic = "Tripous.ResLib.Icons8_32x32.Icons8_Forum_closed_topic.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Forum_Delete_Message = "Tripous.ResLib.Icons8_32x32.Icons8_Forum_delete_message.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Forum_Moved_Topic = "Tripous.ResLib.Icons8_32x32.Icons8_Forum_moved_topic.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Forum_My_Topic = "Tripous.ResLib.Icons8_32x32.Icons8_Forum_my_topic.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Forum_New_Post = "Tripous.ResLib.Icons8_32x32.Icons8_Forum_new_post.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Forum_Online = "Tripous.ResLib.Icons8_32x32.Icons8_Forum_online.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Forum_Pin = "Tripous.ResLib.Icons8_32x32.Icons8_Forum_pin.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Forum_Poll_Topic = "Tripous.ResLib.Icons8_32x32.Icons8_Forum_poll_topic.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Forum_Popular_Topic = "Tripous.ResLib.Icons8_32x32.Icons8_Forum_popular_topic.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Forum_Quote = "Tripous.ResLib.Icons8_32x32.Icons8_Forum_quote.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Forum_Response = "Tripous.ResLib.Icons8_32x32.Icons8_Forum_response.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Forum_Rss = "Tripous.ResLib.Icons8_32x32.Icons8_Forum_rss.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Forum_Topic = "Tripous.ResLib.Icons8_32x32.Icons8_Forum_topic.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Forum_Very_Popular_Topic = "Tripous.ResLib.Icons8_32x32.Icons8_Forum_very_popular_topic.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Gamble_Cards = "Tripous.ResLib.Icons8_32x32.Icons8_Gamble_cards.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Gamble_Chip = "Tripous.ResLib.Icons8_32x32.Icons8_Gamble_chip.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Gamble_Clover = "Tripous.ResLib.Icons8_32x32.Icons8_Gamble_clover.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Gamble_Clubs = "Tripous.ResLib.Icons8_32x32.Icons8_Gamble_clubs.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Gamble_Diamonds = "Tripous.ResLib.Icons8_32x32.Icons8_Gamble_diamonds.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Gamble_Dice = "Tripous.ResLib.Icons8_32x32.Icons8_Gamble_dice.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Gamble_Hearts = "Tripous.ResLib.Icons8_32x32.Icons8_Gamble_hearts.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Gamble_Joker = "Tripous.ResLib.Icons8_32x32.Icons8_Gamble_joker.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Gamble_Slot_Machine = "Tripous.ResLib.Icons8_32x32.Icons8_Gamble_slot_machine.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Gamble_Spades = "Tripous.ResLib.Icons8_32x32.Icons8_Gamble_spades.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Gamble_Win = "Tripous.ResLib.Icons8_32x32.Icons8_Gamble_win.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Geo_Compass = "Tripous.ResLib.Icons8_32x32.Icons8_Geo_compass.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Geo_Define_Location = "Tripous.ResLib.Icons8_32x32.Icons8_Geo_define_location.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Geo_Empty_Flag = "Tripous.ResLib.Icons8_32x32.Icons8_Geo_empty_flag.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Geo_Filled_Flag = "Tripous.ResLib.Icons8_32x32.Icons8_Geo_filled_flag.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Geo_Globe = "Tripous.ResLib.Icons8_32x32.Icons8_Geo_globe.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Geo_Gps_Disconnected = "Tripous.ResLib.Icons8_32x32.Icons8_Geo_gps_disconnected.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Geo_Gps_Receiving = "Tripous.ResLib.Icons8_32x32.Icons8_Geo_gps_receiving.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Geo_Gps_Searching = "Tripous.ResLib.Icons8_32x32.Icons8_Geo_gps_searching.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Geo_Layers = "Tripous.ResLib.Icons8_32x32.Icons8_Geo_layers.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Geo_Map = "Tripous.ResLib.Icons8_32x32.Icons8_Geo_map.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Geo_Map_Marker = "Tripous.ResLib.Icons8_32x32.Icons8_Geo_map_marker.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Geo_Marker = "Tripous.ResLib.Icons8_32x32.Icons8_Geo_marker.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Geo_Point_Objects = "Tripous.ResLib.Icons8_32x32.Icons8_Geo_point_objects.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Geo_Polygom = "Tripous.ResLib.Icons8_32x32.Icons8_Geo_polygom.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Geo_Polyline = "Tripous.ResLib.Icons8_32x32.Icons8_Geo_polyline.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Geo_Road = "Tripous.ResLib.Icons8_32x32.Icons8_Geo_road.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Geo_Signpost = "Tripous.ResLib.Icons8_32x32.Icons8_Geo_signpost.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Geo_Street_View = "Tripous.ResLib.Icons8_32x32.Icons8_Geo_street_view.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Geo_Wind_Rose = "Tripous.ResLib.Icons8_32x32.Icons8_Geo_wind_rose.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Geo_World_Map = "Tripous.ResLib.Icons8_32x32.Icons8_Geo_world_map.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Geo_Worldwide_Location = "Tripous.ResLib.Icons8_32x32.Icons8_Geo_worldwide_location.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Gesture_2F_Double_Tap = "Tripous.ResLib.Icons8_32x32.Icons8_Gesture_2f_double_tap.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Gesture_2F_Swipe_Down = "Tripous.ResLib.Icons8_32x32.Icons8_Gesture_2f_swipe_down.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Gesture_2F_Swipe_Left = "Tripous.ResLib.Icons8_32x32.Icons8_Gesture_2f_swipe_left.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Gesture_2F_Swipe_Right = "Tripous.ResLib.Icons8_32x32.Icons8_Gesture_2f_swipe_right.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Gesture_2F_Swipe_Up = "Tripous.ResLib.Icons8_32x32.Icons8_Gesture_2f_swipe_up.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Gesture_2F_Tap = "Tripous.ResLib.Icons8_32x32.Icons8_Gesture_2f_tap.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Gesture_Double_Tap = "Tripous.ResLib.Icons8_32x32.Icons8_Gesture_double_tap.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Gesture_Pinch = "Tripous.ResLib.Icons8_32x32.Icons8_Gesture_pinch.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Gesture_Spread = "Tripous.ResLib.Icons8_32x32.Icons8_Gesture_spread.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Gesture_Swipe_Down = "Tripous.ResLib.Icons8_32x32.Icons8_Gesture_swipe_down.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Gesture_Swipe_Left = "Tripous.ResLib.Icons8_32x32.Icons8_Gesture_swipe_left.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Gesture_Swipe_Right = "Tripous.ResLib.Icons8_32x32.Icons8_Gesture_swipe_right.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Gesture_Swipe_Up = "Tripous.ResLib.Icons8_32x32.Icons8_Gesture_swipe_up.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Gesture_Tap = "Tripous.ResLib.Icons8_32x32.Icons8_Gesture_tap.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Google_Alerts = "Tripous.ResLib.Icons8_32x32.Icons8_google_alerts.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Google_Blog_Search = "Tripous.ResLib.Icons8_32x32.Icons8_google_blog_search.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Google_Code = "Tripous.ResLib.Icons8_32x32.Icons8_google_code.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Google_Drive = "Tripous.ResLib.Icons8_32x32.Icons8_google_drive.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Google_Earth = "Tripous.ResLib.Icons8_32x32.Icons8_google_earth.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Google_Groups = "Tripous.ResLib.Icons8_32x32.Icons8_google_groups.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Google_Images = "Tripous.ResLib.Icons8_32x32.Icons8_google_images.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Google_Mobile = "Tripous.ResLib.Icons8_32x32.Icons8_google_mobile.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Google_News = "Tripous.ResLib.Icons8_32x32.Icons8_google_news.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Google_Scholar = "Tripous.ResLib.Icons8_32x32.Icons8_google_scholar.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Google_Sketchup = "Tripous.ResLib.Icons8_32x32.Icons8_google_sketchup.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Google_Translate = "Tripous.ResLib.Icons8_32x32.Icons8_google_translate.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Google_Web_Search = "Tripous.ResLib.Icons8_32x32.Icons8_google_web_search.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Hair_Band = "Tripous.ResLib.Icons8_32x32.Icons8_hair_band.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Hair_Barber_Scissors = "Tripous.ResLib.Icons8_32x32.Icons8_Hair_barber_scissors.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Hair_Barbers_Chair = "Tripous.ResLib.Icons8_32x32.Icons8_Hair_barbers_chair.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Hair_Barbers_Pole = "Tripous.ResLib.Icons8_32x32.Icons8_Hair_barbers_pole.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Hair_Brush = "Tripous.ResLib.Icons8_32x32.Icons8_hair_brush.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Hair_Clip = "Tripous.ResLib.Icons8_32x32.Icons8_hair_clip.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Hair_Comb = "Tripous.ResLib.Icons8_32x32.Icons8_Hair_comb.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Hair_Dryer = "Tripous.ResLib.Icons8_32x32.Icons8_hair_dryer.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Hair_Goatee = "Tripous.ResLib.Icons8_32x32.Icons8_Hair_goatee.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Hair_Long_Beard = "Tripous.ResLib.Icons8_32x32.Icons8_Hair_long_beard.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Hair_Mustache = "Tripous.ResLib.Icons8_32x32.Icons8_Hair_mustache.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Hair_Scrunchy = "Tripous.ResLib.Icons8_32x32.Icons8_Hair_scrunchy.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Hair_Short_Beard = "Tripous.ResLib.Icons8_32x32.Icons8_Hair_short_beard.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Hair_Sideburns = "Tripous.ResLib.Icons8_32x32.Icons8_Hair_sideburns.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Hair_Stubble = "Tripous.ResLib.Icons8_32x32.Icons8_Hair_stubble.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Hair_Van_Dyke = "Tripous.ResLib.Icons8_32x32.Icons8_Hair_van_dyke.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Hair_Washing_Sink = "Tripous.ResLib.Icons8_32x32.Icons8_hair_washing_sink.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Halloween_Frankenstein = "Tripous.ResLib.Icons8_32x32.Icons8_Halloween_frankenstein.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Halloween_Vampire = "Tripous.ResLib.Icons8_32x32.Icons8_Halloween_vampire.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Halloween_Werewolf = "Tripous.ResLib.Icons8_32x32.Icons8_Halloween_werewolf.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Halloween_Witch = "Tripous.ResLib.Icons8_32x32.Icons8_Halloween_witch.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Halloween_Wizard = "Tripous.ResLib.Icons8_32x32.Icons8_Halloween_wizard.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Halloween_Zombie = "Tripous.ResLib.Icons8_32x32.Icons8_Halloween_zombie.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Hand_Clenched_Fist = "Tripous.ResLib.Icons8_32x32.Icons8_Hand_clenched_fist.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Hand_Finger_And_Thumb = "Tripous.ResLib.Icons8_32x32.Icons8_Hand_finger_and_thumb.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Hand_Four_Fingers = "Tripous.ResLib.Icons8_32x32.Icons8_Hand_four_fingers.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Hand_One_Finger = "Tripous.ResLib.Icons8_32x32.Icons8_Hand_one_finger.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Hand_So_So = "Tripous.ResLib.Icons8_32x32.Icons8_Hand_so-so.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Hand_Three_Fingers = "Tripous.ResLib.Icons8_32x32.Icons8_Hand_three_fingers.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Hand_Thumbs_Down = "Tripous.ResLib.Icons8_32x32.Icons8_Hand_thumbs_down.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Hand_Thumbs_Up = "Tripous.ResLib.Icons8_32x32.Icons8_Hand_thumbs_up.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Hand_Two_Fingers = "Tripous.ResLib.Icons8_32x32.Icons8_Hand_two_fingers.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Hand_Two_Hands = "Tripous.ResLib.Icons8_32x32.Icons8_Hand_two_hands.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Hand_Whole_Hand = "Tripous.ResLib.Icons8_32x32.Icons8_Hand_whole_hand.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Hardware_Keyboard = "Tripous.ResLib.Icons8_32x32.Icons8_Hardware_keyboard.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Hardware_Monitor = "Tripous.ResLib.Icons8_32x32.Icons8_Hardware_monitor.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Hardware_Mouse = "Tripous.ResLib.Icons8_32x32.Icons8_Hardware_mouse.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Hardware_Notebook = "Tripous.ResLib.Icons8_32x32.Icons8_Hardware_notebook.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Hardware_Scanner = "Tripous.ResLib.Icons8_32x32.Icons8_Hardware_scanner.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Hot_Beverage_Chocolate = "Tripous.ResLib.Icons8_32x32.Icons8_Hot_Beverage_chocolate.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Hot_Beverage_Coffee = "Tripous.ResLib.Icons8_32x32.Icons8_Hot_Beverage_coffee.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Hot_Beverage_Honey = "Tripous.ResLib.Icons8_32x32.Icons8_Hot_Beverage_honey.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Hot_Beverage_Milk = "Tripous.ResLib.Icons8_32x32.Icons8_Hot_Beverage_milk.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Hot_Beverage_Sugar = "Tripous.ResLib.Icons8_32x32.Icons8_Hot_Beverage_sugar.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Hot_Beverage_Tea = "Tripous.ResLib.Icons8_32x32.Icons8_Hot_Beverage_tea.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Image_Tool_Arrow = "Tripous.ResLib.Icons8_32x32.Icons8_Image_Tool_arrow.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Image_Tool_Ball_Point_Pen = "Tripous.ResLib.Icons8_32x32.Icons8_Image_Tool_ball_point_pen.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Image_Tool_Brush = "Tripous.ResLib.Icons8_32x32.Icons8_Image_Tool_brush.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Image_Tool_Chisel_Tip_Marker = "Tripous.ResLib.Icons8_32x32.Icons8_Image_Tool_chisel_tip_marker.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Image_Tool_Collapse = "Tripous.ResLib.Icons8_32x32.Icons8_Image_Tool_collapse.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Image_Tool_Color_Dropper = "Tripous.ResLib.Icons8_32x32.Icons8_Image_Tool_color_dropper.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Image_Tool_Crop = "Tripous.ResLib.Icons8_32x32.Icons8_Image_Tool_crop.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Image_Tool_Diamond = "Tripous.ResLib.Icons8_32x32.Icons8_Image_Tool_diamond.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Image_Tool_Ellips = "Tripous.ResLib.Icons8_32x32.Icons8_Image_Tool_ellips.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Image_Tool_Ellipse_Stroked = "Tripous.ResLib.Icons8_32x32.Icons8_Image_Tool_ellipse_stroked.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Image_Tool_Eraser = "Tripous.ResLib.Icons8_32x32.Icons8_Image_Tool_eraser.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Image_Tool_Expand = "Tripous.ResLib.Icons8_32x32.Icons8_Image_Tool_expand.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Image_Tool_Flip_Horizontal = "Tripous.ResLib.Icons8_32x32.Icons8_Image_Tool_flip_horizontal.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Image_Tool_Flip_Vertical = "Tripous.ResLib.Icons8_32x32.Icons8_Image_Tool_flip_vertical.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Image_Tool_Hexagon = "Tripous.ResLib.Icons8_32x32.Icons8_Image_Tool_hexagon.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Image_Tool_Line = "Tripous.ResLib.Icons8_32x32.Icons8_Image_Tool_line.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Image_Tool_Line_Width = "Tripous.ResLib.Icons8_32x32.Icons8_Image_Tool_line_width.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Image_Tool_Octagon = "Tripous.ResLib.Icons8_32x32.Icons8_Image_Tool_octagon.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Image_Tool_Pen = "Tripous.ResLib.Icons8_32x32.Icons8_Image_Tool_pen.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Image_Tool_Pencil = "Tripous.ResLib.Icons8_32x32.Icons8_Image_Tool_pencil.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Image_Tool_Pentagon = "Tripous.ResLib.Icons8_32x32.Icons8_Image_Tool_pentagon.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Image_Tool_Rectangle = "Tripous.ResLib.Icons8_32x32.Icons8_Image_Tool_rectangle.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Image_Tool_Rectangle_Stroked = "Tripous.ResLib.Icons8_32x32.Icons8_Image_Tool_rectangle_stroked.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Image_Tool_Resize = "Tripous.ResLib.Icons8_32x32.Icons8_Image_Tool_resize.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Image_Tool_Roller_Brush = "Tripous.ResLib.Icons8_32x32.Icons8_Image_Tool_roller_brush.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Image_Tool_Rotate = "Tripous.ResLib.Icons8_32x32.Icons8_Image_Tool_rotate.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Image_Tool_Rounded_Rectangle = "Tripous.ResLib.Icons8_32x32.Icons8_Image_Tool_rounded_rectangle.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Image_Tool_Screenshot = "Tripous.ResLib.Icons8_32x32.Icons8_Image_Tool_screenshot.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Image_Tool_Text = "Tripous.ResLib.Icons8_32x32.Icons8_Image_Tool_text.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Image_Tool_Triangle_Stroked = "Tripous.ResLib.Icons8_32x32.Icons8_Image_Tool_triangle_stroked.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Industry_Automotive = "Tripous.ResLib.Icons8_32x32.Icons8_Industry_automotive.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Industry_Biohazard = "Tripous.ResLib.Icons8_32x32.Icons8_Industry_biohazard.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Industry_Biomass = "Tripous.ResLib.Icons8_32x32.Icons8_Industry_biomass.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Industry_Biotech = "Tripous.ResLib.Icons8_32x32.Icons8_Industry_biotech.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Industry_Capacitor = "Tripous.ResLib.Icons8_32x32.Icons8_Industry_capacitor.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Industry_Circuit = "Tripous.ResLib.Icons8_32x32.Icons8_Industry_circuit.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Industry_Crystal_Oscillator = "Tripous.ResLib.Icons8_32x32.Icons8_Industry_crystal_oscillator.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Industry_Display = "Tripous.ResLib.Icons8_32x32.Icons8_Industry_display.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Industry_Electricity = "Tripous.ResLib.Icons8_32x32.Icons8_Industry_electricity.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Industry_Electro_Devices = "Tripous.ResLib.Icons8_32x32.Icons8_Industry_electro_devices.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Industry_Electronics = "Tripous.ResLib.Icons8_32x32.Icons8_Industry_electronics.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Industry_Engineering = "Tripous.ResLib.Icons8_32x32.Icons8_Industry_engineering.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Industry_Factory = "Tripous.ResLib.Icons8_32x32.Icons8_Industry_factory.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Industry_Fork_Truck = "Tripous.ResLib.Icons8_32x32.Icons8_Industry_fork_truck.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Industry_Gas = "Tripous.ResLib.Icons8_32x32.Icons8_Industry_gas.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Industry_Gas_Mask = "Tripous.ResLib.Icons8_32x32.Icons8_Industry_gas_mask.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Industry_Geothermal = "Tripous.ResLib.Icons8_32x32.Icons8_Industry_geothermal.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Industry_Greentech = "Tripous.ResLib.Icons8_32x32.Icons8_Industry_greentech.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Industry_Hydroelectric = "Tripous.ResLib.Icons8_32x32.Icons8_Industry_hydroelectric.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Industry_Infrared = "Tripous.ResLib.Icons8_32x32.Icons8_Industry_infrared.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Industry_Infrared_Beam_Sending = "Tripous.ResLib.Icons8_32x32.Icons8_Industry_infrared_beam_sending.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Industry_Infrared_Sensor = "Tripous.ResLib.Icons8_32x32.Icons8_Industry_infrared_sensor.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Industry_Integrated_Circuit = "Tripous.ResLib.Icons8_32x32.Icons8_Industry_integrated_circuit.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Industry_Ladder = "Tripous.ResLib.Icons8_32x32.Icons8_Industry_ladder.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Industry_Led_Diode = "Tripous.ResLib.Icons8_32x32.Icons8_Industry_led_diode.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Industry_Memmory_Slot = "Tripous.ResLib.Icons8_32x32.Icons8_Industry_memmory_slot.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Industry_Overhead_Crane = "Tripous.ResLib.Icons8_32x32.Icons8_Industry_overhead_crane.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Industry_Poison = "Tripous.ResLib.Icons8_32x32.Icons8_Industry_poison.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Industry_Potentiometer = "Tripous.ResLib.Icons8_32x32.Icons8_Industry_potentiometer.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Industry_Processor = "Tripous.ResLib.Icons8_32x32.Icons8_Industry_processor.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Industry_Rack = "Tripous.ResLib.Icons8_32x32.Icons8_Industry_rack.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Industry_Radioactive = "Tripous.ResLib.Icons8_32x32.Icons8_Industry_radioactive.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Industry_Recycling = "Tripous.ResLib.Icons8_32x32.Icons8_Industry_recycling.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Industry_Relay = "Tripous.ResLib.Icons8_32x32.Icons8_Industry_relay.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Industry_Research = "Tripous.ResLib.Icons8_32x32.Icons8_Industry_research.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Industry_Resistor = "Tripous.ResLib.Icons8_32x32.Icons8_Industry_resistor.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Industry_Rfid_Sensor = "Tripous.ResLib.Icons8_32x32.Icons8_Industry_rfid_sensor.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Industry_Rfid_Signal = "Tripous.ResLib.Icons8_32x32.Icons8_Industry_rfid_signal.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Industry_Rfid_Tag = "Tripous.ResLib.Icons8_32x32.Icons8_Industry_rfid_tag.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Industry_Robot = "Tripous.ResLib.Icons8_32x32.Icons8_Industry_robot.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Industry_Sensor = "Tripous.ResLib.Icons8_32x32.Icons8_Industry_sensor.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Industry_Solar_Panel = "Tripous.ResLib.Icons8_32x32.Icons8_Industry_solar_panel.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Industry_Stepper_Motor = "Tripous.ResLib.Icons8_32x32.Icons8_Industry_stepper_motor.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Industry_Transistor = "Tripous.ResLib.Icons8_32x32.Icons8_Industry_transistor.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Industry_Trash = "Tripous.ResLib.Icons8_32x32.Icons8_Industry_trash.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Industry_Water = "Tripous.ResLib.Icons8_32x32.Icons8_Industry_water.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Industry_Wind_Turbine = "Tripous.ResLib.Icons8_32x32.Icons8_Industry_wind_turbine.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string IT_32Bit = "Tripous.ResLib.Icons8_32x32.Icons8_IT_32bit.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string IT_64Bit = "Tripous.ResLib.Icons8_32x32.Icons8_IT_64bit.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string IT_Active_Directory = "Tripous.ResLib.Icons8_32x32.Icons8_IT_active_directory.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string IT_Bluetooth = "Tripous.ResLib.Icons8_32x32.Icons8_IT_bluetooth.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string IT_Cisco_Router = "Tripous.ResLib.Icons8_32x32.Icons8_IT_cisco_router.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string IT_Cloud = "Tripous.ResLib.Icons8_32x32.Icons8_IT_cloud.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string IT_Cloud_Storage = "Tripous.ResLib.Icons8_32x32.Icons8_IT_cloud_storage.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string IT_Computer = "Tripous.ResLib.Icons8_32x32.Icons8_IT_computer.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string IT_Connected = "Tripous.ResLib.Icons8_32x32.Icons8_IT_connected.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string IT_Disconnected = "Tripous.ResLib.Icons8_32x32.Icons8_IT_disconnected.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string IT_Domain = "Tripous.ResLib.Icons8_32x32.Icons8_IT_domain.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string IT_Hdd = "Tripous.ResLib.Icons8_32x32.Icons8_IT_hdd.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string IT_Hub = "Tripous.ResLib.Icons8_32x32.Icons8_IT_hub.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string IT_Ip_Adress = "Tripous.ResLib.Icons8_32x32.Icons8_IT_ip_adress.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string IT_Linux_Client = "Tripous.ResLib.Icons8_32x32.Icons8_IT_linux_client.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string IT_Mac_Client = "Tripous.ResLib.Icons8_32x32.Icons8_IT_mac_client.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string IT_Nas = "Tripous.ResLib.Icons8_32x32.Icons8_IT_nas.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string IT_Network = "Tripous.ResLib.Icons8_32x32.Icons8_IT_network.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string IT_Remote_Control = "Tripous.ResLib.Icons8_32x32.Icons8_IT_remote_control.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string IT_Remote_Working = "Tripous.ResLib.Icons8_32x32.Icons8_IT_remote_working.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string IT_Router = "Tripous.ResLib.Icons8_32x32.Icons8_IT_router.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string IT_Server = "Tripous.ResLib.Icons8_32x32.Icons8_IT_server.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string IT_Ssd = "Tripous.ResLib.Icons8_32x32.Icons8_IT_ssd.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string IT_Stack = "Tripous.ResLib.Icons8_32x32.Icons8_IT_stack.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string IT_Switch = "Tripous.ResLib.Icons8_32x32.Icons8_IT_switch.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string IT_Voip_Gateway = "Tripous.ResLib.Icons8_32x32.Icons8_IT_voip_gateway.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string IT_Vpn = "Tripous.ResLib.Icons8_32x32.Icons8_IT_vpn.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string IT_Wi_Fi = "Tripous.ResLib.Icons8_32x32.Icons8_IT_wi_fi.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string IT_Wi_Fi_Direct = "Tripous.ResLib.Icons8_32x32.Icons8_IT_wi_fi_direct.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string IT_Wifi = "Tripous.ResLib.Icons8_32x32.Icons8_IT_wifi.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string IT_Windows_Client = "Tripous.ResLib.Icons8_32x32.Icons8_IT_windows_client.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string IT_Workstation = "Tripous.ResLib.Icons8_32x32.Icons8_IT_workstation.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string IT_X64 = "Tripous.ResLib.Icons8_32x32.Icons8_IT_x64.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string IT_X86 = "Tripous.ResLib.Icons8_32x32.Icons8_IT_x86.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Keyboard = "Tripous.ResLib.Icons8_32x32.Icons8_keyboard.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Keyboard_Backspace = "Tripous.ResLib.Icons8_32x32.Icons8_Keyboard_backspace.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Keyboard_Enter = "Tripous.ResLib.Icons8_32x32.Icons8_Keyboard_enter.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Keyboard_Shift = "Tripous.ResLib.Icons8_32x32.Icons8_Keyboard_shift.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Kitchen_Banana_Split = "Tripous.ResLib.Icons8_32x32.Icons8_Kitchen_banana_split.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Kitchen_Beer_Bottle = "Tripous.ResLib.Icons8_32x32.Icons8_Kitchen_beer_bottle.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Kitchen_Beer_Glass = "Tripous.ResLib.Icons8_32x32.Icons8_Kitchen_beer_glass.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Kitchen_Birthday_Cake = "Tripous.ResLib.Icons8_32x32.Icons8_Kitchen_birthday_cake.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Kitchen_Bread = "Tripous.ResLib.Icons8_32x32.Icons8_Kitchen_bread.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Kitchen_Bunch_Ingredients = "Tripous.ResLib.Icons8_32x32.Icons8_Kitchen_bunch_ingredients.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Kitchen_Carrot = "Tripous.ResLib.Icons8_32x32.Icons8_Kitchen_carrot.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Kitchen_Cheese = "Tripous.ResLib.Icons8_32x32.Icons8_Kitchen_cheese.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Kitchen_Coctail = "Tripous.ResLib.Icons8_32x32.Icons8_Kitchen_coctail.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Kitchen_Coking_Pot = "Tripous.ResLib.Icons8_32x32.Icons8_Kitchen_coking_pot.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Kitchen_Cooker = "Tripous.ResLib.Icons8_32x32.Icons8_Kitchen_cooker.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Kitchen_Cooker_Hood = "Tripous.ResLib.Icons8_32x32.Icons8_Kitchen_cooker_hood.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Kitchen_Corkscrew = "Tripous.ResLib.Icons8_32x32.Icons8_Kitchen_corkscrew.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Kitchen_Cup = "Tripous.ResLib.Icons8_32x32.Icons8_Kitchen_cup.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Kitchen_Eggs = "Tripous.ResLib.Icons8_32x32.Icons8_Kitchen_eggs.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Kitchen_Fish = "Tripous.ResLib.Icons8_32x32.Icons8_Kitchen_fish.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Kitchen_Fork = "Tripous.ResLib.Icons8_32x32.Icons8_Kitchen_fork.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Kitchen_French_Fries = "Tripous.ResLib.Icons8_32x32.Icons8_Kitchen_french_fries.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Kitchen_Fridge = "Tripous.ResLib.Icons8_32x32.Icons8_Kitchen_fridge.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Kitchen_Hot_Dog = "Tripous.ResLib.Icons8_32x32.Icons8_Kitchen_hot_dog.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Kitchen_Humburger = "Tripous.ResLib.Icons8_32x32.Icons8_Kitchen_humburger.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Kitchen_Knife = "Tripous.ResLib.Icons8_32x32.Icons8_Kitchen_knife.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Kitchen_Ladle = "Tripous.ResLib.Icons8_32x32.Icons8_Kitchen_ladle.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Kitchen_List_Ingredients = "Tripous.ResLib.Icons8_32x32.Icons8_Kitchen_list_ingredients.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Kitchen_Microwave = "Tripous.ResLib.Icons8_32x32.Icons8_Kitchen_microwave.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Kitchen_Milk = "Tripous.ResLib.Icons8_32x32.Icons8_Kitchen_milk.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Kitchen_Mushroom = "Tripous.ResLib.Icons8_32x32.Icons8_Kitchen_mushroom.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Kitchen_Pepper_Shaker = "Tripous.ResLib.Icons8_32x32.Icons8_Kitchen_pepper_shaker.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Kitchen_Pizza = "Tripous.ResLib.Icons8_32x32.Icons8_Kitchen_pizza.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Kitchen_Salt_Shaker = "Tripous.ResLib.Icons8_32x32.Icons8_Kitchen_salt_shaker.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Kitchen_Shellfish = "Tripous.ResLib.Icons8_32x32.Icons8_Kitchen_shellfish.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Kitchen_Soda_Bottle = "Tripous.ResLib.Icons8_32x32.Icons8_Kitchen_soda_bottle.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Kitchen_Spoon = "Tripous.ResLib.Icons8_32x32.Icons8_Kitchen_spoon.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Kitchen_Taco = "Tripous.ResLib.Icons8_32x32.Icons8_Kitchen_taco.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Kitchen_Teapot = "Tripous.ResLib.Icons8_32x32.Icons8_Kitchen_teapot.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Kitchen_Wine_Bottle = "Tripous.ResLib.Icons8_32x32.Icons8_Kitchen_wine_bottle.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Kitchen_Wine_Glass = "Tripous.ResLib.Icons8_32x32.Icons8_Kitchen_wine_glass.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Logo_Accessibility1 = "Tripous.ResLib.Icons8_32x32.Icons8_Logo_accessibility1.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Logo_Accessibility2 = "Tripous.ResLib.Icons8_32x32.Icons8_Logo_accessibility2.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Logo_Cloudflare = "Tripous.ResLib.Icons8_32x32.Icons8_Logo_cloudflare.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Logo_Coderwall = "Tripous.ResLib.Icons8_32x32.Icons8_Logo_coderwall.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Logo_Dribbble = "Tripous.ResLib.Icons8_32x32.Icons8_Logo_dribbble.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Logo_Dropbox = "Tripous.ResLib.Icons8_32x32.Icons8_Logo_dropbox.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Logo_Forrst = "Tripous.ResLib.Icons8_32x32.Icons8_Logo_forrst.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Logo_Github = "Tripous.ResLib.Icons8_32x32.Icons8_Logo_github.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Logo_Instapaper = "Tripous.ResLib.Icons8_32x32.Icons8_Logo_instapaper.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Logo_Joomla = "Tripous.ResLib.Icons8_32x32.Icons8_Logo_Joomla.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Logo_Lego = "Tripous.ResLib.Icons8_32x32.Icons8_Logo_lego.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Logo_Maestro = "Tripous.ResLib.Icons8_32x32.Icons8_Logo_maestro.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Logo_Printerest = "Tripous.ResLib.Icons8_32x32.Icons8_Logo_printerest.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Logo_Python = "Tripous.ResLib.Icons8_32x32.Icons8_Logo_python.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Logo_Recycle_Sign = "Tripous.ResLib.Icons8_32x32.Icons8_Logo_recycle_sign.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Logo_Reddit = "Tripous.ResLib.Icons8_32x32.Icons8_Logo_reddit.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Logo_Soundcloud = "Tripous.ResLib.Icons8_32x32.Icons8_Logo_soundcloud.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Logo_Stachoverflow_Com = "Tripous.ResLib.Icons8_32x32.Icons8_Logo_stachoverflow_com.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Logo_Steam = "Tripous.ResLib.Icons8_32x32.Icons8_Logo_steam.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Logo_Stumbleupon = "Tripous.ResLib.Icons8_32x32.Icons8_Logo_stumbleupon.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Logo_Tumblr = "Tripous.ResLib.Icons8_32x32.Icons8_Logo_tumblr.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Logo_Utorrent = "Tripous.ResLib.Icons8_32x32.Icons8_Logo_utorrent.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Logo_Vlc = "Tripous.ResLib.Icons8_32x32.Icons8_Logo_vlc.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Logo_Wikipedia = "Tripous.ResLib.Icons8_32x32.Icons8_Logo_wikipedia.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Logo_Wolfram_Alpha = "Tripous.ResLib.Icons8_32x32.Icons8_Logo_wolfram_alpha.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Logo_Wordpress = "Tripous.ResLib.Icons8_32x32.Icons8_Logo_Wordpress.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Logo_Youtube = "Tripous.ResLib.Icons8_32x32.Icons8_Logo_youtube.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Management_Advertising = "Tripous.ResLib.Icons8_32x32.Icons8_Management_advertising.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Management_Archive = "Tripous.ResLib.Icons8_32x32.Icons8_Management_archive.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Management_Archive2 = "Tripous.ResLib.Icons8_32x32.Icons8_Management_archive2.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Management_Billing = "Tripous.ResLib.Icons8_32x32.Icons8_Management_billing.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Management_Business_Contact = "Tripous.ResLib.Icons8_32x32.Icons8_Management_business_contact.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Management_Comments = "Tripous.ResLib.Icons8_32x32.Icons8_Management_comments.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Management_Library = "Tripous.ResLib.Icons8_32x32.Icons8_Management_library.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Management_Manager = "Tripous.ResLib.Icons8_32x32.Icons8_Management_manager.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Management_Online_Support = "Tripous.ResLib.Icons8_32x32.Icons8_Management_online_support.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Management_Statistics = "Tripous.ResLib.Icons8_32x32.Icons8_Management_statistics.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Mathematic_Divide = "Tripous.ResLib.Icons8_32x32.Icons8_Mathematic_divide.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Mathematic_Divide2 = "Tripous.ResLib.Icons8_32x32.Icons8_Mathematic_divide2.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Mathematic_Equal_Sign = "Tripous.ResLib.Icons8_32x32.Icons8_Mathematic_equal_sign.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Mathematic_Equal_Sign2 = "Tripous.ResLib.Icons8_32x32.Icons8_Mathematic_equal_sign2.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Mathematic_Minus = "Tripous.ResLib.Icons8_32x32.Icons8_Mathematic_minus.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Mathematic_Minus2 = "Tripous.ResLib.Icons8_32x32.Icons8_Mathematic_minus2.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Mathematic_Multiply = "Tripous.ResLib.Icons8_32x32.Icons8_Mathematic_multiply.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Mathematic_Multiply2 = "Tripous.ResLib.Icons8_32x32.Icons8_Mathematic_multiply2.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Mathematic_Percentage = "Tripous.ResLib.Icons8_32x32.Icons8_Mathematic_percentage.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Mathematic_Percentage2 = "Tripous.ResLib.Icons8_32x32.Icons8_Mathematic_percentage2.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Mathematic_Plus = "Tripous.ResLib.Icons8_32x32.Icons8_Mathematic_plus.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Mathematic_Plus_Minus = "Tripous.ResLib.Icons8_32x32.Icons8_Mathematic_plus_minus.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Mathematic_Plus_Minus2 = "Tripous.ResLib.Icons8_32x32.Icons8_Mathematic_plus_minus2.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Mathematic_Plus2 = "Tripous.ResLib.Icons8_32x32.Icons8_Mathematic_plus2.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Mathematic_Square_Root = "Tripous.ResLib.Icons8_32x32.Icons8_Mathematic_square_root.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Mathematic_Square_Root2 = "Tripous.ResLib.Icons8_32x32.Icons8_Mathematic_square_root2.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Media_Eject = "Tripous.ResLib.Icons8_32x32.Icons8_Media_eject.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Media_End = "Tripous.ResLib.Icons8_32x32.Icons8_Media_end.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Media_Fast_Forward = "Tripous.ResLib.Icons8_32x32.Icons8_Media_fast_forward.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Media_Pause = "Tripous.ResLib.Icons8_32x32.Icons8_Media_pause.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Media_Play = "Tripous.ResLib.Icons8_32x32.Icons8_Media_play.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Media_Record = "Tripous.ResLib.Icons8_32x32.Icons8_Media_record.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Media_Repeat = "Tripous.ResLib.Icons8_32x32.Icons8_Media_repeat.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Media_Rewind = "Tripous.ResLib.Icons8_32x32.Icons8_Media_rewind.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Media_Shuffle = "Tripous.ResLib.Icons8_32x32.Icons8_Media_shuffle.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Media_Skip_To_Start = "Tripous.ResLib.Icons8_32x32.Icons8_Media_skip_to_start.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Media_Stop = "Tripous.ResLib.Icons8_32x32.Icons8_Media_stop.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Medicine_Ambulance = "Tripous.ResLib.Icons8_32x32.Icons8_Medicine_ambulance.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Medicine_Amputee = "Tripous.ResLib.Icons8_32x32.Icons8_Medicine_amputee.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Medicine_Antiseptic_Cream = "Tripous.ResLib.Icons8_32x32.Icons8_Medicine_antiseptic_cream.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Medicine_Bandage = "Tripous.ResLib.Icons8_32x32.Icons8_Medicine_bandage.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Medicine_Brain = "Tripous.ResLib.Icons8_32x32.Icons8_Medicine_brain.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Medicine_Clinic = "Tripous.ResLib.Icons8_32x32.Icons8_Medicine_clinic.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Medicine_Doctor_Suitecase = "Tripous.ResLib.Icons8_32x32.Icons8_Medicine_doctor_suitecase.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Medicine_Foil_Space_Blanket = "Tripous.ResLib.Icons8_32x32.Icons8_Medicine_foil_space_blanket.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Medicine_Heart_Monitor = "Tripous.ResLib.Icons8_32x32.Icons8_Medicine_heart_monitor.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Medicine_Micropore_Tape = "Tripous.ResLib.Icons8_32x32.Icons8_Medicine_micropore_tape.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Medicine_Pill = "Tripous.ResLib.Icons8_32x32.Icons8_Medicine_pill.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Medicine_Pincette = "Tripous.ResLib.Icons8_32x32.Icons8_Medicine_pincette.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Medicine_Plaster = "Tripous.ResLib.Icons8_32x32.Icons8_Medicine_plaster.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Medicine_Safety_Pin = "Tripous.ResLib.Icons8_32x32.Icons8_Medicine_safety_pin.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Medicine_Scissors = "Tripous.ResLib.Icons8_32x32.Icons8_Medicine_scissors.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Medicine_Skeleton = "Tripous.ResLib.Icons8_32x32.Icons8_Medicine_skeleton.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Medicine_Stethoscope = "Tripous.ResLib.Icons8_32x32.Icons8_Medicine_stethoscope.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Medicine_Stomach = "Tripous.ResLib.Icons8_32x32.Icons8_Medicine_stomach.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Medicine_Syringe = "Tripous.ResLib.Icons8_32x32.Icons8_Medicine_syringe.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Medicine_Thermometer = "Tripous.ResLib.Icons8_32x32.Icons8_Medicine_thermometer.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Medicine_Triangular_Bandage = "Tripous.ResLib.Icons8_32x32.Icons8_Medicine_triangular_bandage.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Medicine_Wipes = "Tripous.ResLib.Icons8_32x32.Icons8_Medicine_wipes.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Medicine_Xray = "Tripous.ResLib.Icons8_32x32.Icons8_Medicine_xray.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Memory_Card_Micro_Sd = "Tripous.ResLib.Icons8_32x32.Icons8_Memory_Card_micro_sd.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Memory_Card_Sd = "Tripous.ResLib.Icons8_32x32.Icons8_Memory_Card_sd.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Memory_Card_Torrent = "Tripous.ResLib.Icons8_32x32.Icons8_Memory_Card_torrent.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Military_Ammo_Tin = "Tripous.ResLib.Icons8_32x32.Icons8_Military_ammo_tin.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Military_Backpack_Radio = "Tripous.ResLib.Icons8_32x32.Icons8_military_backpack_radio.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Military_Blunderbuss = "Tripous.ResLib.Icons8_32x32.Icons8_Military_blunderbuss.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Military_Bomb = "Tripous.ResLib.Icons8_32x32.Icons8_Military_bomb.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Military_Boots = "Tripous.ResLib.Icons8_32x32.Icons8_Military_boots.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Military_Camo_Cream = "Tripous.ResLib.Icons8_32x32.Icons8_Military_camo_cream.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Military_Cannon = "Tripous.ResLib.Icons8_32x32.Icons8_Military_cannon.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Military_Explosion = "Tripous.ResLib.Icons8_32x32.Icons8_Military_explosion.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Military_Flash_Bang = "Tripous.ResLib.Icons8_32x32.Icons8_Military_flash_bang.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Military_Gatling_Gun = "Tripous.ResLib.Icons8_32x32.Icons8_Military_gatling_gun.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Military_Grenade = "Tripous.ResLib.Icons8_32x32.Icons8_Military_grenade.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Military_Gun = "Tripous.ResLib.Icons8_32x32.Icons8_Military_gun.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Military_Helmet = "Tripous.ResLib.Icons8_32x32.Icons8_Military_helmet.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Military_Incendiary_Grenade = "Tripous.ResLib.Icons8_32x32.Icons8_Military_incendiary_grenade.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Military_Knife = "Tripous.ResLib.Icons8_32x32.Icons8_Military_knife.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Military_Magazin = "Tripous.ResLib.Icons8_32x32.Icons8_Military_magazin.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Military_Marine_Radio = "Tripous.ResLib.Icons8_32x32.Icons8_Military_marine_radio.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Military_Medal = "Tripous.ResLib.Icons8_32x32.Icons8_Military_medal.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Military_Missile = "Tripous.ResLib.Icons8_32x32.Icons8_Military_missile.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Military_Mortar = "Tripous.ResLib.Icons8_32x32.Icons8_Military_mortar.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Military_Mushroom_Cloud = "Tripous.ResLib.Icons8_32x32.Icons8_Military_mushroom_cloud.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Military_Nightvision = "Tripous.ResLib.Icons8_32x32.Icons8_Military_nightvision.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Military_Rifle = "Tripous.ResLib.Icons8_32x32.Icons8_Military_rifle.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Military_Rpg = "Tripous.ResLib.Icons8_32x32.Icons8_Military_rpg.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Military_Rucksach = "Tripous.ResLib.Icons8_32x32.Icons8_Military_rucksach.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Military_Self_Distract_Button = "Tripous.ResLib.Icons8_32x32.Icons8_Military_self_distract_button.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Military_Service_Air_Force = "Tripous.ResLib.Icons8_32x32.Icons8_Military_Service_air_force.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Military_Service_British_Army = "Tripous.ResLib.Icons8_32x32.Icons8_Military_Service_british-army.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Military_Service_Royal_Marines = "Tripous.ResLib.Icons8_32x32.Icons8_Military_Service_royal_marines.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Military_Service_Royal_Navy = "Tripous.ResLib.Icons8_32x32.Icons8_Military_Service_royal_navy.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Military_Smoke_Explosion = "Tripous.ResLib.Icons8_32x32.Icons8_Military_smoke_explosion.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Military_Sniper_Rifle = "Tripous.ResLib.Icons8_32x32.Icons8_Military_sniper_rifle.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Military_Tent = "Tripous.ResLib.Icons8_32x32.Icons8_Military_tent.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Military_Walkie_Talkie_Radio = "Tripous.ResLib.Icons8_32x32.Icons8_Military_walkie_talkie_radio.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Military_Webbing = "Tripous.ResLib.Icons8_32x32.Icons8_Military_webbing.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Miscs_Conference = "Tripous.ResLib.Icons8_32x32.Icons8_Miscs_conference.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Miscs_Paper = "Tripous.ResLib.Icons8_32x32.Icons8_Miscs_paper.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Miscs_Rock = "Tripous.ResLib.Icons8_32x32.Icons8_Miscs_rock.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Miscs_Scissors = "Tripous.ResLib.Icons8_32x32.Icons8_Miscs_scissors.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Movie_Genre_Action = "Tripous.ResLib.Icons8_32x32.Icons8_Movie_Genre_action.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Movie_Genre_Actions2 = "Tripous.ResLib.Icons8_32x32.Icons8_Movie_Genre_actions2.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Movie_Genre_Adventures = "Tripous.ResLib.Icons8_32x32.Icons8_Movie_Genre_adventures.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Movie_Genre_Comedy = "Tripous.ResLib.Icons8_32x32.Icons8_Movie_Genre_comedy.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Movie_Genre_Comedy2 = "Tripous.ResLib.Icons8_32x32.Icons8_Movie_Genre_comedy2.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Movie_Genre_Crime = "Tripous.ResLib.Icons8_32x32.Icons8_Movie_Genre_crime.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Movie_Genre_Detective = "Tripous.ResLib.Icons8_32x32.Icons8_Movie_Genre_detective.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Movie_Genre_Documentary = "Tripous.ResLib.Icons8_32x32.Icons8_Movie_Genre_documentary.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Movie_Genre_Drama = "Tripous.ResLib.Icons8_32x32.Icons8_Movie_Genre_drama.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Movie_Genre_Erotic_Bottom = "Tripous.ResLib.Icons8_32x32.Icons8_Movie_Genre_erotic_bottom.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Movie_Genre_Erotic_Breast = "Tripous.ResLib.Icons8_32x32.Icons8_Movie_Genre_erotic_breast.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Movie_Genre_Fantasy = "Tripous.ResLib.Icons8_32x32.Icons8_Movie_Genre_fantasy.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Movie_Genre_Historical = "Tripous.ResLib.Icons8_32x32.Icons8_Movie_Genre_historical.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Movie_Genre_Horror = "Tripous.ResLib.Icons8_32x32.Icons8_Movie_Genre_horror.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Movie_Genre_Music = "Tripous.ResLib.Icons8_32x32.Icons8_Movie_Genre_music.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Movie_Genre_Novel = "Tripous.ResLib.Icons8_32x32.Icons8_Movie_Genre_novel.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Movie_Genre_Sci_Fi = "Tripous.ResLib.Icons8_32x32.Icons8_Movie_Genre_sci_fi.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Movie_Genre_Sport = "Tripous.ResLib.Icons8_32x32.Icons8_Movie_Genre_sport.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Movie_Genre_Triller = "Tripous.ResLib.Icons8_32x32.Icons8_Movie_Genre_triller.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Movie_Genre_Western = "Tripous.ResLib.Icons8_32x32.Icons8_Movie_Genre_western.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string MS_Office_Excel = "Tripous.ResLib.Icons8_32x32.Icons8_MS_Office_excel.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string MS_Office_Novel = "Tripous.ResLib.Icons8_32x32.Icons8_MS_Office_novel.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string MS_Office_One_Note = "Tripous.ResLib.Icons8_32x32.Icons8_MS_Office_one_note.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string MS_Office_Outlook = "Tripous.ResLib.Icons8_32x32.Icons8_MS_Office_outlook.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string MS_Office_Powerpoint = "Tripous.ResLib.Icons8_32x32.Icons8_MS_Office_powerpoint.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string MS_Office_Publisher = "Tripous.ResLib.Icons8_32x32.Icons8_MS_Office_publisher.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string MS_Office_Share_Point = "Tripous.ResLib.Icons8_32x32.Icons8_MS_Office_share_point.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string MS_Office_Word = "Tripous.ResLib.Icons8_32x32.Icons8_MS_Office_word.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string MU_Degrees = "Tripous.ResLib.Icons8_32x32.Icons8_MU_degrees.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string MU_Length = "Tripous.ResLib.Icons8_32x32.Icons8_MU_length.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string MU_Pressure = "Tripous.ResLib.Icons8_32x32.Icons8_MU_pressure.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string MU_Speed = "Tripous.ResLib.Icons8_32x32.Icons8_MU_speed.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string MU_Surface = "Tripous.ResLib.Icons8_32x32.Icons8_MU_surface.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string MU_Temperature = "Tripous.ResLib.Icons8_32x32.Icons8_MU_temperature.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string MU_Time = "Tripous.ResLib.Icons8_32x32.Icons8_MU_time.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string MU_Volume = "Tripous.ResLib.Icons8_32x32.Icons8_MU_volume.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string MU_Weight = "Tripous.ResLib.Icons8_32x32.Icons8_MU_weight.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Music_Alto_Saxophone = "Tripous.ResLib.Icons8_32x32.Icons8_Music_alto_saxophone.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Music_Applouse = "Tripous.ResLib.Icons8_32x32.Icons8_Music_applouse.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Music_Audio_Wave = "Tripous.ResLib.Icons8_32x32.Icons8_Music_audio_wave.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Music_Audio_Wave2 = "Tripous.ResLib.Icons8_32x32.Icons8_Music_audio_wave2.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Music_Autograf = "Tripous.ResLib.Icons8_32x32.Icons8_Music_autograf.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Music_Bandmasters_Mace = "Tripous.ResLib.Icons8_32x32.Icons8_Music_bandmasters_mace.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Music_Bass_Drum = "Tripous.ResLib.Icons8_32x32.Icons8_Music_bass_drum.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Music_Bell_Lyre = "Tripous.ResLib.Icons8_32x32.Icons8_Music_bell_lyre.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Music_Boombox = "Tripous.ResLib.Icons8_32x32.Icons8_Music_boombox.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Music_Bugle = "Tripous.ResLib.Icons8_32x32.Icons8_Music_bugle.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Music_Clarnet = "Tripous.ResLib.Icons8_32x32.Icons8_Music_clarnet.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Music_Conduktor = "Tripous.ResLib.Icons8_32x32.Icons8_music_conduktor.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Music_Cornet = "Tripous.ResLib.Icons8_32x32.Icons8_Music_cornet.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Music_Cymbals = "Tripous.ResLib.Icons8_32x32.Icons8_Music_cymbals.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Music_Dj = "Tripous.ResLib.Icons8_32x32.Icons8_Music_dj.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Music_French_Horn = "Tripous.ResLib.Icons8_32x32.Icons8_Music_french_horn.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Music_Guitar = "Tripous.ResLib.Icons8_32x32.Icons8_Music_guitar.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Music_Herald_Trumpet = "Tripous.ResLib.Icons8_32x32.Icons8_Music_herald_trumpet.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Music_Loudspeaker = "Tripous.ResLib.Icons8_32x32.Icons8_Music_loudspeaker.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Music_Microphone = "Tripous.ResLib.Icons8_32x32.Icons8_Music_microphone.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Music_Microphone2 = "Tripous.ResLib.Icons8_32x32.Icons8_Music_microphone2.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Music_Note = "Tripous.ResLib.Icons8_32x32.Icons8_Music_note.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Music_Piccolo = "Tripous.ResLib.Icons8_32x32.Icons8_Music_piccolo.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Music_Radio1 = "Tripous.ResLib.Icons8_32x32.Icons8_Music_radio1.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Music_Radio2 = "Tripous.ResLib.Icons8_32x32.Icons8_Music_radio2.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Music_Record = "Tripous.ResLib.Icons8_32x32.Icons8_music_record.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Music_Saxophone = "Tripous.ResLib.Icons8_32x32.Icons8_Music_saxophone.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Music_Side_Drum = "Tripous.ResLib.Icons8_32x32.Icons8_Music_side_drum.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Music_Trambone = "Tripous.ResLib.Icons8_32x32.Icons8_Music_trambone.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Music_Treble_Clef = "Tripous.ResLib.Icons8_32x32.Icons8_Music_treble_clef.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Music_Trumpet = "Tripous.ResLib.Icons8_32x32.Icons8_Music_trumpet.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Music_Tuba = "Tripous.ResLib.Icons8_32x32.Icons8_Music_tuba.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Music_Violin = "Tripous.ResLib.Icons8_32x32.Icons8_Music_violin.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Music_Xylophone = "Tripous.ResLib.Icons8_32x32.Icons8_Music_xylophone.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Network_High_Connection = "Tripous.ResLib.Icons8_32x32.Icons8_Network_high_connection.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Network_Low_Connection = "Tripous.ResLib.Icons8_32x32.Icons8_Network_low_connection.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Network_Medium_Connection = "Tripous.ResLib.Icons8_32x32.Icons8_Network_medium_connection.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Network_No_Connection = "Tripous.ResLib.Icons8_32x32.Icons8_Network_no_connection.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Nui1 = "Tripous.ResLib.Icons8_32x32.Icons8_nui1.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Nui2 = "Tripous.ResLib.Icons8_32x32.Icons8_nui2.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Number_0 = "Tripous.ResLib.Icons8_32x32.Icons8_Number_0.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Number_0_Filled = "Tripous.ResLib.Icons8_32x32.Icons8_Number_0_filled.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Number_1 = "Tripous.ResLib.Icons8_32x32.Icons8_Number_1.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Number_1_Filled = "Tripous.ResLib.Icons8_32x32.Icons8_Number_1_filled.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Number_2 = "Tripous.ResLib.Icons8_32x32.Icons8_Number_2.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Number_2_Filled = "Tripous.ResLib.Icons8_32x32.Icons8_Number_2_filled.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Number_3 = "Tripous.ResLib.Icons8_32x32.Icons8_Number_3.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Number_3_Filled = "Tripous.ResLib.Icons8_32x32.Icons8_Number_3_filled.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Number_4 = "Tripous.ResLib.Icons8_32x32.Icons8_Number_4.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Number_4_Filled = "Tripous.ResLib.Icons8_32x32.Icons8_Number_4_filled.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Number_5 = "Tripous.ResLib.Icons8_32x32.Icons8_Number_5.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Number_5_Filled = "Tripous.ResLib.Icons8_32x32.Icons8_Number_5_filled.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Number_6 = "Tripous.ResLib.Icons8_32x32.Icons8_Number_6.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Number_6_Filled = "Tripous.ResLib.Icons8_32x32.Icons8_Number_6_filled.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Number_7 = "Tripous.ResLib.Icons8_32x32.Icons8_Number_7.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Number_7_Filled = "Tripous.ResLib.Icons8_32x32.Icons8_Number_7_filled.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Number_8 = "Tripous.ResLib.Icons8_32x32.Icons8_Number_8.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Number_8_Filled = "Tripous.ResLib.Icons8_32x32.Icons8_Number_8_filled.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Number_9 = "Tripous.ResLib.Icons8_32x32.Icons8_Number_9.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Number_9_Filled = "Tripous.ResLib.Icons8_32x32.Icons8_Number_9_filled.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Object_Box = "Tripous.ResLib.Icons8_32x32.Icons8_Object_box.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Object_Burn_Cd = "Tripous.ResLib.Icons8_32x32.Icons8_Object_burn_cd.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Object_Empty_Filter = "Tripous.ResLib.Icons8_32x32.Icons8_Object_empty_filter.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Object_Female = "Tripous.ResLib.Icons8_32x32.Icons8_Object_female.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Object_Filing_Cabinet = "Tripous.ResLib.Icons8_32x32.Icons8_Object_filing_cabinet.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Object_Filled_Filter = "Tripous.ResLib.Icons8_32x32.Icons8_Object_filled_filter.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Object_Hot_Articcle = "Tripous.ResLib.Icons8_32x32.Icons8_Object_hot_articcle.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Object_Joystick = "Tripous.ResLib.Icons8_32x32.Icons8_Object_joystick.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Object_Lifebuoy = "Tripous.ResLib.Icons8_32x32.Icons8_Object_lifebuoy.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Object_Male = "Tripous.ResLib.Icons8_32x32.Icons8_Object_male.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Object_Megafone1 = "Tripous.ResLib.Icons8_32x32.Icons8_Object_megafone1.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Object_Megafone2 = "Tripous.ResLib.Icons8_32x32.Icons8_Object_megafone2.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Object_No_Smoking = "Tripous.ResLib.Icons8_32x32.Icons8_Object_no_smoking.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Object_Note = "Tripous.ResLib.Icons8_32x32.Icons8_Object_note.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Object_Paper_Plane = "Tripous.ResLib.Icons8_32x32.Icons8_Object_paper_plane.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Object_Phone1 = "Tripous.ResLib.Icons8_32x32.Icons8_Object_phone1.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Object_Phone2 = "Tripous.ResLib.Icons8_32x32.Icons8_Object_phone2.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Object_Plugin = "Tripous.ResLib.Icons8_32x32.Icons8_Object_plugin.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Object_Pocket_Lantern = "Tripous.ResLib.Icons8_32x32.Icons8_Object_pocket_lantern.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Object_Poo = "Tripous.ResLib.Icons8_32x32.Icons8_Object_poo.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Object_Rocket = "Tripous.ResLib.Icons8_32x32.Icons8_Object_rocket.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Object_Running_Man = "Tripous.ResLib.Icons8_32x32.Icons8_Object_running_man.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Object_Sandglass = "Tripous.ResLib.Icons8_32x32.Icons8_Object_sandglass.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Object_Scale = "Tripous.ResLib.Icons8_32x32.Icons8_Object_scale.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Object_Scales = "Tripous.ResLib.Icons8_32x32.Icons8_Object_scales.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Object_Signal_Horn = "Tripous.ResLib.Icons8_32x32.Icons8_Object_signal_horn.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Object_Smoking = "Tripous.ResLib.Icons8_32x32.Icons8_Object_smoking.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Object_Software_Box = "Tripous.ResLib.Icons8_32x32.Icons8_Object_software_box.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Object_Switch_Off = "Tripous.ResLib.Icons8_32x32.Icons8_Object_switch_off.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Object_Switch_On = "Tripous.ResLib.Icons8_32x32.Icons8_Object_switch_on.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Object_Tear_Of_Calendar = "Tripous.ResLib.Icons8_32x32.Icons8_Object_tear_of_calendar.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Object_Timer = "Tripous.ResLib.Icons8_32x32.Icons8_Object_timer.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Object_Umbrella = "Tripous.ResLib.Icons8_32x32.Icons8_Object_umbrella.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Office_3D_Printer = "Tripous.ResLib.Icons8_32x32.Icons8_Office_3d_printer.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Office_Cnc_Machine = "Tripous.ResLib.Icons8_32x32.Icons8_Office_cnc_machine.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Office_Phone = "Tripous.ResLib.Icons8_32x32.Icons8_Office_phone.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Office_Planner = "Tripous.ResLib.Icons8_32x32.Icons8_Office_planner.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Office_Printer = "Tripous.ResLib.Icons8_32x32.Icons8_Office_printer.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Office_Tool_Box = "Tripous.ResLib.Icons8_32x32.Icons8_Office_tool_box.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Office_Video_Projector = "Tripous.ResLib.Icons8_32x32.Icons8_Office_video_projector.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Office_Wired_Network = "Tripous.ResLib.Icons8_32x32.Icons8_Office_wired_network.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string OS_Be_Os = "Tripous.ResLib.Icons8_32x32.Icons8_OS_be_os.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string OS_Dos = "Tripous.ResLib.Icons8_32x32.Icons8_OS_dos.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string OS_Free_Bsd = "Tripous.ResLib.Icons8_32x32.Icons8_OS_free_bsd.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string OS_Haiku = "Tripous.ResLib.Icons8_32x32.Icons8_OS_haiku.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string OS_Linux = "Tripous.ResLib.Icons8_32x32.Icons8_OS_linux.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string OS_Mac_Os = "Tripous.ResLib.Icons8_32x32.Icons8_OS_mac_os.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string OS_Unix = "Tripous.ResLib.Icons8_32x32.Icons8_OS_unix.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string OS_Windows = "Tripous.ResLib.Icons8_32x32.Icons8_OS_windows.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string OS_Windows8 = "Tripous.ResLib.Icons8_32x32.Icons8_OS_windows8.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Os2 = "Tripous.ResLib.Icons8_32x32.Icons8_os2.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Page_1 = "Tripous.ResLib.Icons8_32x32.Icons8_Page_1.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Page_2 = "Tripous.ResLib.Icons8_32x32.Icons8_Page_2.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Page_3 = "Tripous.ResLib.Icons8_32x32.Icons8_Page_3.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Page_4 = "Tripous.ResLib.Icons8_32x32.Icons8_Page_4.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Pager_First = "Tripous.ResLib.Icons8_32x32.Icons8_Pager_first.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Pager_Last = "Tripous.ResLib.Icons8_32x32.Icons8_Pager_last.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Pager_Next = "Tripous.ResLib.Icons8_32x32.Icons8_Pager_next.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Pager_Previous = "Tripous.ResLib.Icons8_32x32.Icons8_Pager_previous.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Payment_Method_Amex = "Tripous.ResLib.Icons8_32x32.Icons8_Payment_Method_amex.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Payment_Method_Bank_Cards = "Tripous.ResLib.Icons8_32x32.Icons8_Payment_Method_bank_cards.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Payment_Method_Banknotes = "Tripous.ResLib.Icons8_32x32.Icons8_Payment_Method_banknotes.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Payment_Method_Barcode = "Tripous.ResLib.Icons8_32x32.Icons8_Payment_Method_barcode.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Payment_Method_Card_In_Use = "Tripous.ResLib.Icons8_32x32.Icons8_Payment_Method_card_in_use.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Payment_Method_Card_Inserting = "Tripous.ResLib.Icons8_32x32.Icons8_Payment_Method_card_inserting.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Payment_Method_Cash_Receiving = "Tripous.ResLib.Icons8_32x32.Icons8_Payment_Method_cash_receiving.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Payment_Method_Check_Book = "Tripous.ResLib.Icons8_32x32.Icons8_Payment_Method_check_book.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Payment_Method_Coins = "Tripous.ResLib.Icons8_32x32.Icons8_Payment_Method_coins.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Payment_Method_Jcb = "Tripous.ResLib.Icons8_32x32.Icons8_Payment_Method_jcb.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Payment_Method_Mastercard = "Tripous.ResLib.Icons8_32x32.Icons8_Payment_Method_mastercard.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Payment_Method_Moneybox = "Tripous.ResLib.Icons8_32x32.Icons8_Payment_Method_moneybox.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Payment_Method_Purse = "Tripous.ResLib.Icons8_32x32.Icons8_Payment_Method_purse.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Payment_Method_Shopping_Basket = "Tripous.ResLib.Icons8_32x32.Icons8_Payment_Method_shopping_basket.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Payment_Method_Visa = "Tripous.ResLib.Icons8_32x32.Icons8_Payment_Method_visa.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Payment_Method_Wallet = "Tripous.ResLib.Icons8_32x32.Icons8_Payment_Method_wallet.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Pet_Bird = "Tripous.ResLib.Icons8_32x32.Icons8_Pet_bird.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Pet_Cat = "Tripous.ResLib.Icons8_32x32.Icons8_Pet_cat.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Pet_Dog = "Tripous.ResLib.Icons8_32x32.Icons8_Pet_dog.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Pet_Fish = "Tripous.ResLib.Icons8_32x32.Icons8_Pet_fish.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Pet_Rabbit = "Tripous.ResLib.Icons8_32x32.Icons8_Pet_rabbit.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Phone_Call_Transfer = "Tripous.ResLib.Icons8_32x32.Icons8_Phone_call_transfer.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Phone_Conference_Call = "Tripous.ResLib.Icons8_32x32.Icons8_Phone_conference_call.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Phone_Dnd = "Tripous.ResLib.Icons8_32x32.Icons8_Phone_dnd.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Phone_Headset = "Tripous.ResLib.Icons8_32x32.Icons8_Phone_headset.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Phone_Missed_Call = "Tripous.ResLib.Icons8_32x32.Icons8_Phone_missed_call.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Phone_Speaker = "Tripous.ResLib.Icons8_32x32.Icons8_Phone_speaker.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Phone_Video_Call = "Tripous.ResLib.Icons8_32x32.Icons8_Phone_video_call.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Photo_Video_Add_Image = "Tripous.ResLib.Icons8_32x32.Icons8_Photo_Video_add_image.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Photo_Video_Camcoder = "Tripous.ResLib.Icons8_32x32.Icons8_Photo_Video_camcoder.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Photo_Video_Camcoder_Pro = "Tripous.ResLib.Icons8_32x32.Icons8_Photo_Video_camcoder_pro.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Photo_Video_Clapperboard = "Tripous.ResLib.Icons8_32x32.Icons8_Photo_Video_clapperboard.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Photo_Video_Compact_Camera = "Tripous.ResLib.Icons8_32x32.Icons8_Photo_Video_compact_camera.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Photo_Video_Edit_Image = "Tripous.ResLib.Icons8_32x32.Icons8_Photo_Video_edit_image.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Photo_Video_Film = "Tripous.ResLib.Icons8_32x32.Icons8_Photo_Video_film.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Photo_Video_Film_Reel = "Tripous.ResLib.Icons8_32x32.Icons8_Photo_Video_film_reel.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Photo_Video_Film2 = "Tripous.ResLib.Icons8_32x32.Icons8_Photo_Video_film2.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Photo_Video_Gallery = "Tripous.ResLib.Icons8_32x32.Icons8_Photo_Video_gallery.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Photo_Video_Integrated_Webcam = "Tripous.ResLib.Icons8_32x32.Icons8_Photo_Video_integrated_webcam.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Photo_Video_Old_Time_Camera = "Tripous.ResLib.Icons8_32x32.Icons8_Photo_Video_old_time_camera.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Photo_Video_Remove_Image = "Tripous.ResLib.Icons8_32x32.Icons8_Photo_Video_remove_image.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Photo_Video_Slr_Camera = "Tripous.ResLib.Icons8_32x32.Icons8_Photo_Video_slr_camera.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Photo_Video_Slr_Camera2 = "Tripous.ResLib.Icons8_32x32.Icons8_Photo_Video_slr_camera2.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Photo_Video_Stack_Of_Photos = "Tripous.ResLib.Icons8_32x32.Icons8_Photo_Video_stack_of_photos.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Photo_Video_Start = "Tripous.ResLib.Icons8_32x32.Icons8_Photo_Video_start.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Photo_Video_Webcam = "Tripous.ResLib.Icons8_32x32.Icons8_Photo_Video_webcam.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Plants_Barley = "Tripous.ResLib.Icons8_32x32.Icons8_Plants_barley.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Plants_Berry = "Tripous.ResLib.Icons8_32x32.Icons8_Plants_berry.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Plants_Citrus = "Tripous.ResLib.Icons8_32x32.Icons8_Plants_citrus.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Plants_Coniferous_Tree = "Tripous.ResLib.Icons8_32x32.Icons8_Plants_coniferous_tree.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Plants_Deciduous_Tree = "Tripous.ResLib.Icons8_32x32.Icons8_Plants_deciduous_tree.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Plants_Flower = "Tripous.ResLib.Icons8_32x32.Icons8_Plants_flower.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Plants_Grapes = "Tripous.ResLib.Icons8_32x32.Icons8_Plants_grapes.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Plants_Grass = "Tripous.ResLib.Icons8_32x32.Icons8_Plants_grass.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Plants_Hazelnut = "Tripous.ResLib.Icons8_32x32.Icons8_Plants_hazelnut.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Plants_Hops = "Tripous.ResLib.Icons8_32x32.Icons8_Plants_hops.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Plants_Leaf = "Tripous.ResLib.Icons8_32x32.Icons8_Plants_leaf.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Plants_Leaf2 = "Tripous.ResLib.Icons8_32x32.Icons8_Plants_leaf2.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Plants_Leaf3 = "Tripous.ResLib.Icons8_32x32.Icons8_Plants_leaf3.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Plants_Nut = "Tripous.ResLib.Icons8_32x32.Icons8_Plants_nut.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Plants_Palm_Tree = "Tripous.ResLib.Icons8_32x32.Icons8_Plants_palm_tree.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Plants_Peanuts = "Tripous.ResLib.Icons8_32x32.Icons8_Plants_peanuts.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Plants_Soy = "Tripous.ResLib.Icons8_32x32.Icons8_Plants_soy.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Plants_Tomato = "Tripous.ResLib.Icons8_32x32.Icons8_Plants_tomato.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Plants_Wheat = "Tripous.ResLib.Icons8_32x32.Icons8_Plants_wheat.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Power_Button_Hibernate = "Tripous.ResLib.Icons8_32x32.Icons8_Power_Button_hibernate.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Power_Button_Restart = "Tripous.ResLib.Icons8_32x32.Icons8_Power_Button_restart.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Power_Button_Shutdown = "Tripous.ResLib.Icons8_32x32.Icons8_Power_Button_shutdown.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Power_Button_Sleep = "Tripous.ResLib.Icons8_32x32.Icons8_Power_Button_sleep.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Print_Preview_Fit_To_Width = "Tripous.ResLib.Icons8_32x32.Icons8_Print_Preview_fit_to_width.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Print_Preview_One_Page = "Tripous.ResLib.Icons8_32x32.Icons8_Print_Preview_one_page.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Print_Preview_Two_Page = "Tripous.ResLib.Icons8_32x32.Icons8_Print_Preview_two_page.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Printed_Matter_Book = "Tripous.ResLib.Icons8_32x32.Icons8_Printed_Matter_book.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Printed_Matter_Book_Stack = "Tripous.ResLib.Icons8_32x32.Icons8_Printed_Matter_book_stack.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Printed_Matter_Books = "Tripous.ResLib.Icons8_32x32.Icons8_Printed_Matter_books.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Printed_Matter_Magazine = "Tripous.ResLib.Icons8_32x32.Icons8_Printed_Matter_magazine.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Printed_Matter_Newspaper = "Tripous.ResLib.Icons8_32x32.Icons8_Printed_Matter_newspaper.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Repair_Drill = "Tripous.ResLib.Icons8_32x32.Icons8_Repair_drill.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Repair_Hammer = "Tripous.ResLib.Icons8_32x32.Icons8_Repair_hammer.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Repair_Nail = "Tripous.ResLib.Icons8_32x32.Icons8_Repair_nail.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Repair_Paint_Brush = "Tripous.ResLib.Icons8_32x32.Icons8_Repair_paint_brush.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Repair_Paint_Bucket = "Tripous.ResLib.Icons8_32x32.Icons8_Repair_paint_bucket.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Repair_Screw = "Tripous.ResLib.Icons8_32x32.Icons8_Repair_screw.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Repair_Screwdriver = "Tripous.ResLib.Icons8_32x32.Icons8_Repair_screwdriver.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Repair_Tape_Measure = "Tripous.ResLib.Icons8_32x32.Icons8_Repair_tape_measure.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Repair_Wallpaper_Roll = "Tripous.ResLib.Icons8_32x32.Icons8_Repair_wallpaper_roll.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Scheduler_Date_From = "Tripous.ResLib.Icons8_32x32.Icons8_Scheduler_date_from.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Scheduler_Date_To = "Tripous.ResLib.Icons8_32x32.Icons8_Scheduler_date_to.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Scheduler_Day_View = "Tripous.ResLib.Icons8_32x32.Icons8_Scheduler_day_view.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Scheduler_Gantt_Chart = "Tripous.ResLib.Icons8_32x32.Icons8_Scheduler_gantt_chart.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Scheduler_Grid = "Tripous.ResLib.Icons8_32x32.Icons8_Scheduler_grid.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Scheduler_List = "Tripous.ResLib.Icons8_32x32.Icons8_Scheduler_list.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Scheduler_Month_View = "Tripous.ResLib.Icons8_32x32.Icons8_Scheduler_month_view.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Scheduler_Timeline = "Tripous.ResLib.Icons8_32x32.Icons8_Scheduler_timeline.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Scheduler_Today = "Tripous.ResLib.Icons8_32x32.Icons8_Scheduler_today.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Scheduler_Week_View = "Tripous.ResLib.Icons8_32x32.Icons8_Scheduler_week_view.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Science_Business = "Tripous.ResLib.Icons8_32x32.Icons8_Science_business.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Science_Dna_Helix = "Tripous.ResLib.Icons8_32x32.Icons8_Science_dna_helix.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Science_Geography = "Tripous.ResLib.Icons8_32x32.Icons8_Science_geography.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Science_Geometry = "Tripous.ResLib.Icons8_32x32.Icons8_Science_geometry.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Science_Informatics = "Tripous.ResLib.Icons8_32x32.Icons8_Science_informatics.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Science_Law = "Tripous.ResLib.Icons8_32x32.Icons8_Science_law.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Science_Literature = "Tripous.ResLib.Icons8_32x32.Icons8_Science_literature.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Science_Math = "Tripous.ResLib.Icons8_32x32.Icons8_Science_math.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Science_Physics = "Tripous.ResLib.Icons8_32x32.Icons8_Science_physics.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Science_Plasmid = "Tripous.ResLib.Icons8_32x32.Icons8_Science_plasmid.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Science_Psyhology = "Tripous.ResLib.Icons8_32x32.Icons8_Science_psyhology.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Science_School = "Tripous.ResLib.Icons8_32x32.Icons8_Science_school.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Science_Test_Tube = "Tripous.ResLib.Icons8_32x32.Icons8_Science_test_tube.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Science_Trigonometry = "Tripous.ResLib.Icons8_32x32.Icons8_Science_trigonometry.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Science_University = "Tripous.ResLib.Icons8_32x32.Icons8_Science_university.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Security_App_Shield = "Tripous.ResLib.Icons8_32x32.Icons8_Security_app_shield.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Security_Delete_Shield = "Tripous.ResLib.Icons8_32x32.Icons8_Security_delete_shield.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Security_Firewall = "Tripous.ResLib.Icons8_32x32.Icons8_Security_firewall.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Security_Key = "Tripous.ResLib.Icons8_32x32.Icons8_Security_key.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Security_Question_Shield = "Tripous.ResLib.Icons8_32x32.Icons8_Security_question_shield.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Security_Refresh_Shield = "Tripous.ResLib.Icons8_32x32.Icons8_Security_refresh_shield.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Security_Restriction_Shield = "Tripous.ResLib.Icons8_32x32.Icons8_Security_restriction_shield.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Security_Shield = "Tripous.ResLib.Icons8_32x32.Icons8_Security_shield.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Security_User_Shield = "Tripous.ResLib.Icons8_32x32.Icons8_Security_user_shield.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Security_Warning_Shield = "Tripous.ResLib.Icons8_32x32.Icons8_Security_warning_shield.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Security_Web_Shield = "Tripous.ResLib.Icons8_32x32.Icons8_Security_web_shield.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Sewing_Bobbin = "Tripous.ResLib.Icons8_32x32.Icons8_Sewing_bobbin.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Sewing_Button = "Tripous.ResLib.Icons8_32x32.Icons8_Sewing_button.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Sewing_Needle = "Tripous.ResLib.Icons8_32x32.Icons8_Sewing_needle.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Sewing_Pin_Cushion = "Tripous.ResLib.Icons8_32x32.Icons8_Sewing_pin_cushion.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Sewing_Tape_Measure = "Tripous.ResLib.Icons8_32x32.Icons8_Sewing_tape_measure.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Sewing_Thimble = "Tripous.ResLib.Icons8_32x32.Icons8_Sewing_thimble.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Shoe_Polish = "Tripous.ResLib.Icons8_32x32.Icons8_shoe_polish.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Shoe_Polish_Beeswax = "Tripous.ResLib.Icons8_32x32.Icons8_Shoe_Polish_beeswax.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Shoe_Polish_Beeswax2 = "Tripous.ResLib.Icons8_32x32.Icons8_Shoe_Polish_beeswax2.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Shoe_Polish_Polish_Cloth = "Tripous.ResLib.Icons8_32x32.Icons8_Shoe_Polish_polish_cloth.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Shoe_Polish_Shoe_Brush1 = "Tripous.ResLib.Icons8_32x32.Icons8_Shoe_Polish_shoe_brush1.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Shoe_Polish_Shoe_Brush2 = "Tripous.ResLib.Icons8_32x32.Icons8_Shoe_Polish_shoe_brush2.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Social_Network_Bebo = "Tripous.ResLib.Icons8_32x32.Icons8_Social_Network_bebo.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Social_Network_Facebook = "Tripous.ResLib.Icons8_32x32.Icons8_Social_Network_facebook.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Social_Network_Foursquare = "Tripous.ResLib.Icons8_32x32.Icons8_Social_Network_foursquare.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Social_Network_Google_Plus = "Tripous.ResLib.Icons8_32x32.Icons8_Social_Network_google_plus.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Social_Network_Instagram = "Tripous.ResLib.Icons8_32x32.Icons8_Social_Network_instagram.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Social_Network_Linkedin = "Tripous.ResLib.Icons8_32x32.Icons8_Social_Network_linkedin.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Social_Network_Myspace = "Tripous.ResLib.Icons8_32x32.Icons8_Social_Network_myspace.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Social_Network_Twitter = "Tripous.ResLib.Icons8_32x32.Icons8_Social_Network_twitter.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Social_Network_Vk_Com = "Tripous.ResLib.Icons8_32x32.Icons8_Social_Network_vk.com.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Social_Network_Vkontakte = "Tripous.ResLib.Icons8_32x32.Icons8_Social_Network_vkontakte.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Social_Network_Xing = "Tripous.ResLib.Icons8_32x32.Icons8_Social_Network_xing.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Sport_Back = "Tripous.ResLib.Icons8_32x32.Icons8_Sport_back.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Sport_Barbell = "Tripous.ResLib.Icons8_32x32.Icons8_Sport_barbell.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Sport_Base_Jumping = "Tripous.ResLib.Icons8_32x32.Icons8_Sport_base_jumping.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Sport_Basketball = "Tripous.ResLib.Icons8_32x32.Icons8_Sport_basketball.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Sport_Canopy = "Tripous.ResLib.Icons8_32x32.Icons8_Sport_canopy.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Sport_Championship_Belt = "Tripous.ResLib.Icons8_32x32.Icons8_Sport_championship_belt.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Sport_Chest = "Tripous.ResLib.Icons8_32x32.Icons8_Sport_chest.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Sport_Climbing = "Tripous.ResLib.Icons8_32x32.Icons8_Sport_climbing.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Sport_Drop_Zone = "Tripous.ResLib.Icons8_32x32.Icons8_Sport_drop_zone.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Sport_Dumbbell = "Tripous.ResLib.Icons8_32x32.Icons8_Sport_dumbbell.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Sport_Finish_Flag = "Tripous.ResLib.Icons8_32x32.Icons8_Sport_finish_flag.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Sport_Fishing = "Tripous.ResLib.Icons8_32x32.Icons8_Sport_fishing.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Sport_Football = "Tripous.ResLib.Icons8_32x32.Icons8_Sport_football.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Sport_Football2 = "Tripous.ResLib.Icons8_32x32.Icons8_Sport_football2.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Sport_Frisbee = "Tripous.ResLib.Icons8_32x32.Icons8_Sport_frisbee.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Sport_Hand_Biceps = "Tripous.ResLib.Icons8_32x32.Icons8_Sport_hand_biceps.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Sport_Jump_Rope = "Tripous.ResLib.Icons8_32x32.Icons8_Sport_jump_rope.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Sport_Leg = "Tripous.ResLib.Icons8_32x32.Icons8_Sport_leg.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Sport_Medal2 = "Tripous.ResLib.Icons8_32x32.Icons8_Sport_medal2.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Sport_Mountain_Biking = "Tripous.ResLib.Icons8_32x32.Icons8_Sport_mountain_biking.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Sport_Neck = "Tripous.ResLib.Icons8_32x32.Icons8_Sport_neck.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Sport_Padding = "Tripous.ResLib.Icons8_32x32.Icons8_Sport_padding.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Sport_Ping_Pong = "Tripous.ResLib.Icons8_32x32.Icons8_Sport_ping_pong.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Sport_Prelum = "Tripous.ResLib.Icons8_32x32.Icons8_Sport_prelum.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Sport_Regular_Biking = "Tripous.ResLib.Icons8_32x32.Icons8_Sport_regular_biking.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Sport_Rugby = "Tripous.ResLib.Icons8_32x32.Icons8_Sport_rugby.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Sport_Running = "Tripous.ResLib.Icons8_32x32.Icons8_Sport_running.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Sport_Shoulders = "Tripous.ResLib.Icons8_32x32.Icons8_Sport_shoulders.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Sport_Skiing = "Tripous.ResLib.Icons8_32x32.Icons8_Sport_skiing.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Sport_Skydiving = "Tripous.ResLib.Icons8_32x32.Icons8_Sport_skydiving.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Sport_Skydiving_Gear = "Tripous.ResLib.Icons8_32x32.Icons8_Sport_skydiving_gear.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Sport_Stopwatch = "Tripous.ResLib.Icons8_32x32.Icons8_Sport_stopwatch.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Sport_Swimming = "Tripous.ResLib.Icons8_32x32.Icons8_Sport_swimming.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Sport_Tennis = "Tripous.ResLib.Icons8_32x32.Icons8_Sport_tennis.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Sport_Time_Trial_Biking = "Tripous.ResLib.Icons8_32x32.Icons8_Sport_time_trial_biking.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Sport_Torso = "Tripous.ResLib.Icons8_32x32.Icons8_Sport_torso.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Sport_Trekking = "Tripous.ResLib.Icons8_32x32.Icons8_Sport_trekking.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Sport_Trophy = "Tripous.ResLib.Icons8_32x32.Icons8_Sport_trophy.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Sport_Weightlift = "Tripous.ResLib.Icons8_32x32.Icons8_Sport_weightlift.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Sport_Wheel = "Tripous.ResLib.Icons8_32x32.Icons8_Sport_wheel.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Sport_Yoga = "Tripous.ResLib.Icons8_32x32.Icons8_Sport_yoga.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Subculture_Bacon = "Tripous.ResLib.Icons8_32x32.Icons8_Subculture_bacon.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Subculture_Beer = "Tripous.ResLib.Icons8_32x32.Icons8_Subculture_beer.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Subculture_Bicycle = "Tripous.ResLib.Icons8_32x32.Icons8_Subculture_bicycle.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Subculture_Coffee = "Tripous.ResLib.Icons8_32x32.Icons8_Subculture_coffee.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Subculture_Glasses = "Tripous.ResLib.Icons8_32x32.Icons8_Subculture_glasses.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Subculture_Hand_Poking_Tool = "Tripous.ResLib.Icons8_32x32.Icons8_Subculture_hand_poking_tool.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Subculture_Mustache = "Tripous.ResLib.Icons8_32x32.Icons8_Subculture_mustache.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Subculture_Tattoo = "Tripous.ResLib.Icons8_32x32.Icons8_Subculture_tattoo.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Subculture_Tattoo_Machine = "Tripous.ResLib.Icons8_32x32.Icons8_Subculture_tattoo_machine.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string System_Add_Property = "Tripous.ResLib.Icons8_32x32.Icons8_System_add_property.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string System_Bottom_Toolbar = "Tripous.ResLib.Icons8_32x32.Icons8_System_bottom_toolbar.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string System_Dashboard = "Tripous.ResLib.Icons8_32x32.Icons8_System_dashboard.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string System_Delete = "Tripous.ResLib.Icons8_32x32.Icons8_System_delete.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string System_Delete_Property = "Tripous.ResLib.Icons8_32x32.Icons8_System_delete_property.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string System_Edit_Property = "Tripous.ResLib.Icons8_32x32.Icons8_System_edit_property.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string System_Error = "Tripous.ResLib.Icons8_32x32.Icons8_System_error.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string System_Help = "Tripous.ResLib.Icons8_32x32.Icons8_System_help.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string System_Left_Sidebar = "Tripous.ResLib.Icons8_32x32.Icons8_System_Left_Sidebar.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string System_Login = "Tripous.ResLib.Icons8_32x32.Icons8_System_login.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string System_Logout = "Tripous.ResLib.Icons8_32x32.Icons8_System_logout.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string System_Pin = "Tripous.ResLib.Icons8_32x32.Icons8_System_pin.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string System_Pin2 = "Tripous.ResLib.Icons8_32x32.Icons8_System_pin2.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string System_Private = "Tripous.ResLib.Icons8_32x32.Icons8_System_private.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string System_Public = "Tripous.ResLib.Icons8_32x32.Icons8_System_public.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string System_Save = "Tripous.ResLib.Icons8_32x32.Icons8_System_save.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string System_Save_As = "Tripous.ResLib.Icons8_32x32.Icons8_System_save_as.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string System_Settings = "Tripous.ResLib.Icons8_32x32.Icons8_System_settings.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string System_Show_Property = "Tripous.ResLib.Icons8_32x32.Icons8_System_show_property.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string System_Top_Toolbar = "Tripous.ResLib.Icons8_32x32.Icons8_System_top_toolbar.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string System_Unpin = "Tripous.ResLib.Icons8_32x32.Icons8_System_unpin.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string System_Unpin2 = "Tripous.ResLib.Icons8_32x32.Icons8_System_unpin2.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Tale_Genie = "Tripous.ResLib.Icons8_32x32.Icons8_Tale_genie.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Tale_Lamp = "Tripous.ResLib.Icons8_32x32.Icons8_Tale_lamp.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Tale_Lamp_Genie = "Tripous.ResLib.Icons8_32x32.Icons8_Tale_lamp_genie.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Textedit_Attach = "Tripous.ResLib.Icons8_32x32.Icons8_TextEdit_attach.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Textedit_Bg_Color = "Tripous.ResLib.Icons8_32x32.Icons8_TextEdit_bg_color.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Textedit_Bold = "Tripous.ResLib.Icons8_32x32.Icons8_TextEdit_bold.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Textedit_Border_Color = "Tripous.ResLib.Icons8_32x32.Icons8_TextEdit_border_color.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Textedit_Center = "Tripous.ResLib.Icons8_32x32.Icons8_TextEdit_center.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Textedit_Cllipboard = "Tripous.ResLib.Icons8_32x32.Icons8_TextEdit_cllipboard.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Textedit_Compare = "Tripous.ResLib.Icons8_32x32.Icons8_TextEdit_compare.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Textedit_Copy = "Tripous.ResLib.Icons8_32x32.Icons8_TextEdit_copy.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Textedit_Cut = "Tripous.ResLib.Icons8_32x32.Icons8_TextEdit_cut.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Textedit_Decrease_Font = "Tripous.ResLib.Icons8_32x32.Icons8_TextEdit_decrease_font.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Textedit_Delete = "Tripous.ResLib.Icons8_32x32.Icons8_TextEdit_delete.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Textedit_Edit = "Tripous.ResLib.Icons8_32x32.Icons8_TextEdit_edit.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Textedit_Erase = "Tripous.ResLib.Icons8_32x32.Icons8_TextEdit_erase.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Textedit_Generic_Text = "Tripous.ResLib.Icons8_32x32.Icons8_TextEdit_generic_text.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Textedit_Increase_Font = "Tripous.ResLib.Icons8_32x32.Icons8_TextEdit_increase_font.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Textedit_Italic = "Tripous.ResLib.Icons8_32x32.Icons8_TextEdit_italic.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Textedit_Justify = "Tripous.ResLib.Icons8_32x32.Icons8_TextEdit_justify.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Textedit_Left = "Tripous.ResLib.Icons8_32x32.Icons8_TextEdit_left.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Textedit_Rename = "Tripous.ResLib.Icons8_32x32.Icons8_TextEdit_rename.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Textedit_Right = "Tripous.ResLib.Icons8_32x32.Icons8_TextEdit_right.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Theater_Audience = "Tripous.ResLib.Icons8_32x32.Icons8_Theater_audience.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Theater_Bunch_Flowers = "Tripous.ResLib.Icons8_32x32.Icons8_Theater_bunch_flowers.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Theater_Comedy_Mask = "Tripous.ResLib.Icons8_32x32.Icons8_Theater_comedy_mask.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Theater_Lyre = "Tripous.ResLib.Icons8_32x32.Icons8_Theater_lyre.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Theater_Opera_Glasses = "Tripous.ResLib.Icons8_32x32.Icons8_Theater_opera_glasses.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Theater_Theatre_Masks = "Tripous.ResLib.Icons8_32x32.Icons8_Theater_theatre_masks.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Theater_Tragedy_Mask = "Tripous.ResLib.Icons8_32x32.Icons8_Theater_tragedy_mask.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Touristic_Beach = "Tripous.ResLib.Icons8_32x32.Icons8_Touristic_beach.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Touristic_Cave = "Tripous.ResLib.Icons8_32x32.Icons8_Touristic_cave.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Touristic_Museum = "Tripous.ResLib.Icons8_32x32.Icons8_Touristic_museum.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Transport_Airplane_Landing = "Tripous.ResLib.Icons8_32x32.Icons8_Transport_airplane_landing.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Transport_Airplane_Takeoff = "Tripous.ResLib.Icons8_32x32.Icons8_Transport_airplane_takeoff.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Transport_Bicycle = "Tripous.ResLib.Icons8_32x32.Icons8_Transport_bicycle.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Transport_Bus = "Tripous.ResLib.Icons8_32x32.Icons8_Transport_bus.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Transport_Car = "Tripous.ResLib.Icons8_32x32.Icons8_Transport_car.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Transport_Car_Battery = "Tripous.ResLib.Icons8_32x32.Icons8_Transport_car_battery.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Transport_Cargo_Ship = "Tripous.ResLib.Icons8_32x32.Icons8_Transport_cargo_ship.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Transport_Cruise_Ship = "Tripous.ResLib.Icons8_32x32.Icons8_Transport_cruise_ship.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Transport_Dinghy = "Tripous.ResLib.Icons8_32x32.Icons8_Transport_dinghy.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Transport_Engine = "Tripous.ResLib.Icons8_32x32.Icons8_Transport_engine.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Transport_Ferry = "Tripous.ResLib.Icons8_32x32.Icons8_Transport_ferry.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Transport_Helicopter = "Tripous.ResLib.Icons8_32x32.Icons8_Transport_helicopter.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Transport_Motorcycle = "Tripous.ResLib.Icons8_32x32.Icons8_Transport_motorcycle.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Transport_Pickup = "Tripous.ResLib.Icons8_32x32.Icons8_Transport_pickup.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Transport_Piston = "Tripous.ResLib.Icons8_32x32.Icons8_Transport_piston.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Transport_Railroad_Car = "Tripous.ResLib.Icons8_32x32.Icons8_Transport_railroad_car.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Transport_Sail_Boat = "Tripous.ResLib.Icons8_32x32.Icons8_Transport_sail_boat.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Transport_Scooter = "Tripous.ResLib.Icons8_32x32.Icons8_Transport_scooter.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Transport_Spark_Plug = "Tripous.ResLib.Icons8_32x32.Icons8_Transport_spark_plug.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Transport_Speedometer = "Tripous.ResLib.Icons8_32x32.Icons8_Transport_speedometer.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Transport_Steering_Wheel = "Tripous.ResLib.Icons8_32x32.Icons8_Transport_steering_wheel.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Transport_Taxi = "Tripous.ResLib.Icons8_32x32.Icons8_Transport_taxi.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Transport_Tire = "Tripous.ResLib.Icons8_32x32.Icons8_Transport_tire.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Transport_Track = "Tripous.ResLib.Icons8_32x32.Icons8_Transport_track.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Transport_Tractor = "Tripous.ResLib.Icons8_32x32.Icons8_Transport_tractor.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Transport_Trailer = "Tripous.ResLib.Icons8_32x32.Icons8_Transport_trailer.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Transport_Train = "Tripous.ResLib.Icons8_32x32.Icons8_Transport_train.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Transport_Tram = "Tripous.ResLib.Icons8_32x32.Icons8_Transport_tram.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Transport_Tram2 = "Tripous.ResLib.Icons8_32x32.Icons8_Transport_tram2.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Transport_Trolleybus = "Tripous.ResLib.Icons8_32x32.Icons8_Transport_trolleybus.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Transport_Yacht = "Tripous.ResLib.Icons8_32x32.Icons8_Transport_yacht.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Update_Available_Updates = "Tripous.ResLib.Icons8_32x32.Icons8_Update_available_updates.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Update_Downloading_Updates = "Tripous.ResLib.Icons8_32x32.Icons8_Update_downloading_updates.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Update_Installing_Updates = "Tripous.ResLib.Icons8_32x32.Icons8_Update_installing_updates.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Usb_Connected = "Tripous.ResLib.Icons8_32x32.Icons8_usb_connected.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Usb_Disconnected = "Tripous.ResLib.Icons8_32x32.Icons8_usb_disconnected.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Usb_Off = "Tripous.ResLib.Icons8_32x32.Icons8_usb_off.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Usb_On = "Tripous.ResLib.Icons8_32x32.Icons8_usb_on.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string User = "Tripous.ResLib.Icons8_32x32.Icons8_user.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string User_Add_User = "Tripous.ResLib.Icons8_32x32.Icons8_User_add_user.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string User_Administrator = "Tripous.ResLib.Icons8_32x32.Icons8_User_administrator.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string User_Administrator2 = "Tripous.ResLib.Icons8_32x32.Icons8_User_administrator2.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string User_Change_User = "Tripous.ResLib.Icons8_32x32.Icons8_User_change_user.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string User_Checked_User = "Tripous.ResLib.Icons8_32x32.Icons8_User_checked_user.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string User_Collaborator = "Tripous.ResLib.Icons8_32x32.Icons8_User_collaborator.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string User_Conference = "Tripous.ResLib.Icons8_32x32.Icons8_User_conference.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string User_Cook = "Tripous.ResLib.Icons8_32x32.Icons8_User_cook.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string User_Doctor = "Tripous.ResLib.Icons8_32x32.Icons8_User_doctor.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string User_Edit_User = "Tripous.ResLib.Icons8_32x32.Icons8_User_edit_user.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string User_Fireman = "Tripous.ResLib.Icons8_32x32.Icons8_User_fireman.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string User_Group = "Tripous.ResLib.Icons8_32x32.Icons8_User_group.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string User_Guest = "Tripous.ResLib.Icons8_32x32.Icons8_User_guest.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string User_Moderator = "Tripous.ResLib.Icons8_32x32.Icons8_User_moderator.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string User_Nurse = "Tripous.ResLib.Icons8_32x32.Icons8_User_nurse.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string User_Police = "Tripous.ResLib.Icons8_32x32.Icons8_User_police.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string User_Remove_User = "Tripous.ResLib.Icons8_32x32.Icons8_User_remove_user.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string User_Reviewer = "Tripous.ResLib.Icons8_32x32.Icons8_User_reviewer.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string User_Student = "Tripous.ResLib.Icons8_32x32.Icons8_User_student.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string User_Talk = "Tripous.ResLib.Icons8_32x32.Icons8_User_talk.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string User_Worker = "Tripous.ResLib.Icons8_32x32.Icons8_User_worker.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string User_Workers = "Tripous.ResLib.Icons8_32x32.Icons8_User_workers.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Video_Game_Console_Ps = "Tripous.ResLib.Icons8_32x32.Icons8_Video_Game_Console_ps.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Video_Game_Console_Wii = "Tripous.ResLib.Icons8_32x32.Icons8_Video_Game_Console_wii.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Video_Game_Console_Xbox = "Tripous.ResLib.Icons8_32x32.Icons8_Video_Game_Console_xbox.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Volume_Control_High = "Tripous.ResLib.Icons8_32x32.Icons8_Volume_Control_High.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Volume_Control_Listen = "Tripous.ResLib.Icons8_32x32.Icons8_Volume_Control_listen.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Volume_Control_Low = "Tripous.ResLib.Icons8_32x32.Icons8_Volume_Control_Low.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Volume_Control_Mute = "Tripous.ResLib.Icons8_32x32.Icons8_Volume_Control_mute.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Volume_Control_Not_Listen = "Tripous.ResLib.Icons8_32x32.Icons8_Volume_Control_not_listen.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Weather_Chance_Of_Storm = "Tripous.ResLib.Icons8_32x32.Icons8_Weather_chance_of_storm.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Weather_Cloud_Lighting = "Tripous.ResLib.Icons8_32x32.Icons8_Weather_cloud_lighting.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Weather_Clouds = "Tripous.ResLib.Icons8_32x32.Icons8_Weather_clouds.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Weather_Dust = "Tripous.ResLib.Icons8_32x32.Icons8_Weather_dust.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Weather_Fog_Day = "Tripous.ResLib.Icons8_32x32.Icons8_Weather_fog_day.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Weather_Fog_Night = "Tripous.ResLib.Icons8_32x32.Icons8_Weather_fog_night.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Weather_Hail = "Tripous.ResLib.Icons8_32x32.Icons8_Weather_hail.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Weather_Icy = "Tripous.ResLib.Icons8_32x32.Icons8_Weather_icy.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Weather_Little_Rain = "Tripous.ResLib.Icons8_32x32.Icons8_Weather_little_rain.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Weather_Little_Snow = "Tripous.ResLib.Icons8_32x32.Icons8_Weather_little_snow.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Weather_Moon = "Tripous.ResLib.Icons8_32x32.Icons8_Weather_moon.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Weather_Partly_Cloudy_Day = "Tripous.ResLib.Icons8_32x32.Icons8_Weather_partly_cloudy_day.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Weather_Partly_Cloudy_Night = "Tripous.ResLib.Icons8_32x32.Icons8_Weather_partly_cloudy_night.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Weather_Rain = "Tripous.ResLib.Icons8_32x32.Icons8_Weather_rain.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Weather_Sleet = "Tripous.ResLib.Icons8_32x32.Icons8_Weather_sleet.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Weather_Snow = "Tripous.ResLib.Icons8_32x32.Icons8_Weather_snow.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Weather_Snow_Storm = "Tripous.ResLib.Icons8_32x32.Icons8_Weather_snow_storm.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Weather_Storm = "Tripous.ResLib.Icons8_32x32.Icons8_Weather_storm.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Weather_Sun = "Tripous.ResLib.Icons8_32x32.Icons8_Weather_sun.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Weather_Thermometer = "Tripous.ResLib.Icons8_32x32.Icons8_Weather_thermometer.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Web_Css = "Tripous.ResLib.Icons8_32x32.Icons8_Web_css.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Web_Html = "Tripous.ResLib.Icons8_32x32.Icons8_Web_html.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Web_Js = "Tripous.ResLib.Icons8_32x32.Icons8_Web_js.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Web_Php = "Tripous.ResLib.Icons8_32x32.Icons8_Web_php.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Website_Section_About = "Tripous.ResLib.Icons8_32x32.Icons8_Website_Section_about.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Website_Section_Contacts = "Tripous.ResLib.Icons8_32x32.Icons8_Website_Section_contacts.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Website_Section_Contacts2 = "Tripous.ResLib.Icons8_32x32.Icons8_Website_Section_contacts2.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Website_Section_News = "Tripous.ResLib.Icons8_32x32.Icons8_Website_Section_news.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Website_Section_Product = "Tripous.ResLib.Icons8_32x32.Icons8_Website_Section_product.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Website_Section_Services = "Tripous.ResLib.Icons8_32x32.Icons8_Website_Section_services.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Website_Section_Solutions = "Tripous.ResLib.Icons8_32x32.Icons8_Website_Section_solutions.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Website_Section_Support = "Tripous.ResLib.Icons8_32x32.Icons8_Website_Section_support.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Wedding_Cake = "Tripous.ResLib.Icons8_32x32.Icons8_wedding_cake.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Wedding_Champagne = "Tripous.ResLib.Icons8_32x32.Icons8_Wedding_champagne.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Wedding_Day = "Tripous.ResLib.Icons8_32x32.Icons8_wedding_day.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Wedding_Photo = "Tripous.ResLib.Icons8_32x32.Icons8_wedding_photo.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Wedding_Ring = "Tripous.ResLib.Icons8_32x32.Icons8_Wedding_ring.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Wedding_Rings = "Tripous.ResLib.Icons8_32x32.Icons8_wedding_rings.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Wedding_Two_Hearts = "Tripous.ResLib.Icons8_32x32.Icons8_Wedding_two_hearts.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Window_Close = "Tripous.ResLib.Icons8_32x32.Icons8_Window_Close.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Window_Maximize = "Tripous.ResLib.Icons8_32x32.Icons8_Window_Maximize.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Window_Minimize = "Tripous.ResLib.Icons8_32x32.Icons8_Window_Minimize.png";
            /// <summary>
            /// Constant
            /// </summary>
            public const string Window_Restore = "Tripous.ResLib.Icons8_32x32.Icons8_Window_Restore.png";
            #endregion

            #region Names Array

            /// <summary>
            /// Array
            /// </summary>
            private static Dictionary<string, string> Names = new Dictionary<string, string> {
            {"Accommodation_Apartment", "Tripous.ResLib.Icons8_32x32.Icons8_Accommodation_apartment.png"},
            {"Accommodation_Barn", "Tripous.ResLib.Icons8_32x32.Icons8_Accommodation_barn.png"},
            {"Accommodation_Bungalow", "Tripous.ResLib.Icons8_32x32.Icons8_Accommodation_bungalow.png"},
            {"Accommodation_Cottage", "Tripous.ResLib.Icons8_32x32.Icons8_Accommodation_cottage.png"},
            {"Accommodation_Hot_Tube", "Tripous.ResLib.Icons8_32x32.Icons8_Accommodation_hot_tube.png"},
            {"Accommodation_Jacuzzi", "Tripous.ResLib.Icons8_32x32.Icons8_Accommodation_jacuzzi.png"},
            {"Accommodation_Log_Cabin", "Tripous.ResLib.Icons8_32x32.Icons8_Accommodation_log_cabin.png"},
            {"Accommodation_Mobile_Home", "Tripous.ResLib.Icons8_32x32.Icons8_Accommodation_mobile_home.png"},
            {"Accounting_Bill", "Tripous.ResLib.Icons8_32x32.Icons8_Accounting_bill.png"},
            {"Accounting_Check", "Tripous.ResLib.Icons8_32x32.Icons8_Accounting_check.png"},
            {"Accounting_Invoice", "Tripous.ResLib.Icons8_32x32.Icons8_Accounting_invoice.png"},
            {"Accounting_Order", "Tripous.ResLib.Icons8_32x32.Icons8_Accounting_Order.png"},
            {"Add_Delete_Link", "Tripous.ResLib.Icons8_32x32.Icons8_Add_delete_link.png"},
            {"Add_File", "Tripous.ResLib.Icons8_32x32.Icons8_add_file.png"},
            {"Add_Folder", "Tripous.ResLib.Icons8_32x32.Icons8_add_folder.png"},
            {"Add_Link", "Tripous.ResLib.Icons8_32x32.Icons8_add_link.png"},
            {"Add_List", "Tripous.ResLib.Icons8_32x32.Icons8_add_list.png"},
            {"Adobe_Ai", "Tripous.ResLib.Icons8_32x32.Icons8_Adobe_ai.png"},
            {"Adobe_Br", "Tripous.ResLib.Icons8_32x32.Icons8_Adobe_br.png"},
            {"Adobe_Dw", "Tripous.ResLib.Icons8_32x32.Icons8_Adobe_dw.png"},
            {"Adobe_Fl", "Tripous.ResLib.Icons8_32x32.Icons8_Adobe_fl.png"},
            {"Adobe_Fw", "Tripous.ResLib.Icons8_32x32.Icons8_Adobe_fw.png"},
            {"Adobe_Id", "Tripous.ResLib.Icons8_32x32.Icons8_Adobe_id.png"},
            {"Adobe_Ps", "Tripous.ResLib.Icons8_32x32.Icons8_Adobe_ps.png"},
            {"Alien_Grey", "Tripous.ResLib.Icons8_32x32.Icons8_Alien_grey.png"},
            {"Alien_Martian", "Tripous.ResLib.Icons8_32x32.Icons8_Alien_martian.png"},
            {"Alien_Predator", "Tripous.ResLib.Icons8_32x32.Icons8_Alien_predator.png"},
            {"Alphabet_A", "Tripous.ResLib.Icons8_32x32.Icons8_Alphabet_A.png"},
            {"Alphabet_B", "Tripous.ResLib.Icons8_32x32.Icons8_Alphabet_B.png"},
            {"Alphabet_C", "Tripous.ResLib.Icons8_32x32.Icons8_Alphabet_C.png"},
            {"Alphabet_D", "Tripous.ResLib.Icons8_32x32.Icons8_Alphabet_D.png"},
            {"Alphabet_E", "Tripous.ResLib.Icons8_32x32.Icons8_Alphabet_E.png"},
            {"Alphabet_F", "Tripous.ResLib.Icons8_32x32.Icons8_Alphabet_F.png"},
            {"Alphabet_G", "Tripous.ResLib.Icons8_32x32.Icons8_Alphabet_G.png"},
            {"Alphabet_H", "Tripous.ResLib.Icons8_32x32.Icons8_Alphabet_H.png"},
            {"Alphabet_I", "Tripous.ResLib.Icons8_32x32.Icons8_Alphabet_I.png"},
            {"Alphabet_J", "Tripous.ResLib.Icons8_32x32.Icons8_Alphabet_J.png"},
            {"Alphabet_K", "Tripous.ResLib.Icons8_32x32.Icons8_Alphabet_K.png"},
            {"Alphabet_L", "Tripous.ResLib.Icons8_32x32.Icons8_Alphabet_L.png"},
            {"Alphabet_M", "Tripous.ResLib.Icons8_32x32.Icons8_Alphabet_M.png"},
            {"Alphabet_N", "Tripous.ResLib.Icons8_32x32.Icons8_Alphabet_N.png"},
            {"Alphabet_O", "Tripous.ResLib.Icons8_32x32.Icons8_Alphabet_O.png"},
            {"Alphabet_P", "Tripous.ResLib.Icons8_32x32.Icons8_Alphabet_P.png"},
            {"Alphabet_Q", "Tripous.ResLib.Icons8_32x32.Icons8_Alphabet_Q.png"},
            {"Alphabet_R", "Tripous.ResLib.Icons8_32x32.Icons8_Alphabet_R.png"},
            {"Alphabet_S", "Tripous.ResLib.Icons8_32x32.Icons8_Alphabet_S.png"},
            {"Alphabet_T", "Tripous.ResLib.Icons8_32x32.Icons8_Alphabet_T.png"},
            {"Alphabet_U", "Tripous.ResLib.Icons8_32x32.Icons8_Alphabet_U.png"},
            {"Alphabet_V", "Tripous.ResLib.Icons8_32x32.Icons8_Alphabet_V.png"},
            {"Alphabet_W", "Tripous.ResLib.Icons8_32x32.Icons8_Alphabet_W.png"},
            {"Alphabet_X", "Tripous.ResLib.Icons8_32x32.Icons8_Alphabet_X.png"},
            {"Alphabet_Y", "Tripous.ResLib.Icons8_32x32.Icons8_Alphabet_Y.png"},
            {"Alphabet_Z", "Tripous.ResLib.Icons8_32x32.Icons8_Alphabet_Z.png"},
            {"Animal_Chiken", "Tripous.ResLib.Icons8_32x32.Icons8_Animal_chiken.png"},
            {"Animal_Cow", "Tripous.ResLib.Icons8_32x32.Icons8_Animal_cow.png"},
            {"Animal_Crab", "Tripous.ResLib.Icons8_32x32.Icons8_Animal_crab.png"},
            {"Animal_Duck", "Tripous.ResLib.Icons8_32x32.Icons8_Animal_duck.png"},
            {"Animal_Fish", "Tripous.ResLib.Icons8_32x32.Icons8_Animal_fish.png"},
            {"Animal_Pig", "Tripous.ResLib.Icons8_32x32.Icons8_Animal_pig.png"},
            {"Animal_Prawn", "Tripous.ResLib.Icons8_32x32.Icons8_Animal_prawn.png"},
            {"Animal_Sheep", "Tripous.ResLib.Icons8_32x32.Icons8_Animal_sheep.png"},
            {"Animal_Sheep_On_Bike", "Tripous.ResLib.Icons8_32x32.Icons8_Animal_sheep_on_bike.png"},
            {"Animal_Sheep2", "Tripous.ResLib.Icons8_32x32.Icons8_Animal_sheep2.png"},
            {"Appliance_Armchair", "Tripous.ResLib.Icons8_32x32.Icons8_Appliance_armchair.png"},
            {"Appliance_Bed", "Tripous.ResLib.Icons8_32x32.Icons8_Appliance_bed.png"},
            {"Appliance_Channel_Mosaic", "Tripous.ResLib.Icons8_32x32.Icons8_Appliance_channel_mosaic.png"},
            {"Appliance_Coffe_Maker", "Tripous.ResLib.Icons8_32x32.Icons8_Appliance_coffe_maker.png"},
            {"Appliance_Commode", "Tripous.ResLib.Icons8_32x32.Icons8_Appliance_commode.png"},
            {"Appliance_Electric_Teapot", "Tripous.ResLib.Icons8_32x32.Icons8_Appliance_electric_teapot.png"},
            {"Appliance_Fan", "Tripous.ResLib.Icons8_32x32.Icons8_Appliance_fan.png"},
            {"Appliance_Hdtv", "Tripous.ResLib.Icons8_32x32.Icons8_Appliance_hdtv.png"},
            {"Appliance_Iron", "Tripous.ResLib.Icons8_32x32.Icons8_Appliance_iron.png"},
            {"Appliance_Lamp", "Tripous.ResLib.Icons8_32x32.Icons8_Appliance_lamp.png"},
            {"Appliance_Mixer", "Tripous.ResLib.Icons8_32x32.Icons8_Appliance_mixer.png"},
            {"Appliance_Sdtv", "Tripous.ResLib.Icons8_32x32.Icons8_Appliance_sdtv.png"},
            {"Appliance_Sofa", "Tripous.ResLib.Icons8_32x32.Icons8_Appliance_sofa.png"},
            {"Appliance_Table", "Tripous.ResLib.Icons8_32x32.Icons8_Appliance_table.png"},
            {"Appliance_Tabletop_Radio", "Tripous.ResLib.Icons8_32x32.Icons8_Appliance_tabletop_radio.png"},
            {"Appliance_Tv", "Tripous.ResLib.Icons8_32x32.Icons8_Appliance_tv.png"},
            {"Appliance_Wardrobe", "Tripous.ResLib.Icons8_32x32.Icons8_Appliance_wardrobe.png"},
            {"Appliance_Washing_Machine", "Tripous.ResLib.Icons8_32x32.Icons8_Appliance_washing_machine.png"},
            {"Appliance_Widescreen_Tv", "Tripous.ResLib.Icons8_32x32.Icons8_Appliance_widescreen_tv.png"},
            {"Arrow_Down", "Tripous.ResLib.Icons8_32x32.Icons8_Arrow_down.png"},
            {"Arrow_Down_Circular", "Tripous.ResLib.Icons8_32x32.Icons8_Arrow_down_circular.png"},
            {"Arrow_Left", "Tripous.ResLib.Icons8_32x32.Icons8_Arrow_left.png"},
            {"Arrow_Left_Circular", "Tripous.ResLib.Icons8_32x32.Icons8_Arrow_left_circular.png"},
            {"Arrow_Left_Round", "Tripous.ResLib.Icons8_32x32.Icons8_Arrow_left_round.png"},
            {"Arrow_Right", "Tripous.ResLib.Icons8_32x32.Icons8_Arrow_right.png"},
            {"Arrow_Right_Circular", "Tripous.ResLib.Icons8_32x32.Icons8_Arrow_right_circular.png"},
            {"Arrow_Right_Round", "Tripous.ResLib.Icons8_32x32.Icons8_Arrow_right_round.png"},
            {"Arrow_Up", "Tripous.ResLib.Icons8_32x32.Icons8_Arrow_up.png"},
            {"Arrow_Up_Circular", "Tripous.ResLib.Icons8_32x32.Icons8_Arrow_up_circular.png"},
            {"Baby", "Tripous.ResLib.Icons8_32x32.Icons8_baby.png"},
            {"Baby_Bib", "Tripous.ResLib.Icons8_32x32.Icons8_Baby_bib.png"},
            {"Baby_Bottle", "Tripous.ResLib.Icons8_32x32.Icons8_Baby_bottle.png"},
            {"Baby_Brick", "Tripous.ResLib.Icons8_32x32.Icons8_Baby_brick.png"},
            {"Baby_Crib", "Tripous.ResLib.Icons8_32x32.Icons8_Baby_crib.png"},
            {"Baby_Crying_Baby", "Tripous.ResLib.Icons8_32x32.Icons8_Baby_crying_baby.png"},
            {"Baby_Feet", "Tripous.ResLib.Icons8_32x32.Icons8_baby_feet.png"},
            {"Baby_Flying_Stork", "Tripous.ResLib.Icons8_32x32.Icons8_Baby_flying_stork.png"},
            {"Baby_Flying_Stork_With_Bundle", "Tripous.ResLib.Icons8_32x32.Icons8_Baby_flying_stork_with_bundle.png"},
            {"Baby_Nappy", "Tripous.ResLib.Icons8_32x32.Icons8_Baby_nappy.png"},
            {"Baby_Pacifier", "Tripous.ResLib.Icons8_32x32.Icons8_Baby_pacifier.png"},
            {"Baby_Powder", "Tripous.ResLib.Icons8_32x32.Icons8_Baby_powder.png"},
            {"Baby_Rattle", "Tripous.ResLib.Icons8_32x32.Icons8_Baby_rattle.png"},
            {"Baby_Romper", "Tripous.ResLib.Icons8_32x32.Icons8_Baby_romper.png"},
            {"Baby_Stork", "Tripous.ResLib.Icons8_32x32.Icons8_Baby_stork.png"},
            {"Baby_Stork_With_Bundle", "Tripous.ResLib.Icons8_32x32.Icons8_Baby_stork_with_bundle.png"},
            {"Baby_Stroller", "Tripous.ResLib.Icons8_32x32.Icons8_Baby_stroller.png"},
            {"Baby_Teddybear", "Tripous.ResLib.Icons8_32x32.Icons8_Baby_teddybear.png"},
            {"Baby_Tricycle", "Tripous.ResLib.Icons8_32x32.Icons8_Baby_tricycle.png"},
            {"Basic_Address_Book", "Tripous.ResLib.Icons8_32x32.Icons8_Basic_address_book.png"},
            {"Basic_Audio_File", "Tripous.ResLib.Icons8_32x32.Icons8_Basic_audio_file.png"},
            {"Basic_Bookmark", "Tripous.ResLib.Icons8_32x32.Icons8_Basic_bookmark.png"},
            {"Basic_Broken_Link", "Tripous.ResLib.Icons8_32x32.Icons8_Basic_broken_link.png"},
            {"Basic_Calculator", "Tripous.ResLib.Icons8_32x32.Icons8_Basic_calculator.png"},
            {"Basic_Calendar", "Tripous.ResLib.Icons8_32x32.Icons8_Basic_calendar.png"},
            {"Basic_Cancel", "Tripous.ResLib.Icons8_32x32.Icons8_Basic_cancel.png"},
            {"Basic_Checked_Checkbox", "Tripous.ResLib.Icons8_32x32.Icons8_Basic_checked_checkbox.png"},
            {"Basic_Checkmark", "Tripous.ResLib.Icons8_32x32.Icons8_Basic_checkmark.png"},
            {"Basic_Clock", "Tripous.ResLib.Icons8_32x32.Icons8_Basic_clock.png"},
            {"Basic_Cursor", "Tripous.ResLib.Icons8_32x32.Icons8_Basic_cursor.png"},
            {"Basic_Document", "Tripous.ResLib.Icons8_32x32.Icons8_Basic_document.png"},
            {"Basic_Download", "Tripous.ResLib.Icons8_32x32.Icons8_Basic_download.png"},
            {"Basic_Empty_Trash", "Tripous.ResLib.Icons8_32x32.Icons8_Basic_empty_trash.png"},
            {"Basic_File", "Tripous.ResLib.Icons8_32x32.Icons8_Basic_file.png"},
            {"Basic_Folder", "Tripous.ResLib.Icons8_32x32.Icons8_Basic_folder.png"},
            {"Basic_Frame", "Tripous.ResLib.Icons8_32x32.Icons8_Basic_frame.png"},
            {"Basic_Full_Trash", "Tripous.ResLib.Icons8_32x32.Icons8_Basic_full_trash.png"},
            {"Basic_Globe", "Tripous.ResLib.Icons8_32x32.Icons8_Basic_globe.png"},
            {"Basic_Hand_Cursor", "Tripous.ResLib.Icons8_32x32.Icons8_Basic_hand_cursor.png"},
            {"Basic_Home", "Tripous.ResLib.Icons8_32x32.Icons8_Basic_home.png"},
            {"Basic_Image_File", "Tripous.ResLib.Icons8_32x32.Icons8_Basic_image_file.png"},
            {"Basic_Info", "Tripous.ResLib.Icons8_32x32.Icons8_Basic_info.png"},
            {"Basic_Key", "Tripous.ResLib.Icons8_32x32.Icons8_Basic_key.png"},
            {"Basic_Like", "Tripous.ResLib.Icons8_32x32.Icons8_Basic_like.png"},
            {"Basic_Like_Outline", "Tripous.ResLib.Icons8_32x32.Icons8_Basic_like_outline.png"},
            {"Basic_Link", "Tripous.ResLib.Icons8_32x32.Icons8_Basic_link.png"},
            {"Basic_Lock", "Tripous.ResLib.Icons8_32x32.Icons8_Basic_lock.png"},
            {"Basic_Minus", "Tripous.ResLib.Icons8_32x32.Icons8_Basic_minus.png"},
            {"Basic_Music", "Tripous.ResLib.Icons8_32x32.Icons8_Basic_music.png"},
            {"Basic_Ok", "Tripous.ResLib.Icons8_32x32.Icons8_Basic_ok.png"},
            {"Basic_Picture", "Tripous.ResLib.Icons8_32x32.Icons8_Basic_picture.png"},
            {"Basic_Plus", "Tripous.ResLib.Icons8_32x32.Icons8_Basic_plus.png"},
            {"Basic_Print", "Tripous.ResLib.Icons8_32x32.Icons8_Basic_print.png"},
            {"Basic_Puzzle", "Tripous.ResLib.Icons8_32x32.Icons8_Basic_puzzle.png"},
            {"Basic_Rating", "Tripous.ResLib.Icons8_32x32.Icons8_Basic_rating.png"},
            {"Basic_Redo", "Tripous.ResLib.Icons8_32x32.Icons8_Basic_redo.png"},
            {"Basic_Refresh", "Tripous.ResLib.Icons8_32x32.Icons8_Basic_refresh.png"},
            {"Basic_Ruler", "Tripous.ResLib.Icons8_32x32.Icons8_Basic_ruler.png"},
            {"Basic_Search", "Tripous.ResLib.Icons8_32x32.Icons8_Basic_search.png"},
            {"Basic_Settings", "Tripous.ResLib.Icons8_32x32.Icons8_Basic_settings.png"},
            {"Basic_Settings2", "Tripous.ResLib.Icons8_32x32.Icons8_Basic_settings2.png"},
            {"Basic_Sinchronize", "Tripous.ResLib.Icons8_32x32.Icons8_Basic_sinchronize.png"},
            {"Basic_Unchecked_Checkbox", "Tripous.ResLib.Icons8_32x32.Icons8_Basic_unchecked_checkbox.png"},
            {"Basic_Undo", "Tripous.ResLib.Icons8_32x32.Icons8_Basic_undo.png"},
            {"Basic_Unlock", "Tripous.ResLib.Icons8_32x32.Icons8_Basic_unlock.png"},
            {"Basic_Upload", "Tripous.ResLib.Icons8_32x32.Icons8_Basic_upload.png"},
            {"Basic_Video_File", "Tripous.ResLib.Icons8_32x32.Icons8_Basic_video_file.png"},
            {"Battery_25_Percent", "Tripous.ResLib.Icons8_32x32.Icons8_Battery_25_percent.png"},
            {"Battery_50_Percent", "Tripous.ResLib.Icons8_32x32.Icons8_Battery_50_percent.png"},
            {"Battery_75_Percent", "Tripous.ResLib.Icons8_32x32.Icons8_Battery_75_percent.png"},
            {"Battery_Almost_Empty", "Tripous.ResLib.Icons8_32x32.Icons8_Battery_almost_empty.png"},
            {"Battery_Almost_Full", "Tripous.ResLib.Icons8_32x32.Icons8_Battery_almost_full.png"},
            {"Battery_Empty_Battery", "Tripous.ResLib.Icons8_32x32.Icons8_Battery_empty_battery.png"},
            {"Battery_Full", "Tripous.ResLib.Icons8_32x32.Icons8_Battery_Full.png"},
            {"Browser_Chrome", "Tripous.ResLib.Icons8_32x32.Icons8_Browser_chrome.png"},
            {"Browser_Firefox", "Tripous.ResLib.Icons8_32x32.Icons8_Browser_firefox.png"},
            {"Browser_Ie", "Tripous.ResLib.Icons8_32x32.Icons8_Browser_ie.png"},
            {"Browser_Netscape", "Tripous.ResLib.Icons8_32x32.Icons8_Browser_netscape.png"},
            {"Browser_Opera", "Tripous.ResLib.Icons8_32x32.Icons8_Browser_opera.png"},
            {"Browser_Safari", "Tripous.ResLib.Icons8_32x32.Icons8_Browser_safari.png"},
            {"Busines_Approval", "Tripous.ResLib.Icons8_32x32.Icons8_Busines_approval.png"},
            {"Busines_Assistant", "Tripous.ResLib.Icons8_32x32.Icons8_Busines_assistant.png"},
            {"Busines_Atm", "Tripous.ResLib.Icons8_32x32.Icons8_Busines_atm.png"},
            {"Busines_Briefcase", "Tripous.ResLib.Icons8_32x32.Icons8_Busines_briefcase.png"},
            {"Busines_Delivery", "Tripous.ResLib.Icons8_32x32.Icons8_Busines_delivery.png"},
            {"Busines_Diploma1", "Tripous.ResLib.Icons8_32x32.Icons8_Busines_diploma1.png"},
            {"Busines_Diploma2", "Tripous.ResLib.Icons8_32x32.Icons8_Busines_diploma2.png"},
            {"Busines_Graduation_Cap", "Tripous.ResLib.Icons8_32x32.Icons8_Busines_graduation_cap.png"},
            {"Busines_Money_Bag", "Tripous.ResLib.Icons8_32x32.Icons8_Busines_money_bag.png"},
            {"Busines_Organization", "Tripous.ResLib.Icons8_32x32.Icons8_Busines_organization.png"},
            {"Busines_Package", "Tripous.ResLib.Icons8_32x32.Icons8_Busines_package.png"},
            {"Busines_Parallel_Tasks", "Tripous.ResLib.Icons8_32x32.Icons8_Busines_parallel_tasks.png"},
            {"Busines_Reuse", "Tripous.ResLib.Icons8_32x32.Icons8_Busines_reuse.png"},
            {"Busines_Safe", "Tripous.ResLib.Icons8_32x32.Icons8_Busines_safe.png"},
            {"Busines_Sale", "Tripous.ResLib.Icons8_32x32.Icons8_Busines_sale.png"},
            {"Busines_Self_Service_Kiosk", "Tripous.ResLib.Icons8_32x32.Icons8_Busines_self_service_kiosk.png"},
            {"Busines_Serial_Tasks", "Tripous.ResLib.Icons8_32x32.Icons8_Busines_serial_tasks.png"},
            {"Busines_Shop", "Tripous.ResLib.Icons8_32x32.Icons8_Busines_shop.png"},
            {"Busines_Tree_Structure", "Tripous.ResLib.Icons8_32x32.Icons8_Busines_tree_structure.png"},
            {"Businessman", "Tripous.ResLib.Icons8_32x32.Icons8_businessman.png"},
            {"Businesswoman", "Tripous.ResLib.Icons8_32x32.Icons8_businesswoman.png"},
            {"Buzz_Activity_Feed", "Tripous.ResLib.Icons8_32x32.Icons8_Buzz_activity_feed.png"},
            {"Buzz_Appointment_Reminders", "Tripous.ResLib.Icons8_32x32.Icons8_Buzz_appointment_reminders.png"},
            {"Buzz_Categorize", "Tripous.ResLib.Icons8_32x32.Icons8_Buzz_categorize.png"},
            {"Buzz_Forward", "Tripous.ResLib.Icons8_32x32.Icons8_Buzz_forward.png"},
            {"Buzz_Gmail_Login", "Tripous.ResLib.Icons8_32x32.Icons8_Buzz_gmail_login.png"},
            {"Buzz_High_Importance", "Tripous.ResLib.Icons8_32x32.Icons8_Buzz_high_importance.png"},
            {"Buzz_Invisible", "Tripous.ResLib.Icons8_32x32.Icons8_Buzz_invisible.png"},
            {"Buzz_Low_Importance", "Tripous.ResLib.Icons8_32x32.Icons8_Buzz_low_importance.png"},
            {"Buzz_Message", "Tripous.ResLib.Icons8_32x32.Icons8_Buzz_message.png"},
            {"Buzz_Message_Outline", "Tripous.ResLib.Icons8_32x32.Icons8_Buzz_message_outline.png"},
            {"Buzz_Outline_Star", "Tripous.ResLib.Icons8_32x32.Icons8_Buzz_outline_star.png"},
            {"Buzz_Private", "Tripous.ResLib.Icons8_32x32.Icons8_Buzz_private.png"},
            {"Buzz_Read_Message", "Tripous.ResLib.Icons8_32x32.Icons8_Buzz_read_message.png"},
            {"Buzz_Recurring_Appointment", "Tripous.ResLib.Icons8_32x32.Icons8_Buzz_recurring_appointment.png"},
            {"Buzz_Reply", "Tripous.ResLib.Icons8_32x32.Icons8_Buzz_reply.png"},
            {"Buzz_Send_File", "Tripous.ResLib.Icons8_32x32.Icons8_Buzz_send_file.png"},
            {"Buzz_Speech_Bubble", "Tripous.ResLib.Icons8_32x32.Icons8_Buzz_speech_bubble.png"},
            {"Buzz_Star", "Tripous.ResLib.Icons8_32x32.Icons8_Buzz_star.png"},
            {"Buzz_Visible", "Tripous.ResLib.Icons8_32x32.Icons8_Buzz_visible.png"},
            {"Camping_Gaiters", "Tripous.ResLib.Icons8_32x32.Icons8_Camping_gaiters.png"},
            {"Camping_Hex_Burner", "Tripous.ResLib.Icons8_32x32.Icons8_Camping_hex_burner.png"},
            {"Camping_Matches", "Tripous.ResLib.Icons8_32x32.Icons8_Camping_matches.png"},
            {"Camping_Mess_Tin", "Tripous.ResLib.Icons8_32x32.Icons8_Camping_mess_tin.png"},
            {"Camping_Sleepin_Mat", "Tripous.ResLib.Icons8_32x32.Icons8_Camping_sleepin_mat.png"},
            {"Camping_Sleeping_Bag", "Tripous.ResLib.Icons8_32x32.Icons8_Camping_sleeping_bag.png"},
            {"Camping_Survival_Bag", "Tripous.ResLib.Icons8_32x32.Icons8_Camping_survival_bag.png"},
            {"Camping_Trangia_Stove", "Tripous.ResLib.Icons8_32x32.Icons8_Camping_trangia_stove.png"},
            {"Camping_Water_Bottle", "Tripous.ResLib.Icons8_32x32.Icons8_Camping_water_bottle.png"},
            {"Catering_Bar", "Tripous.ResLib.Icons8_32x32.Icons8_Catering_bar.png"},
            {"Catering_Cafe", "Tripous.ResLib.Icons8_32x32.Icons8_Catering_cafe.png"},
            {"Catering_Delivery", "Tripous.ResLib.Icons8_32x32.Icons8_Catering_Delivery.png"},
            {"Catering_Restaurant", "Tripous.ResLib.Icons8_32x32.Icons8_Catering_restaurant.png"},
            {"Cell_Phone_Android", "Tripous.ResLib.Icons8_32x32.Icons8_Cell_Phone_android.png"},
            {"Cell_Phone_Blackberry", "Tripous.ResLib.Icons8_32x32.Icons8_Cell_Phone_blackberry.png"},
            {"Cell_Phone_Iphone", "Tripous.ResLib.Icons8_32x32.Icons8_Cell_Phone_iphone.png"},
            {"Cell_Phone_Windows", "Tripous.ResLib.Icons8_32x32.Icons8_Cell_Phone_windows.png"},
            {"Chart_Area", "Tripous.ResLib.Icons8_32x32.Icons8_Chart_area.png"},
            {"Chart_Bar", "Tripous.ResLib.Icons8_32x32.Icons8_Chart_bar.png"},
            {"Chart_Combo", "Tripous.ResLib.Icons8_32x32.Icons8_Chart_combo.png"},
            {"Chart_Donat", "Tripous.ResLib.Icons8_32x32.Icons8_Chart_Donat.png"},
            {"Chart_Flow", "Tripous.ResLib.Icons8_32x32.Icons8_Chart_Flow.png"},
            {"Chart_Genealogy", "Tripous.ResLib.Icons8_32x32.Icons8_Chart_genealogy.png"},
            {"Chart_Heat_Map", "Tripous.ResLib.Icons8_32x32.Icons8_Chart_heat_map.png"},
            {"Chart_Line", "Tripous.ResLib.Icons8_32x32.Icons8_Chart_line.png"},
            {"Chart_Mind_Map", "Tripous.ResLib.Icons8_32x32.Icons8_Chart_mind_map.png"},
            {"Chart_Negative_Dynamic", "Tripous.ResLib.Icons8_32x32.Icons8_Chart_negative_dynamic.png"},
            {"Chart_Pie", "Tripous.ResLib.Icons8_32x32.Icons8_Chart_pie.png"},
            {"Chart_Positive_Dynamic", "Tripous.ResLib.Icons8_32x32.Icons8_Chart_positive_dynamic.png"},
            {"Chart_Radar_Plot", "Tripous.ResLib.Icons8_32x32.Icons8_Chart_radar_plot.png"},
            {"Chart_Scatter_Plot", "Tripous.ResLib.Icons8_32x32.Icons8_Chart_scatter_plot.png"},
            {"Chess_Bishop", "Tripous.ResLib.Icons8_32x32.Icons8_Chess_bishop.png"},
            {"Chess_King", "Tripous.ResLib.Icons8_32x32.Icons8_Chess_king.png"},
            {"Chess_Knight", "Tripous.ResLib.Icons8_32x32.Icons8_Chess_knight.png"},
            {"Chess_Pawn", "Tripous.ResLib.Icons8_32x32.Icons8_Chess_pawn.png"},
            {"Chess_Queen", "Tripous.ResLib.Icons8_32x32.Icons8_Chess_queen.png"},
            {"Chess_Rook", "Tripous.ResLib.Icons8_32x32.Icons8_Chess_rook.png"},
            {"City_Airport", "Tripous.ResLib.Icons8_32x32.Icons8_City_airport.png"},
            {"City_Bank", "Tripous.ResLib.Icons8_32x32.Icons8_City_bank.png"},
            {"City_Church", "Tripous.ResLib.Icons8_32x32.Icons8_City_church.png"},
            {"City_Gas_Station", "Tripous.ResLib.Icons8_32x32.Icons8_City_gas_station.png"},
            {"City_Gps_Device", "Tripous.ResLib.Icons8_32x32.Icons8_City_gps_device.png"},
            {"City_Hospital", "Tripous.ResLib.Icons8_32x32.Icons8_City_hospital.png"},
            {"City_Hospital2", "Tripous.ResLib.Icons8_32x32.Icons8_City_hospital2.png"},
            {"City_Hotel", "Tripous.ResLib.Icons8_32x32.Icons8_City_hotel.png"},
            {"City_Raiway_Station", "Tripous.ResLib.Icons8_32x32.Icons8_City_raiway_station.png"},
            {"City_Restaurant", "Tripous.ResLib.Icons8_32x32.Icons8_City_restaurant.png"},
            {"City_Stadium", "Tripous.ResLib.Icons8_32x32.Icons8_City_stadium.png"},
            {"Civilization_Ankh", "Tripous.ResLib.Icons8_32x32.Icons8_Civilization_ankh.png"},
            {"Civilization_Anubis", "Tripous.ResLib.Icons8_32x32.Icons8_Civilization_anubis.png"},
            {"Civilization_Bowler_Hat", "Tripous.ResLib.Icons8_32x32.Icons8_Civilization_bowler_hat.png"},
            {"Civilization_Brandenburg_Gate", "Tripous.ResLib.Icons8_32x32.Icons8_Civilization_brandenburg_gate.png"},
            {"Civilization_Bull", "Tripous.ResLib.Icons8_32x32.Icons8_Civilization_bull.png"},
            {"Civilization_Chichen_Itza", "Tripous.ResLib.Icons8_32x32.Icons8_Civilization_chichen_itza.png"},
            {"Civilization_Chili_Papper", "Tripous.ResLib.Icons8_32x32.Icons8_Civilization_chili_papper.png"},
            {"Civilization_Cross", "Tripous.ResLib.Icons8_32x32.Icons8_Civilization_cross.png"},
            {"Civilization_Dharmacakra", "Tripous.ResLib.Icons8_32x32.Icons8_Civilization_dharmacakra.png"},
            {"Civilization_Fan2", "Tripous.ResLib.Icons8_32x32.Icons8_Civilization_fan2.png"},
            {"Civilization_Geisha", "Tripous.ResLib.Icons8_32x32.Icons8_Civilization_geisha.png"},
            {"Civilization_German_Hat", "Tripous.ResLib.Icons8_32x32.Icons8_Civilization_german_hat.png"},
            {"Civilization_Great_Wall", "Tripous.ResLib.Icons8_32x32.Icons8_Civilization_great_wall.png"},
            {"Civilization_Kettle", "Tripous.ResLib.Icons8_32x32.Icons8_Civilization_kettle.png"},
            {"Civilization_Koran", "Tripous.ResLib.Icons8_32x32.Icons8_Civilization_koran.png"},
            {"Civilization_Latern", "Tripous.ResLib.Icons8_32x32.Icons8_Civilization_latern.png"},
            {"Civilization_Menorah", "Tripous.ResLib.Icons8_32x32.Icons8_Civilization_menorah.png"},
            {"Civilization_Mosque", "Tripous.ResLib.Icons8_32x32.Icons8_Civilization_mosque.png"},
            {"Civilization_Origami", "Tripous.ResLib.Icons8_32x32.Icons8_Civilization_origami.png"},
            {"Civilization_Pranava", "Tripous.ResLib.Icons8_32x32.Icons8_Civilization_pranava.png"},
            {"Civilization_Pretzel", "Tripous.ResLib.Icons8_32x32.Icons8_Civilization_pretzel.png"},
            {"Civilization_Pyramids", "Tripous.ResLib.Icons8_32x32.Icons8_Civilization_pyramids.png"},
            {"Civilization_Queen_Gb", "Tripous.ResLib.Icons8_32x32.Icons8_Civilization_queen_gb.png"},
            {"Civilization_Rainy_Weather", "Tripous.ResLib.Icons8_32x32.Icons8_Civilization_rainy_weather.png"},
            {"Civilization_Sagrada_Familia", "Tripous.ResLib.Icons8_32x32.Icons8_Civilization_sagrada_familia.png"},
            {"Civilization_Sombrero", "Tripous.ResLib.Icons8_32x32.Icons8_Civilization_sombrero.png"},
            {"Civilization_Star_Crescent", "Tripous.ResLib.Icons8_32x32.Icons8_Civilization_star_crescent.png"},
            {"Civilization_Star_Of_David", "Tripous.ResLib.Icons8_32x32.Icons8_Civilization_star_of_david.png"},
            {"Civilization_Sushi", "Tripous.ResLib.Icons8_32x32.Icons8_Civilization_sushi.png"},
            {"Civilization_Thor_Hammer", "Tripous.ResLib.Icons8_32x32.Icons8_Civilization_thor_hammer.png"},
            {"Civilization_Torah", "Tripous.ResLib.Icons8_32x32.Icons8_Civilization_torah.png"},
            {"Civilization_Torii", "Tripous.ResLib.Icons8_32x32.Icons8_Civilization_torii.png"},
            {"Civilization_Triskelion", "Tripous.ResLib.Icons8_32x32.Icons8_Civilization_triskelion.png"},
            {"Civilization_Viking_Helmet", "Tripous.ResLib.Icons8_32x32.Icons8_Civilization_viking_helmet.png"},
            {"Civilization_Viking_Ship", "Tripous.ResLib.Icons8_32x32.Icons8_Civilization_viking_ship.png"},
            {"Civilization_Yin_Yang", "Tripous.ResLib.Icons8_32x32.Icons8_Civilization_yin_yang.png"},
            {"Clothe_Baseball_Cap", "Tripous.ResLib.Icons8_32x32.Icons8_Clothe_baseball_cap.png"},
            {"Clothe_Bra", "Tripous.ResLib.Icons8_32x32.Icons8_Clothe_bra.png"},
            {"Clothe_Coat", "Tripous.ResLib.Icons8_32x32.Icons8_Clothe_coat.png"},
            {"Clothe_Flip_Flop", "Tripous.ResLib.Icons8_32x32.Icons8_Clothe_flip_flop.png"},
            {"Clothe_Hat_Beanie", "Tripous.ResLib.Icons8_32x32.Icons8_Clothe_hat_beanie.png"},
            {"Clothe_Jacket", "Tripous.ResLib.Icons8_32x32.Icons8_Clothe_jacket.png"},
            {"Clothe_Jumper", "Tripous.ResLib.Icons8_32x32.Icons8_Clothe_jumper.png"},
            {"Clothe_Mens_Underwear", "Tripous.ResLib.Icons8_32x32.Icons8_Clothe_mens_underwear.png"},
            {"Clothe_Shirt", "Tripous.ResLib.Icons8_32x32.Icons8_Clothe_shirt.png"},
            {"Clothe_Shoe_Man", "Tripous.ResLib.Icons8_32x32.Icons8_Clothe_shoe_man.png"},
            {"Clothe_Shoe_Woman", "Tripous.ResLib.Icons8_32x32.Icons8_Clothe_shoe_woman.png"},
            {"Clothe_Shorts", "Tripous.ResLib.Icons8_32x32.Icons8_Clothe_shorts.png"},
            {"Clothe_Socks", "Tripous.ResLib.Icons8_32x32.Icons8_Clothe_socks.png"},
            {"Clothe_Sun_Glasses", "Tripous.ResLib.Icons8_32x32.Icons8_Clothe_sun_glasses.png"},
            {"Clothe_Trainers", "Tripous.ResLib.Icons8_32x32.Icons8_Clothe_trainers.png"},
            {"Clothe_Trousers", "Tripous.ResLib.Icons8_32x32.Icons8_Clothe_trousers.png"},
            {"Clothe_T_Shirt", "Tripous.ResLib.Icons8_32x32.Icons8_Clothe_t-shirt.png"},
            {"Clothe_Womens_Underwear", "Tripous.ResLib.Icons8_32x32.Icons8_Clothe_womens_underwear.png"},
            {"Contact_Method_Icq", "Tripous.ResLib.Icons8_32x32.Icons8_Contact_Method_icq.png"},
            {"Contact_Method_Phone", "Tripous.ResLib.Icons8_32x32.Icons8_Contact_Method_phone.png"},
            {"Contact_Method_Skype", "Tripous.ResLib.Icons8_32x32.Icons8_Contact_Method_skype.png"},
            {"Data_Accept_Database", "Tripous.ResLib.Icons8_32x32.Icons8_Data_accept_database.png"},
            {"Data_Add_Database", "Tripous.ResLib.Icons8_32x32.Icons8_Data_add_database.png"},
            {"Data_Backup", "Tripous.ResLib.Icons8_32x32.Icons8_data_backup.png"},
            {"Data_Configuration", "Tripous.ResLib.Icons8_32x32.Icons8_data_configuration.png"},
            {"Data_Db", "Tripous.ResLib.Icons8_32x32.Icons8_Data_Db.png"},
            {"Data_Delete_Database", "Tripous.ResLib.Icons8_32x32.Icons8_Data_delete_database.png"},
            {"Data_Delete_Ticket", "Tripous.ResLib.Icons8_32x32.Icons8_Data_delete_ticket.png"},
            {"Data_Encryption", "Tripous.ResLib.Icons8_32x32.Icons8_data_encryption.png"},
            {"Data_Grid_Add_Column", "Tripous.ResLib.Icons8_32x32.Icons8_Data_Grid_Add_Column.png"},
            {"Data_Grid_Add_Row", "Tripous.ResLib.Icons8_32x32.Icons8_Data_Grid_Add_Row.png"},
            {"Data_Grid_Alphabetical_Sorting", "Tripous.ResLib.Icons8_32x32.Icons8_Data_Grid_alphabetical_sorting.png"},
            {"Data_Grid_Alphabetical_Sorting2", "Tripous.ResLib.Icons8_32x32.Icons8_Data_Grid_Alphabetical_Sorting2.png"},
            {"Data_Grid_Delete_Column", "Tripous.ResLib.Icons8_32x32.Icons8_Data_Grid_Delete_Column.png"},
            {"Data_Grid_Delete_Row", "Tripous.ResLib.Icons8_32x32.Icons8_Data_Grid_Delete_Row.png"},
            {"Data_Grid_Generic_Sorting", "Tripous.ResLib.Icons8_32x32.Icons8_Data_Grid_generic_sorting.png"},
            {"Data_Grid_Generic_Sorting2", "Tripous.ResLib.Icons8_32x32.Icons8_Data_Grid_Generic_Sorting2.png"},
            {"Data_Grid_Numerical_Sorting", "Tripous.ResLib.Icons8_32x32.Icons8_Data_Grid_numerical_sorting.png"},
            {"Data_Grid_Numerical_Sorting2", "Tripous.ResLib.Icons8_32x32.Icons8_Data_Grid_Numerical_Sorting2.png"},
            {"Data_Grid_View_Details", "Tripous.ResLib.Icons8_32x32.Icons8_Data_Grid_View_Details.png"},
            {"Data_Mysql", "Tripous.ResLib.Icons8_32x32.Icons8_Data_mysql.png"},
            {"Data_Php", "Tripous.ResLib.Icons8_32x32.Icons8_Data_php.png"},
            {"Data_Protection", "Tripous.ResLib.Icons8_32x32.Icons8_data_protection.png"},
            {"Data_Recovery", "Tripous.ResLib.Icons8_32x32.Icons8_data_recovery.png"},
            {"Data_Tape_Drive", "Tripous.ResLib.Icons8_32x32.Icons8_Data_tape_drive.png"},
            {"Data_Ticket", "Tripous.ResLib.Icons8_32x32.Icons8_Data_ticket.png"},
            {"Data_Zoom_In", "Tripous.ResLib.Icons8_32x32.Icons8_Data_zoom_in.png"},
            {"Data_Zoom_Out", "Tripous.ResLib.Icons8_32x32.Icons8_Data_zoom_out.png"},
            {"Debug_Bug", "Tripous.ResLib.Icons8_32x32.Icons8_Debug_bug.png"},
            {"Debug_Console", "Tripous.ResLib.Icons8_32x32.Icons8_Debug_console.png"},
            {"Debug_Copy_Link", "Tripous.ResLib.Icons8_32x32.Icons8_Debug_copy_link.png"},
            {"Debug_External_Link", "Tripous.ResLib.Icons8_32x32.Icons8_Debug_external_link.png"},
            {"Debug_Open_In_Browser", "Tripous.ResLib.Icons8_32x32.Icons8_Debug_open_in_browser.png"},
            {"Debug_Outline", "Tripous.ResLib.Icons8_32x32.Icons8_Debug_outline.png"},
            {"Debug_Variable", "Tripous.ResLib.Icons8_32x32.Icons8_Debug_variable.png"},
            {"Debug_Watch", "Tripous.ResLib.Icons8_32x32.Icons8_Debug_watch.png"},
            {"Decision", "Tripous.ResLib.Icons8_32x32.Icons8_decision.png"},
            {"Decision_Approve", "Tripous.ResLib.Icons8_32x32.Icons8_Decision_approve.png"},
            {"Decision_Bad", "Tripous.ResLib.Icons8_32x32.Icons8_Decision_bad.png"},
            {"Decision_Disapprove", "Tripous.ResLib.Icons8_32x32.Icons8_Decision_disapprove.png"},
            {"Decision_Good", "Tripous.ResLib.Icons8_32x32.Icons8_Decision_good.png"},
            {"Decision_Make", "Tripous.ResLib.Icons8_32x32.Icons8_Decision_make.png"},
            {"Decision_Neutral", "Tripous.ResLib.Icons8_32x32.Icons8_Decision_neutral.png"},
            {"Easter_Bell", "Tripous.ResLib.Icons8_32x32.Icons8_Easter_bell.png"},
            {"Easter_Cake", "Tripous.ResLib.Icons8_32x32.Icons8_easter_cake.png"},
            {"Easter_Church", "Tripous.ResLib.Icons8_32x32.Icons8_Easter_church.png"},
            {"Easter_Egg", "Tripous.ResLib.Icons8_32x32.Icons8_easter_egg.png"},
            {"Easter_Eggs", "Tripous.ResLib.Icons8_32x32.Icons8_Easter_eggs.png"},
            {"Easter_Holy_Bible", "Tripous.ResLib.Icons8_32x32.Icons8_Easter_holy_bible.png"},
            {"Easter_Pussy_Willow", "Tripous.ResLib.Icons8_32x32.Icons8_Easter_pussy_willow.png"},
            {"Easter_Rabbit", "Tripous.ResLib.Icons8_32x32.Icons8_easter_rabbit.png"},
            {"Ecommerce_Alarm_Clock", "Tripous.ResLib.Icons8_32x32.Icons8_Ecommerce_alarm_clock.png"},
            {"Ecommerce_Average", "Tripous.ResLib.Icons8_32x32.Icons8_Ecommerce_average.png"},
            {"Ecommerce_Box", "Tripous.ResLib.Icons8_32x32.Icons8_Ecommerce_box.png"},
            {"Ecommerce_Buy", "Tripous.ResLib.Icons8_32x32.Icons8_Ecommerce_buy.png"},
            {"Ecommerce_Cheap", "Tripous.ResLib.Icons8_32x32.Icons8_Ecommerce_cheap.png"},
            {"Ecommerce_Checkout", "Tripous.ResLib.Icons8_32x32.Icons8_Ecommerce_checkout.png"},
            {"Ecommerce_Empty_Box", "Tripous.ResLib.Icons8_32x32.Icons8_Ecommerce_empty_box.png"},
            {"Ecommerce_Expensive", "Tripous.ResLib.Icons8_32x32.Icons8_Ecommerce_expensive.png"},
            {"Ecommerce_Filled_Box", "Tripous.ResLib.Icons8_32x32.Icons8_Ecommerce_filled_box.png"},
            {"Ecommerce_Free_Shipping", "Tripous.ResLib.Icons8_32x32.Icons8_Ecommerce_free_shipping.png"},
            {"Ecommerce_Gift", "Tripous.ResLib.Icons8_32x32.Icons8_Ecommerce_gift.png"},
            {"Ecommerce_Handshake", "Tripous.ResLib.Icons8_32x32.Icons8_Ecommerce_handshake.png"},
            {"Ecommerce_Idea", "Tripous.ResLib.Icons8_32x32.Icons8_Ecommerce_idea.png"},
            {"Ecommerce_New", "Tripous.ResLib.Icons8_32x32.Icons8_Ecommerce_new.png"},
            {"Ecommerce_One_Free", "Tripous.ResLib.Icons8_32x32.Icons8_Ecommerce_one_free.png"},
            {"Ecommerce_Paypal", "Tripous.ResLib.Icons8_32x32.Icons8_Ecommerce_paypal.png"},
            {"Ecommerce_Price_Tag", "Tripous.ResLib.Icons8_32x32.Icons8_Ecommerce_price_tag.png"},
            {"Ecommerce_Price_Tag_Euro", "Tripous.ResLib.Icons8_32x32.Icons8_Ecommerce_price_tag_euro.png"},
            {"Ecommerce_Qr_Code", "Tripous.ResLib.Icons8_32x32.Icons8_Ecommerce_qr_code.png"},
            {"Ecommerce_Redeem", "Tripous.ResLib.Icons8_32x32.Icons8_Ecommerce_redeem.png"},
            {"Ecommerce_Return", "Tripous.ResLib.Icons8_32x32.Icons8_Ecommerce_return.png"},
            {"Ecommerce_Sale", "Tripous.ResLib.Icons8_32x32.Icons8_Ecommerce_sale.png"},
            {"Ecommerce_Sell", "Tripous.ResLib.Icons8_32x32.Icons8_Ecommerce_sell.png"},
            {"Ecommerce_Shoping_Bag", "Tripous.ResLib.Icons8_32x32.Icons8_Ecommerce_shoping_bag.png"},
            {"Ecommerce_Shoping_Basket", "Tripous.ResLib.Icons8_32x32.Icons8_Ecommerce_shoping_basket.png"},
            {"Ecommerce_Shoping_Cart", "Tripous.ResLib.Icons8_32x32.Icons8_Ecommerce_shoping_cart.png"},
            {"Ecommerce_Shoping_Cart_Filled", "Tripous.ResLib.Icons8_32x32.Icons8_Ecommerce_shoping_cart_filled.png"},
            {"Ecommerce_Tag", "Tripous.ResLib.Icons8_32x32.Icons8_Ecommerce_tag.png"},
            {"Emoticon_Angel", "Tripous.ResLib.Icons8_32x32.Icons8_Emoticon_angel.png"},
            {"Emoticon_Angry", "Tripous.ResLib.Icons8_32x32.Icons8_Emoticon_angry.png"},
            {"Emoticon_Cool", "Tripous.ResLib.Icons8_32x32.Icons8_Emoticon_cool.png"},
            {"Emoticon_Crying", "Tripous.ResLib.Icons8_32x32.Icons8_Emoticon_crying.png"},
            {"Emoticon_Evil", "Tripous.ResLib.Icons8_32x32.Icons8_Emoticon_evil.png"},
            {"Emoticon_Guestion", "Tripous.ResLib.Icons8_32x32.Icons8_Emoticon_guestion.png"},
            {"Emoticon_Happy", "Tripous.ResLib.Icons8_32x32.Icons8_Emoticon_happy.png"},
            {"Emoticon_In_Love", "Tripous.ResLib.Icons8_32x32.Icons8_Emoticon_in_love.png"},
            {"Emoticon_Kiss", "Tripous.ResLib.Icons8_32x32.Icons8_Emoticon_kiss.png"},
            {"Emoticon_Lol", "Tripous.ResLib.Icons8_32x32.Icons8_Emoticon_lol.png"},
            {"Emoticon_Private", "Tripous.ResLib.Icons8_32x32.Icons8_Emoticon_private.png"},
            {"Emoticon_Sad", "Tripous.ResLib.Icons8_32x32.Icons8_Emoticon_sad.png"},
            {"Emoticon_Sleeping", "Tripous.ResLib.Icons8_32x32.Icons8_Emoticon_sleeping.png"},
            {"Emoticon_Surprised", "Tripous.ResLib.Icons8_32x32.Icons8_Emoticon_surprised.png"},
            {"Emoticon_Tongue", "Tripous.ResLib.Icons8_32x32.Icons8_Emoticon_tongue.png"},
            {"Emoticon_Wink", "Tripous.ResLib.Icons8_32x32.Icons8_Emoticon_wink.png"},
            {"Ethernet_Network_Cable", "Tripous.ResLib.Icons8_32x32.Icons8_Ethernet_network_cable.png"},
            {"Ethernet_Network_Card", "Tripous.ResLib.Icons8_32x32.Icons8_Ethernet_network_card.png"},
            {"Ethernet_Off", "Tripous.ResLib.Icons8_32x32.Icons8_ethernet_off.png"},
            {"Ethernet_On", "Tripous.ResLib.Icons8_32x32.Icons8_ethernet_on.png"},
            {"Ethernet_Rj45", "Tripous.ResLib.Icons8_32x32.Icons8_Ethernet_rj45.png"},
            {"File_Type_Ai", "Tripous.ResLib.Icons8_32x32.Icons8_File_Type_ai.png"},
            {"File_Type_Avi", "Tripous.ResLib.Icons8_32x32.Icons8_File_Type_avi.png"},
            {"File_Type_Blu_Ray", "Tripous.ResLib.Icons8_32x32.Icons8_File_Type_blu_ray.png"},
            {"File_Type_Cd", "Tripous.ResLib.Icons8_32x32.Icons8_File_Type_cd.png"},
            {"File_Type_Csv", "Tripous.ResLib.Icons8_32x32.Icons8_File_Type_csv.png"},
            {"File_Type_Dll", "Tripous.ResLib.Icons8_32x32.Icons8_File_Type_dll.png"},
            {"File_Type_Dmg", "Tripous.ResLib.Icons8_32x32.Icons8_File_Type_dmg.png"},
            {"File_Type_Dvd", "Tripous.ResLib.Icons8_32x32.Icons8_File_Type_dvd.png"},
            {"File_Type_Exe", "Tripous.ResLib.Icons8_32x32.Icons8_File_Type_exe.png"},
            {"File_Type_Exel", "Tripous.ResLib.Icons8_32x32.Icons8_File_Type_exel.png"},
            {"File_Type_Flv", "Tripous.ResLib.Icons8_32x32.Icons8_File_Type_flv.png"},
            {"File_Type_Gif", "Tripous.ResLib.Icons8_32x32.Icons8_File_Type_gif.png"},
            {"File_Type_Jpg", "Tripous.ResLib.Icons8_32x32.Icons8_File_Type_jpg.png"},
            {"File_Type_Mov", "Tripous.ResLib.Icons8_32x32.Icons8_File_Type_mov.png"},
            {"File_Type_Mp3", "Tripous.ResLib.Icons8_32x32.Icons8_File_Type_mp3.png"},
            {"File_Type_Mpg", "Tripous.ResLib.Icons8_32x32.Icons8_File_Type_mpg.png"},
            {"File_Type_Ogg", "Tripous.ResLib.Icons8_32x32.Icons8_File_Type_ogg.png"},
            {"File_Type_Pdf", "Tripous.ResLib.Icons8_32x32.Icons8_File_Type_pdf.png"},
            {"File_Type_Png", "Tripous.ResLib.Icons8_32x32.Icons8_File_Type_png.png"},
            {"File_Type_Powerpoint", "Tripous.ResLib.Icons8_32x32.Icons8_File_Type_powerpoint.png"},
            {"File_Type_Psd", "Tripous.ResLib.Icons8_32x32.Icons8_File_Type_psd.png"},
            {"File_Type_Rar", "Tripous.ResLib.Icons8_32x32.Icons8_File_Type_rar.png"},
            {"File_Type_Vhs", "Tripous.ResLib.Icons8_32x32.Icons8_File_Type_vhs.png"},
            {"File_Type_Wma", "Tripous.ResLib.Icons8_32x32.Icons8_File_Type_wma.png"},
            {"File_Type_Word", "Tripous.ResLib.Icons8_32x32.Icons8_File_Type_word.png"},
            {"File_Type_Zip", "Tripous.ResLib.Icons8_32x32.Icons8_File_Type_zip.png"},
            {"Folder", "Tripous.ResLib.Icons8_32x32.Icons8_folder.png"},
            {"Folder_Binders", "Tripous.ResLib.Icons8_32x32.Icons8_Folder_binders.png"},
            {"Folder_Burn", "Tripous.ResLib.Icons8_32x32.Icons8_Folder_burn.png"},
            {"Folder_Documents", "Tripous.ResLib.Icons8_32x32.Icons8_Folder_documents.png"},
            {"Folder_Dossier", "Tripous.ResLib.Icons8_32x32.Icons8_Folder_dossier.png"},
            {"Folder_Downloads", "Tripous.ResLib.Icons8_32x32.Icons8_Folder_downloads.png"},
            {"Folder_Extensions", "Tripous.ResLib.Icons8_32x32.Icons8_Folder_extensions.png"},
            {"Folder_Internet", "Tripous.ResLib.Icons8_32x32.Icons8_Folder_internet.png"},
            {"Folder_Likes", "Tripous.ResLib.Icons8_32x32.Icons8_Folder_likes.png"},
            {"Folder_Movies", "Tripous.ResLib.Icons8_32x32.Icons8_Folder_movies.png"},
            {"Folder_Music", "Tripous.ResLib.Icons8_32x32.Icons8_Folder_music.png"},
            {"Folder_Pictures", "Tripous.ResLib.Icons8_32x32.Icons8_Folder_pictures.png"},
            {"Folder_Porn", "Tripous.ResLib.Icons8_32x32.Icons8_Folder_porn.png"},
            {"Folder_User", "Tripous.ResLib.Icons8_32x32.Icons8_Folder_user.png"},
            {"Footprint_Bear", "Tripous.ResLib.Icons8_32x32.Icons8_Footprint_bear.png"},
            {"Footprint_Cat", "Tripous.ResLib.Icons8_32x32.Icons8_Footprint_cat.png"},
            {"Footprint_Dog", "Tripous.ResLib.Icons8_32x32.Icons8_Footprint_dog.png"},
            {"Footprint_Human_Footprints", "Tripous.ResLib.Icons8_32x32.Icons8_Footprint_human_footprints.png"},
            {"Footprint_Left_Footprint", "Tripous.ResLib.Icons8_32x32.Icons8_Footprint_left_footprint.png"},
            {"Footprint_Left_Shoe", "Tripous.ResLib.Icons8_32x32.Icons8_Footprint_left_shoe.png"},
            {"Footprint_Right_Footprint", "Tripous.ResLib.Icons8_32x32.Icons8_Footprint_right_footprint.png"},
            {"Footprint_Right_Shoe", "Tripous.ResLib.Icons8_32x32.Icons8_Footprint_right_shoe.png"},
            {"Footprint_Shoes", "Tripous.ResLib.Icons8_32x32.Icons8_Footprint_shoes.png"},
            {"Forum_Child_New_Post", "Tripous.ResLib.Icons8_32x32.Icons8_Forum_child_new_post.png"},
            {"Forum_Closed_Topic", "Tripous.ResLib.Icons8_32x32.Icons8_Forum_closed_topic.png"},
            {"Forum_Delete_Message", "Tripous.ResLib.Icons8_32x32.Icons8_Forum_delete_message.png"},
            {"Forum_Moved_Topic", "Tripous.ResLib.Icons8_32x32.Icons8_Forum_moved_topic.png"},
            {"Forum_My_Topic", "Tripous.ResLib.Icons8_32x32.Icons8_Forum_my_topic.png"},
            {"Forum_New_Post", "Tripous.ResLib.Icons8_32x32.Icons8_Forum_new_post.png"},
            {"Forum_Online", "Tripous.ResLib.Icons8_32x32.Icons8_Forum_online.png"},
            {"Forum_Pin", "Tripous.ResLib.Icons8_32x32.Icons8_Forum_pin.png"},
            {"Forum_Poll_Topic", "Tripous.ResLib.Icons8_32x32.Icons8_Forum_poll_topic.png"},
            {"Forum_Popular_Topic", "Tripous.ResLib.Icons8_32x32.Icons8_Forum_popular_topic.png"},
            {"Forum_Quote", "Tripous.ResLib.Icons8_32x32.Icons8_Forum_quote.png"},
            {"Forum_Response", "Tripous.ResLib.Icons8_32x32.Icons8_Forum_response.png"},
            {"Forum_Rss", "Tripous.ResLib.Icons8_32x32.Icons8_Forum_rss.png"},
            {"Forum_Topic", "Tripous.ResLib.Icons8_32x32.Icons8_Forum_topic.png"},
            {"Forum_Very_Popular_Topic", "Tripous.ResLib.Icons8_32x32.Icons8_Forum_very_popular_topic.png"},
            {"Gamble_Cards", "Tripous.ResLib.Icons8_32x32.Icons8_Gamble_cards.png"},
            {"Gamble_Chip", "Tripous.ResLib.Icons8_32x32.Icons8_Gamble_chip.png"},
            {"Gamble_Clover", "Tripous.ResLib.Icons8_32x32.Icons8_Gamble_clover.png"},
            {"Gamble_Clubs", "Tripous.ResLib.Icons8_32x32.Icons8_Gamble_clubs.png"},
            {"Gamble_Diamonds", "Tripous.ResLib.Icons8_32x32.Icons8_Gamble_diamonds.png"},
            {"Gamble_Dice", "Tripous.ResLib.Icons8_32x32.Icons8_Gamble_dice.png"},
            {"Gamble_Hearts", "Tripous.ResLib.Icons8_32x32.Icons8_Gamble_hearts.png"},
            {"Gamble_Joker", "Tripous.ResLib.Icons8_32x32.Icons8_Gamble_joker.png"},
            {"Gamble_Slot_Machine", "Tripous.ResLib.Icons8_32x32.Icons8_Gamble_slot_machine.png"},
            {"Gamble_Spades", "Tripous.ResLib.Icons8_32x32.Icons8_Gamble_spades.png"},
            {"Gamble_Win", "Tripous.ResLib.Icons8_32x32.Icons8_Gamble_win.png"},
            {"Geo_Compass", "Tripous.ResLib.Icons8_32x32.Icons8_Geo_compass.png"},
            {"Geo_Define_Location", "Tripous.ResLib.Icons8_32x32.Icons8_Geo_define_location.png"},
            {"Geo_Empty_Flag", "Tripous.ResLib.Icons8_32x32.Icons8_Geo_empty_flag.png"},
            {"Geo_Filled_Flag", "Tripous.ResLib.Icons8_32x32.Icons8_Geo_filled_flag.png"},
            {"Geo_Globe", "Tripous.ResLib.Icons8_32x32.Icons8_Geo_globe.png"},
            {"Geo_Gps_Disconnected", "Tripous.ResLib.Icons8_32x32.Icons8_Geo_gps_disconnected.png"},
            {"Geo_Gps_Receiving", "Tripous.ResLib.Icons8_32x32.Icons8_Geo_gps_receiving.png"},
            {"Geo_Gps_Searching", "Tripous.ResLib.Icons8_32x32.Icons8_Geo_gps_searching.png"},
            {"Geo_Layers", "Tripous.ResLib.Icons8_32x32.Icons8_Geo_layers.png"},
            {"Geo_Map", "Tripous.ResLib.Icons8_32x32.Icons8_Geo_map.png"},
            {"Geo_Map_Marker", "Tripous.ResLib.Icons8_32x32.Icons8_Geo_map_marker.png"},
            {"Geo_Marker", "Tripous.ResLib.Icons8_32x32.Icons8_Geo_marker.png"},
            {"Geo_Point_Objects", "Tripous.ResLib.Icons8_32x32.Icons8_Geo_point_objects.png"},
            {"Geo_Polygom", "Tripous.ResLib.Icons8_32x32.Icons8_Geo_polygom.png"},
            {"Geo_Polyline", "Tripous.ResLib.Icons8_32x32.Icons8_Geo_polyline.png"},
            {"Geo_Road", "Tripous.ResLib.Icons8_32x32.Icons8_Geo_road.png"},
            {"Geo_Signpost", "Tripous.ResLib.Icons8_32x32.Icons8_Geo_signpost.png"},
            {"Geo_Street_View", "Tripous.ResLib.Icons8_32x32.Icons8_Geo_street_view.png"},
            {"Geo_Wind_Rose", "Tripous.ResLib.Icons8_32x32.Icons8_Geo_wind_rose.png"},
            {"Geo_World_Map", "Tripous.ResLib.Icons8_32x32.Icons8_Geo_world_map.png"},
            {"Geo_Worldwide_Location", "Tripous.ResLib.Icons8_32x32.Icons8_Geo_worldwide_location.png"},
            {"Gesture_2F_Double_Tap", "Tripous.ResLib.Icons8_32x32.Icons8_Gesture_2f_double_tap.png"},
            {"Gesture_2F_Swipe_Down", "Tripous.ResLib.Icons8_32x32.Icons8_Gesture_2f_swipe_down.png"},
            {"Gesture_2F_Swipe_Left", "Tripous.ResLib.Icons8_32x32.Icons8_Gesture_2f_swipe_left.png"},
            {"Gesture_2F_Swipe_Right", "Tripous.ResLib.Icons8_32x32.Icons8_Gesture_2f_swipe_right.png"},
            {"Gesture_2F_Swipe_Up", "Tripous.ResLib.Icons8_32x32.Icons8_Gesture_2f_swipe_up.png"},
            {"Gesture_2F_Tap", "Tripous.ResLib.Icons8_32x32.Icons8_Gesture_2f_tap.png"},
            {"Gesture_Double_Tap", "Tripous.ResLib.Icons8_32x32.Icons8_Gesture_double_tap.png"},
            {"Gesture_Pinch", "Tripous.ResLib.Icons8_32x32.Icons8_Gesture_pinch.png"},
            {"Gesture_Spread", "Tripous.ResLib.Icons8_32x32.Icons8_Gesture_spread.png"},
            {"Gesture_Swipe_Down", "Tripous.ResLib.Icons8_32x32.Icons8_Gesture_swipe_down.png"},
            {"Gesture_Swipe_Left", "Tripous.ResLib.Icons8_32x32.Icons8_Gesture_swipe_left.png"},
            {"Gesture_Swipe_Right", "Tripous.ResLib.Icons8_32x32.Icons8_Gesture_swipe_right.png"},
            {"Gesture_Swipe_Up", "Tripous.ResLib.Icons8_32x32.Icons8_Gesture_swipe_up.png"},
            {"Gesture_Tap", "Tripous.ResLib.Icons8_32x32.Icons8_Gesture_tap.png"},
            {"Google_Alerts", "Tripous.ResLib.Icons8_32x32.Icons8_google_alerts.png"},
            {"Google_Blog_Search", "Tripous.ResLib.Icons8_32x32.Icons8_google_blog_search.png"},
            {"Google_Code", "Tripous.ResLib.Icons8_32x32.Icons8_google_code.png"},
            {"Google_Drive", "Tripous.ResLib.Icons8_32x32.Icons8_google_drive.png"},
            {"Google_Earth", "Tripous.ResLib.Icons8_32x32.Icons8_google_earth.png"},
            {"Google_Groups", "Tripous.ResLib.Icons8_32x32.Icons8_google_groups.png"},
            {"Google_Images", "Tripous.ResLib.Icons8_32x32.Icons8_google_images.png"},
            {"Google_Mobile", "Tripous.ResLib.Icons8_32x32.Icons8_google_mobile.png"},
            {"Google_News", "Tripous.ResLib.Icons8_32x32.Icons8_google_news.png"},
            {"Google_Scholar", "Tripous.ResLib.Icons8_32x32.Icons8_google_scholar.png"},
            {"Google_Sketchup", "Tripous.ResLib.Icons8_32x32.Icons8_google_sketchup.png"},
            {"Google_Translate", "Tripous.ResLib.Icons8_32x32.Icons8_google_translate.png"},
            {"Google_Web_Search", "Tripous.ResLib.Icons8_32x32.Icons8_google_web_search.png"},
            {"Hair_Band", "Tripous.ResLib.Icons8_32x32.Icons8_hair_band.png"},
            {"Hair_Barber_Scissors", "Tripous.ResLib.Icons8_32x32.Icons8_Hair_barber_scissors.png"},
            {"Hair_Barbers_Chair", "Tripous.ResLib.Icons8_32x32.Icons8_Hair_barbers_chair.png"},
            {"Hair_Barbers_Pole", "Tripous.ResLib.Icons8_32x32.Icons8_Hair_barbers_pole.png"},
            {"Hair_Brush", "Tripous.ResLib.Icons8_32x32.Icons8_hair_brush.png"},
            {"Hair_Clip", "Tripous.ResLib.Icons8_32x32.Icons8_hair_clip.png"},
            {"Hair_Comb", "Tripous.ResLib.Icons8_32x32.Icons8_Hair_comb.png"},
            {"Hair_Dryer", "Tripous.ResLib.Icons8_32x32.Icons8_hair_dryer.png"},
            {"Hair_Goatee", "Tripous.ResLib.Icons8_32x32.Icons8_Hair_goatee.png"},
            {"Hair_Long_Beard", "Tripous.ResLib.Icons8_32x32.Icons8_Hair_long_beard.png"},
            {"Hair_Mustache", "Tripous.ResLib.Icons8_32x32.Icons8_Hair_mustache.png"},
            {"Hair_Scrunchy", "Tripous.ResLib.Icons8_32x32.Icons8_Hair_scrunchy.png"},
            {"Hair_Short_Beard", "Tripous.ResLib.Icons8_32x32.Icons8_Hair_short_beard.png"},
            {"Hair_Sideburns", "Tripous.ResLib.Icons8_32x32.Icons8_Hair_sideburns.png"},
            {"Hair_Stubble", "Tripous.ResLib.Icons8_32x32.Icons8_Hair_stubble.png"},
            {"Hair_Van_Dyke", "Tripous.ResLib.Icons8_32x32.Icons8_Hair_van_dyke.png"},
            {"Hair_Washing_Sink", "Tripous.ResLib.Icons8_32x32.Icons8_hair_washing_sink.png"},
            {"Halloween_Frankenstein", "Tripous.ResLib.Icons8_32x32.Icons8_Halloween_frankenstein.png"},
            {"Halloween_Vampire", "Tripous.ResLib.Icons8_32x32.Icons8_Halloween_vampire.png"},
            {"Halloween_Werewolf", "Tripous.ResLib.Icons8_32x32.Icons8_Halloween_werewolf.png"},
            {"Halloween_Witch", "Tripous.ResLib.Icons8_32x32.Icons8_Halloween_witch.png"},
            {"Halloween_Wizard", "Tripous.ResLib.Icons8_32x32.Icons8_Halloween_wizard.png"},
            {"Halloween_Zombie", "Tripous.ResLib.Icons8_32x32.Icons8_Halloween_zombie.png"},
            {"Hand_Clenched_Fist", "Tripous.ResLib.Icons8_32x32.Icons8_Hand_clenched_fist.png"},
            {"Hand_Finger_And_Thumb", "Tripous.ResLib.Icons8_32x32.Icons8_Hand_finger_and_thumb.png"},
            {"Hand_Four_Fingers", "Tripous.ResLib.Icons8_32x32.Icons8_Hand_four_fingers.png"},
            {"Hand_One_Finger", "Tripous.ResLib.Icons8_32x32.Icons8_Hand_one_finger.png"},
            {"Hand_So_So", "Tripous.ResLib.Icons8_32x32.Icons8_Hand_so-so.png"},
            {"Hand_Three_Fingers", "Tripous.ResLib.Icons8_32x32.Icons8_Hand_three_fingers.png"},
            {"Hand_Thumbs_Down", "Tripous.ResLib.Icons8_32x32.Icons8_Hand_thumbs_down.png"},
            {"Hand_Thumbs_Up", "Tripous.ResLib.Icons8_32x32.Icons8_Hand_thumbs_up.png"},
            {"Hand_Two_Fingers", "Tripous.ResLib.Icons8_32x32.Icons8_Hand_two_fingers.png"},
            {"Hand_Two_Hands", "Tripous.ResLib.Icons8_32x32.Icons8_Hand_two_hands.png"},
            {"Hand_Whole_Hand", "Tripous.ResLib.Icons8_32x32.Icons8_Hand_whole_hand.png"},
            {"Hardware_Keyboard", "Tripous.ResLib.Icons8_32x32.Icons8_Hardware_keyboard.png"},
            {"Hardware_Monitor", "Tripous.ResLib.Icons8_32x32.Icons8_Hardware_monitor.png"},
            {"Hardware_Mouse", "Tripous.ResLib.Icons8_32x32.Icons8_Hardware_mouse.png"},
            {"Hardware_Notebook", "Tripous.ResLib.Icons8_32x32.Icons8_Hardware_notebook.png"},
            {"Hardware_Scanner", "Tripous.ResLib.Icons8_32x32.Icons8_Hardware_scanner.png"},
            {"Hot_Beverage_Chocolate", "Tripous.ResLib.Icons8_32x32.Icons8_Hot_Beverage_chocolate.png"},
            {"Hot_Beverage_Coffee", "Tripous.ResLib.Icons8_32x32.Icons8_Hot_Beverage_coffee.png"},
            {"Hot_Beverage_Honey", "Tripous.ResLib.Icons8_32x32.Icons8_Hot_Beverage_honey.png"},
            {"Hot_Beverage_Milk", "Tripous.ResLib.Icons8_32x32.Icons8_Hot_Beverage_milk.png"},
            {"Hot_Beverage_Sugar", "Tripous.ResLib.Icons8_32x32.Icons8_Hot_Beverage_sugar.png"},
            {"Hot_Beverage_Tea", "Tripous.ResLib.Icons8_32x32.Icons8_Hot_Beverage_tea.png"},
            {"Image_Tool_Arrow", "Tripous.ResLib.Icons8_32x32.Icons8_Image_Tool_arrow.png"},
            {"Image_Tool_Ball_Point_Pen", "Tripous.ResLib.Icons8_32x32.Icons8_Image_Tool_ball_point_pen.png"},
            {"Image_Tool_Brush", "Tripous.ResLib.Icons8_32x32.Icons8_Image_Tool_brush.png"},
            {"Image_Tool_Chisel_Tip_Marker", "Tripous.ResLib.Icons8_32x32.Icons8_Image_Tool_chisel_tip_marker.png"},
            {"Image_Tool_Collapse", "Tripous.ResLib.Icons8_32x32.Icons8_Image_Tool_collapse.png"},
            {"Image_Tool_Color_Dropper", "Tripous.ResLib.Icons8_32x32.Icons8_Image_Tool_color_dropper.png"},
            {"Image_Tool_Crop", "Tripous.ResLib.Icons8_32x32.Icons8_Image_Tool_crop.png"},
            {"Image_Tool_Diamond", "Tripous.ResLib.Icons8_32x32.Icons8_Image_Tool_diamond.png"},
            {"Image_Tool_Ellips", "Tripous.ResLib.Icons8_32x32.Icons8_Image_Tool_ellips.png"},
            {"Image_Tool_Ellipse_Stroked", "Tripous.ResLib.Icons8_32x32.Icons8_Image_Tool_ellipse_stroked.png"},
            {"Image_Tool_Eraser", "Tripous.ResLib.Icons8_32x32.Icons8_Image_Tool_eraser.png"},
            {"Image_Tool_Expand", "Tripous.ResLib.Icons8_32x32.Icons8_Image_Tool_expand.png"},
            {"Image_Tool_Flip_Horizontal", "Tripous.ResLib.Icons8_32x32.Icons8_Image_Tool_flip_horizontal.png"},
            {"Image_Tool_Flip_Vertical", "Tripous.ResLib.Icons8_32x32.Icons8_Image_Tool_flip_vertical.png"},
            {"Image_Tool_Hexagon", "Tripous.ResLib.Icons8_32x32.Icons8_Image_Tool_hexagon.png"},
            {"Image_Tool_Line", "Tripous.ResLib.Icons8_32x32.Icons8_Image_Tool_line.png"},
            {"Image_Tool_Line_Width", "Tripous.ResLib.Icons8_32x32.Icons8_Image_Tool_line_width.png"},
            {"Image_Tool_Octagon", "Tripous.ResLib.Icons8_32x32.Icons8_Image_Tool_octagon.png"},
            {"Image_Tool_Pen", "Tripous.ResLib.Icons8_32x32.Icons8_Image_Tool_pen.png"},
            {"Image_Tool_Pencil", "Tripous.ResLib.Icons8_32x32.Icons8_Image_Tool_pencil.png"},
            {"Image_Tool_Pentagon", "Tripous.ResLib.Icons8_32x32.Icons8_Image_Tool_pentagon.png"},
            {"Image_Tool_Rectangle", "Tripous.ResLib.Icons8_32x32.Icons8_Image_Tool_rectangle.png"},
            {"Image_Tool_Rectangle_Stroked", "Tripous.ResLib.Icons8_32x32.Icons8_Image_Tool_rectangle_stroked.png"},
            {"Image_Tool_Resize", "Tripous.ResLib.Icons8_32x32.Icons8_Image_Tool_resize.png"},
            {"Image_Tool_Roller_Brush", "Tripous.ResLib.Icons8_32x32.Icons8_Image_Tool_roller_brush.png"},
            {"Image_Tool_Rotate", "Tripous.ResLib.Icons8_32x32.Icons8_Image_Tool_rotate.png"},
            {"Image_Tool_Rounded_Rectangle", "Tripous.ResLib.Icons8_32x32.Icons8_Image_Tool_rounded_rectangle.png"},
            {"Image_Tool_Screenshot", "Tripous.ResLib.Icons8_32x32.Icons8_Image_Tool_screenshot.png"},
            {"Image_Tool_Text", "Tripous.ResLib.Icons8_32x32.Icons8_Image_Tool_text.png"},
            {"Image_Tool_Triangle_Stroked", "Tripous.ResLib.Icons8_32x32.Icons8_Image_Tool_triangle_stroked.png"},
            {"Industry_Automotive", "Tripous.ResLib.Icons8_32x32.Icons8_Industry_automotive.png"},
            {"Industry_Biohazard", "Tripous.ResLib.Icons8_32x32.Icons8_Industry_biohazard.png"},
            {"Industry_Biomass", "Tripous.ResLib.Icons8_32x32.Icons8_Industry_biomass.png"},
            {"Industry_Biotech", "Tripous.ResLib.Icons8_32x32.Icons8_Industry_biotech.png"},
            {"Industry_Capacitor", "Tripous.ResLib.Icons8_32x32.Icons8_Industry_capacitor.png"},
            {"Industry_Circuit", "Tripous.ResLib.Icons8_32x32.Icons8_Industry_circuit.png"},
            {"Industry_Crystal_Oscillator", "Tripous.ResLib.Icons8_32x32.Icons8_Industry_crystal_oscillator.png"},
            {"Industry_Display", "Tripous.ResLib.Icons8_32x32.Icons8_Industry_display.png"},
            {"Industry_Electricity", "Tripous.ResLib.Icons8_32x32.Icons8_Industry_electricity.png"},
            {"Industry_Electro_Devices", "Tripous.ResLib.Icons8_32x32.Icons8_Industry_electro_devices.png"},
            {"Industry_Electronics", "Tripous.ResLib.Icons8_32x32.Icons8_Industry_electronics.png"},
            {"Industry_Engineering", "Tripous.ResLib.Icons8_32x32.Icons8_Industry_engineering.png"},
            {"Industry_Factory", "Tripous.ResLib.Icons8_32x32.Icons8_Industry_factory.png"},
            {"Industry_Fork_Truck", "Tripous.ResLib.Icons8_32x32.Icons8_Industry_fork_truck.png"},
            {"Industry_Gas", "Tripous.ResLib.Icons8_32x32.Icons8_Industry_gas.png"},
            {"Industry_Gas_Mask", "Tripous.ResLib.Icons8_32x32.Icons8_Industry_gas_mask.png"},
            {"Industry_Geothermal", "Tripous.ResLib.Icons8_32x32.Icons8_Industry_geothermal.png"},
            {"Industry_Greentech", "Tripous.ResLib.Icons8_32x32.Icons8_Industry_greentech.png"},
            {"Industry_Hydroelectric", "Tripous.ResLib.Icons8_32x32.Icons8_Industry_hydroelectric.png"},
            {"Industry_Infrared", "Tripous.ResLib.Icons8_32x32.Icons8_Industry_infrared.png"},
            {"Industry_Infrared_Beam_Sending", "Tripous.ResLib.Icons8_32x32.Icons8_Industry_infrared_beam_sending.png"},
            {"Industry_Infrared_Sensor", "Tripous.ResLib.Icons8_32x32.Icons8_Industry_infrared_sensor.png"},
            {"Industry_Integrated_Circuit", "Tripous.ResLib.Icons8_32x32.Icons8_Industry_integrated_circuit.png"},
            {"Industry_Ladder", "Tripous.ResLib.Icons8_32x32.Icons8_Industry_ladder.png"},
            {"Industry_Led_Diode", "Tripous.ResLib.Icons8_32x32.Icons8_Industry_led_diode.png"},
            {"Industry_Memmory_Slot", "Tripous.ResLib.Icons8_32x32.Icons8_Industry_memmory_slot.png"},
            {"Industry_Overhead_Crane", "Tripous.ResLib.Icons8_32x32.Icons8_Industry_overhead_crane.png"},
            {"Industry_Poison", "Tripous.ResLib.Icons8_32x32.Icons8_Industry_poison.png"},
            {"Industry_Potentiometer", "Tripous.ResLib.Icons8_32x32.Icons8_Industry_potentiometer.png"},
            {"Industry_Processor", "Tripous.ResLib.Icons8_32x32.Icons8_Industry_processor.png"},
            {"Industry_Rack", "Tripous.ResLib.Icons8_32x32.Icons8_Industry_rack.png"},
            {"Industry_Radioactive", "Tripous.ResLib.Icons8_32x32.Icons8_Industry_radioactive.png"},
            {"Industry_Recycling", "Tripous.ResLib.Icons8_32x32.Icons8_Industry_recycling.png"},
            {"Industry_Relay", "Tripous.ResLib.Icons8_32x32.Icons8_Industry_relay.png"},
            {"Industry_Research", "Tripous.ResLib.Icons8_32x32.Icons8_Industry_research.png"},
            {"Industry_Resistor", "Tripous.ResLib.Icons8_32x32.Icons8_Industry_resistor.png"},
            {"Industry_Rfid_Sensor", "Tripous.ResLib.Icons8_32x32.Icons8_Industry_rfid_sensor.png"},
            {"Industry_Rfid_Signal", "Tripous.ResLib.Icons8_32x32.Icons8_Industry_rfid_signal.png"},
            {"Industry_Rfid_Tag", "Tripous.ResLib.Icons8_32x32.Icons8_Industry_rfid_tag.png"},
            {"Industry_Robot", "Tripous.ResLib.Icons8_32x32.Icons8_Industry_robot.png"},
            {"Industry_Sensor", "Tripous.ResLib.Icons8_32x32.Icons8_Industry_sensor.png"},
            {"Industry_Solar_Panel", "Tripous.ResLib.Icons8_32x32.Icons8_Industry_solar_panel.png"},
            {"Industry_Stepper_Motor", "Tripous.ResLib.Icons8_32x32.Icons8_Industry_stepper_motor.png"},
            {"Industry_Transistor", "Tripous.ResLib.Icons8_32x32.Icons8_Industry_transistor.png"},
            {"Industry_Trash", "Tripous.ResLib.Icons8_32x32.Icons8_Industry_trash.png"},
            {"Industry_Water", "Tripous.ResLib.Icons8_32x32.Icons8_Industry_water.png"},
            {"Industry_Wind_Turbine", "Tripous.ResLib.Icons8_32x32.Icons8_Industry_wind_turbine.png"},
            {"IT_32Bit", "Tripous.ResLib.Icons8_32x32.Icons8_IT_32bit.png"},
            {"IT_64Bit", "Tripous.ResLib.Icons8_32x32.Icons8_IT_64bit.png"},
            {"IT_Active_Directory", "Tripous.ResLib.Icons8_32x32.Icons8_IT_active_directory.png"},
            {"IT_Bluetooth", "Tripous.ResLib.Icons8_32x32.Icons8_IT_bluetooth.png"},
            {"IT_Cisco_Router", "Tripous.ResLib.Icons8_32x32.Icons8_IT_cisco_router.png"},
            {"IT_Cloud", "Tripous.ResLib.Icons8_32x32.Icons8_IT_cloud.png"},
            {"IT_Cloud_Storage", "Tripous.ResLib.Icons8_32x32.Icons8_IT_cloud_storage.png"},
            {"IT_Computer", "Tripous.ResLib.Icons8_32x32.Icons8_IT_computer.png"},
            {"IT_Connected", "Tripous.ResLib.Icons8_32x32.Icons8_IT_connected.png"},
            {"IT_Disconnected", "Tripous.ResLib.Icons8_32x32.Icons8_IT_disconnected.png"},
            {"IT_Domain", "Tripous.ResLib.Icons8_32x32.Icons8_IT_domain.png"},
            {"IT_Hdd", "Tripous.ResLib.Icons8_32x32.Icons8_IT_hdd.png"},
            {"IT_Hub", "Tripous.ResLib.Icons8_32x32.Icons8_IT_hub.png"},
            {"IT_Ip_Adress", "Tripous.ResLib.Icons8_32x32.Icons8_IT_ip_adress.png"},
            {"IT_Linux_Client", "Tripous.ResLib.Icons8_32x32.Icons8_IT_linux_client.png"},
            {"IT_Mac_Client", "Tripous.ResLib.Icons8_32x32.Icons8_IT_mac_client.png"},
            {"IT_Nas", "Tripous.ResLib.Icons8_32x32.Icons8_IT_nas.png"},
            {"IT_Network", "Tripous.ResLib.Icons8_32x32.Icons8_IT_network.png"},
            {"IT_Remote_Control", "Tripous.ResLib.Icons8_32x32.Icons8_IT_remote_control.png"},
            {"IT_Remote_Working", "Tripous.ResLib.Icons8_32x32.Icons8_IT_remote_working.png"},
            {"IT_Router", "Tripous.ResLib.Icons8_32x32.Icons8_IT_router.png"},
            {"IT_Server", "Tripous.ResLib.Icons8_32x32.Icons8_IT_server.png"},
            {"IT_Ssd", "Tripous.ResLib.Icons8_32x32.Icons8_IT_ssd.png"},
            {"IT_Stack", "Tripous.ResLib.Icons8_32x32.Icons8_IT_stack.png"},
            {"IT_Switch", "Tripous.ResLib.Icons8_32x32.Icons8_IT_switch.png"},
            {"IT_Voip_Gateway", "Tripous.ResLib.Icons8_32x32.Icons8_IT_voip_gateway.png"},
            {"IT_Vpn", "Tripous.ResLib.Icons8_32x32.Icons8_IT_vpn.png"},
            {"IT_Wi_Fi", "Tripous.ResLib.Icons8_32x32.Icons8_IT_wi_fi.png"},
            {"IT_Wi_Fi_Direct", "Tripous.ResLib.Icons8_32x32.Icons8_IT_wi_fi_direct.png"},
            {"IT_Wifi", "Tripous.ResLib.Icons8_32x32.Icons8_IT_wifi.png"},
            {"IT_Windows_Client", "Tripous.ResLib.Icons8_32x32.Icons8_IT_windows_client.png"},
            {"IT_Workstation", "Tripous.ResLib.Icons8_32x32.Icons8_IT_workstation.png"},
            {"IT_X64", "Tripous.ResLib.Icons8_32x32.Icons8_IT_x64.png"},
            {"IT_X86", "Tripous.ResLib.Icons8_32x32.Icons8_IT_x86.png"},
            {"Keyboard", "Tripous.ResLib.Icons8_32x32.Icons8_keyboard.png"},
            {"Keyboard_Backspace", "Tripous.ResLib.Icons8_32x32.Icons8_Keyboard_backspace.png"},
            {"Keyboard_Enter", "Tripous.ResLib.Icons8_32x32.Icons8_Keyboard_enter.png"},
            {"Keyboard_Shift", "Tripous.ResLib.Icons8_32x32.Icons8_Keyboard_shift.png"},
            {"Kitchen_Banana_Split", "Tripous.ResLib.Icons8_32x32.Icons8_Kitchen_banana_split.png"},
            {"Kitchen_Beer_Bottle", "Tripous.ResLib.Icons8_32x32.Icons8_Kitchen_beer_bottle.png"},
            {"Kitchen_Beer_Glass", "Tripous.ResLib.Icons8_32x32.Icons8_Kitchen_beer_glass.png"},
            {"Kitchen_Birthday_Cake", "Tripous.ResLib.Icons8_32x32.Icons8_Kitchen_birthday_cake.png"},
            {"Kitchen_Bread", "Tripous.ResLib.Icons8_32x32.Icons8_Kitchen_bread.png"},
            {"Kitchen_Bunch_Ingredients", "Tripous.ResLib.Icons8_32x32.Icons8_Kitchen_bunch_ingredients.png"},
            {"Kitchen_Carrot", "Tripous.ResLib.Icons8_32x32.Icons8_Kitchen_carrot.png"},
            {"Kitchen_Cheese", "Tripous.ResLib.Icons8_32x32.Icons8_Kitchen_cheese.png"},
            {"Kitchen_Coctail", "Tripous.ResLib.Icons8_32x32.Icons8_Kitchen_coctail.png"},
            {"Kitchen_Coking_Pot", "Tripous.ResLib.Icons8_32x32.Icons8_Kitchen_coking_pot.png"},
            {"Kitchen_Cooker", "Tripous.ResLib.Icons8_32x32.Icons8_Kitchen_cooker.png"},
            {"Kitchen_Cooker_Hood", "Tripous.ResLib.Icons8_32x32.Icons8_Kitchen_cooker_hood.png"},
            {"Kitchen_Corkscrew", "Tripous.ResLib.Icons8_32x32.Icons8_Kitchen_corkscrew.png"},
            {"Kitchen_Cup", "Tripous.ResLib.Icons8_32x32.Icons8_Kitchen_cup.png"},
            {"Kitchen_Eggs", "Tripous.ResLib.Icons8_32x32.Icons8_Kitchen_eggs.png"},
            {"Kitchen_Fish", "Tripous.ResLib.Icons8_32x32.Icons8_Kitchen_fish.png"},
            {"Kitchen_Fork", "Tripous.ResLib.Icons8_32x32.Icons8_Kitchen_fork.png"},
            {"Kitchen_French_Fries", "Tripous.ResLib.Icons8_32x32.Icons8_Kitchen_french_fries.png"},
            {"Kitchen_Fridge", "Tripous.ResLib.Icons8_32x32.Icons8_Kitchen_fridge.png"},
            {"Kitchen_Hot_Dog", "Tripous.ResLib.Icons8_32x32.Icons8_Kitchen_hot_dog.png"},
            {"Kitchen_Humburger", "Tripous.ResLib.Icons8_32x32.Icons8_Kitchen_humburger.png"},
            {"Kitchen_Knife", "Tripous.ResLib.Icons8_32x32.Icons8_Kitchen_knife.png"},
            {"Kitchen_Ladle", "Tripous.ResLib.Icons8_32x32.Icons8_Kitchen_ladle.png"},
            {"Kitchen_List_Ingredients", "Tripous.ResLib.Icons8_32x32.Icons8_Kitchen_list_ingredients.png"},
            {"Kitchen_Microwave", "Tripous.ResLib.Icons8_32x32.Icons8_Kitchen_microwave.png"},
            {"Kitchen_Milk", "Tripous.ResLib.Icons8_32x32.Icons8_Kitchen_milk.png"},
            {"Kitchen_Mushroom", "Tripous.ResLib.Icons8_32x32.Icons8_Kitchen_mushroom.png"},
            {"Kitchen_Pepper_Shaker", "Tripous.ResLib.Icons8_32x32.Icons8_Kitchen_pepper_shaker.png"},
            {"Kitchen_Pizza", "Tripous.ResLib.Icons8_32x32.Icons8_Kitchen_pizza.png"},
            {"Kitchen_Salt_Shaker", "Tripous.ResLib.Icons8_32x32.Icons8_Kitchen_salt_shaker.png"},
            {"Kitchen_Shellfish", "Tripous.ResLib.Icons8_32x32.Icons8_Kitchen_shellfish.png"},
            {"Kitchen_Soda_Bottle", "Tripous.ResLib.Icons8_32x32.Icons8_Kitchen_soda_bottle.png"},
            {"Kitchen_Spoon", "Tripous.ResLib.Icons8_32x32.Icons8_Kitchen_spoon.png"},
            {"Kitchen_Taco", "Tripous.ResLib.Icons8_32x32.Icons8_Kitchen_taco.png"},
            {"Kitchen_Teapot", "Tripous.ResLib.Icons8_32x32.Icons8_Kitchen_teapot.png"},
            {"Kitchen_Wine_Bottle", "Tripous.ResLib.Icons8_32x32.Icons8_Kitchen_wine_bottle.png"},
            {"Kitchen_Wine_Glass", "Tripous.ResLib.Icons8_32x32.Icons8_Kitchen_wine_glass.png"},
            {"Logo_Accessibility1", "Tripous.ResLib.Icons8_32x32.Icons8_Logo_accessibility1.png"},
            {"Logo_Accessibility2", "Tripous.ResLib.Icons8_32x32.Icons8_Logo_accessibility2.png"},
            {"Logo_Cloudflare", "Tripous.ResLib.Icons8_32x32.Icons8_Logo_cloudflare.png"},
            {"Logo_Coderwall", "Tripous.ResLib.Icons8_32x32.Icons8_Logo_coderwall.png"},
            {"Logo_Dribbble", "Tripous.ResLib.Icons8_32x32.Icons8_Logo_dribbble.png"},
            {"Logo_Dropbox", "Tripous.ResLib.Icons8_32x32.Icons8_Logo_dropbox.png"},
            {"Logo_Forrst", "Tripous.ResLib.Icons8_32x32.Icons8_Logo_forrst.png"},
            {"Logo_Github", "Tripous.ResLib.Icons8_32x32.Icons8_Logo_github.png"},
            {"Logo_Instapaper", "Tripous.ResLib.Icons8_32x32.Icons8_Logo_instapaper.png"},
            {"Logo_Joomla", "Tripous.ResLib.Icons8_32x32.Icons8_Logo_Joomla.png"},
            {"Logo_Lego", "Tripous.ResLib.Icons8_32x32.Icons8_Logo_lego.png"},
            {"Logo_Maestro", "Tripous.ResLib.Icons8_32x32.Icons8_Logo_maestro.png"},
            {"Logo_Printerest", "Tripous.ResLib.Icons8_32x32.Icons8_Logo_printerest.png"},
            {"Logo_Python", "Tripous.ResLib.Icons8_32x32.Icons8_Logo_python.png"},
            {"Logo_Recycle_Sign", "Tripous.ResLib.Icons8_32x32.Icons8_Logo_recycle_sign.png"},
            {"Logo_Reddit", "Tripous.ResLib.Icons8_32x32.Icons8_Logo_reddit.png"},
            {"Logo_Soundcloud", "Tripous.ResLib.Icons8_32x32.Icons8_Logo_soundcloud.png"},
            {"Logo_Stachoverflow_Com", "Tripous.ResLib.Icons8_32x32.Icons8_Logo_stachoverflow_com.png"},
            {"Logo_Steam", "Tripous.ResLib.Icons8_32x32.Icons8_Logo_steam.png"},
            {"Logo_Stumbleupon", "Tripous.ResLib.Icons8_32x32.Icons8_Logo_stumbleupon.png"},
            {"Logo_Tumblr", "Tripous.ResLib.Icons8_32x32.Icons8_Logo_tumblr.png"},
            {"Logo_Utorrent", "Tripous.ResLib.Icons8_32x32.Icons8_Logo_utorrent.png"},
            {"Logo_Vlc", "Tripous.ResLib.Icons8_32x32.Icons8_Logo_vlc.png"},
            {"Logo_Wikipedia", "Tripous.ResLib.Icons8_32x32.Icons8_Logo_wikipedia.png"},
            {"Logo_Wolfram_Alpha", "Tripous.ResLib.Icons8_32x32.Icons8_Logo_wolfram_alpha.png"},
            {"Logo_Wordpress", "Tripous.ResLib.Icons8_32x32.Icons8_Logo_Wordpress.png"},
            {"Logo_Youtube", "Tripous.ResLib.Icons8_32x32.Icons8_Logo_youtube.png"},
            {"Management_Advertising", "Tripous.ResLib.Icons8_32x32.Icons8_Management_advertising.png"},
            {"Management_Archive", "Tripous.ResLib.Icons8_32x32.Icons8_Management_archive.png"},
            {"Management_Archive2", "Tripous.ResLib.Icons8_32x32.Icons8_Management_archive2.png"},
            {"Management_Billing", "Tripous.ResLib.Icons8_32x32.Icons8_Management_billing.png"},
            {"Management_Business_Contact", "Tripous.ResLib.Icons8_32x32.Icons8_Management_business_contact.png"},
            {"Management_Comments", "Tripous.ResLib.Icons8_32x32.Icons8_Management_comments.png"},
            {"Management_Library", "Tripous.ResLib.Icons8_32x32.Icons8_Management_library.png"},
            {"Management_Manager", "Tripous.ResLib.Icons8_32x32.Icons8_Management_manager.png"},
            {"Management_Online_Support", "Tripous.ResLib.Icons8_32x32.Icons8_Management_online_support.png"},
            {"Management_Statistics", "Tripous.ResLib.Icons8_32x32.Icons8_Management_statistics.png"},
            {"Mathematic_Divide", "Tripous.ResLib.Icons8_32x32.Icons8_Mathematic_divide.png"},
            {"Mathematic_Divide2", "Tripous.ResLib.Icons8_32x32.Icons8_Mathematic_divide2.png"},
            {"Mathematic_Equal_Sign", "Tripous.ResLib.Icons8_32x32.Icons8_Mathematic_equal_sign.png"},
            {"Mathematic_Equal_Sign2", "Tripous.ResLib.Icons8_32x32.Icons8_Mathematic_equal_sign2.png"},
            {"Mathematic_Minus", "Tripous.ResLib.Icons8_32x32.Icons8_Mathematic_minus.png"},
            {"Mathematic_Minus2", "Tripous.ResLib.Icons8_32x32.Icons8_Mathematic_minus2.png"},
            {"Mathematic_Multiply", "Tripous.ResLib.Icons8_32x32.Icons8_Mathematic_multiply.png"},
            {"Mathematic_Multiply2", "Tripous.ResLib.Icons8_32x32.Icons8_Mathematic_multiply2.png"},
            {"Mathematic_Percentage", "Tripous.ResLib.Icons8_32x32.Icons8_Mathematic_percentage.png"},
            {"Mathematic_Percentage2", "Tripous.ResLib.Icons8_32x32.Icons8_Mathematic_percentage2.png"},
            {"Mathematic_Plus", "Tripous.ResLib.Icons8_32x32.Icons8_Mathematic_plus.png"},
            {"Mathematic_Plus_Minus", "Tripous.ResLib.Icons8_32x32.Icons8_Mathematic_plus_minus.png"},
            {"Mathematic_Plus_Minus2", "Tripous.ResLib.Icons8_32x32.Icons8_Mathematic_plus_minus2.png"},
            {"Mathematic_Plus2", "Tripous.ResLib.Icons8_32x32.Icons8_Mathematic_plus2.png"},
            {"Mathematic_Square_Root", "Tripous.ResLib.Icons8_32x32.Icons8_Mathematic_square_root.png"},
            {"Mathematic_Square_Root2", "Tripous.ResLib.Icons8_32x32.Icons8_Mathematic_square_root2.png"},
            {"Media_Eject", "Tripous.ResLib.Icons8_32x32.Icons8_Media_eject.png"},
            {"Media_End", "Tripous.ResLib.Icons8_32x32.Icons8_Media_end.png"},
            {"Media_Fast_Forward", "Tripous.ResLib.Icons8_32x32.Icons8_Media_fast_forward.png"},
            {"Media_Pause", "Tripous.ResLib.Icons8_32x32.Icons8_Media_pause.png"},
            {"Media_Play", "Tripous.ResLib.Icons8_32x32.Icons8_Media_play.png"},
            {"Media_Record", "Tripous.ResLib.Icons8_32x32.Icons8_Media_record.png"},
            {"Media_Repeat", "Tripous.ResLib.Icons8_32x32.Icons8_Media_repeat.png"},
            {"Media_Rewind", "Tripous.ResLib.Icons8_32x32.Icons8_Media_rewind.png"},
            {"Media_Shuffle", "Tripous.ResLib.Icons8_32x32.Icons8_Media_shuffle.png"},
            {"Media_Skip_To_Start", "Tripous.ResLib.Icons8_32x32.Icons8_Media_skip_to_start.png"},
            {"Media_Stop", "Tripous.ResLib.Icons8_32x32.Icons8_Media_stop.png"},
            {"Medicine_Ambulance", "Tripous.ResLib.Icons8_32x32.Icons8_Medicine_ambulance.png"},
            {"Medicine_Amputee", "Tripous.ResLib.Icons8_32x32.Icons8_Medicine_amputee.png"},
            {"Medicine_Antiseptic_Cream", "Tripous.ResLib.Icons8_32x32.Icons8_Medicine_antiseptic_cream.png"},
            {"Medicine_Bandage", "Tripous.ResLib.Icons8_32x32.Icons8_Medicine_bandage.png"},
            {"Medicine_Brain", "Tripous.ResLib.Icons8_32x32.Icons8_Medicine_brain.png"},
            {"Medicine_Clinic", "Tripous.ResLib.Icons8_32x32.Icons8_Medicine_clinic.png"},
            {"Medicine_Doctor_Suitecase", "Tripous.ResLib.Icons8_32x32.Icons8_Medicine_doctor_suitecase.png"},
            {"Medicine_Foil_Space_Blanket", "Tripous.ResLib.Icons8_32x32.Icons8_Medicine_foil_space_blanket.png"},
            {"Medicine_Heart_Monitor", "Tripous.ResLib.Icons8_32x32.Icons8_Medicine_heart_monitor.png"},
            {"Medicine_Micropore_Tape", "Tripous.ResLib.Icons8_32x32.Icons8_Medicine_micropore_tape.png"},
            {"Medicine_Pill", "Tripous.ResLib.Icons8_32x32.Icons8_Medicine_pill.png"},
            {"Medicine_Pincette", "Tripous.ResLib.Icons8_32x32.Icons8_Medicine_pincette.png"},
            {"Medicine_Plaster", "Tripous.ResLib.Icons8_32x32.Icons8_Medicine_plaster.png"},
            {"Medicine_Safety_Pin", "Tripous.ResLib.Icons8_32x32.Icons8_Medicine_safety_pin.png"},
            {"Medicine_Scissors", "Tripous.ResLib.Icons8_32x32.Icons8_Medicine_scissors.png"},
            {"Medicine_Skeleton", "Tripous.ResLib.Icons8_32x32.Icons8_Medicine_skeleton.png"},
            {"Medicine_Stethoscope", "Tripous.ResLib.Icons8_32x32.Icons8_Medicine_stethoscope.png"},
            {"Medicine_Stomach", "Tripous.ResLib.Icons8_32x32.Icons8_Medicine_stomach.png"},
            {"Medicine_Syringe", "Tripous.ResLib.Icons8_32x32.Icons8_Medicine_syringe.png"},
            {"Medicine_Thermometer", "Tripous.ResLib.Icons8_32x32.Icons8_Medicine_thermometer.png"},
            {"Medicine_Triangular_Bandage", "Tripous.ResLib.Icons8_32x32.Icons8_Medicine_triangular_bandage.png"},
            {"Medicine_Wipes", "Tripous.ResLib.Icons8_32x32.Icons8_Medicine_wipes.png"},
            {"Medicine_Xray", "Tripous.ResLib.Icons8_32x32.Icons8_Medicine_xray.png"},
            {"Memory_Card_Micro_Sd", "Tripous.ResLib.Icons8_32x32.Icons8_Memory_Card_micro_sd.png"},
            {"Memory_Card_Sd", "Tripous.ResLib.Icons8_32x32.Icons8_Memory_Card_sd.png"},
            {"Memory_Card_Torrent", "Tripous.ResLib.Icons8_32x32.Icons8_Memory_Card_torrent.png"},
            {"Military_Ammo_Tin", "Tripous.ResLib.Icons8_32x32.Icons8_Military_ammo_tin.png"},
            {"Military_Backpack_Radio", "Tripous.ResLib.Icons8_32x32.Icons8_military_backpack_radio.png"},
            {"Military_Blunderbuss", "Tripous.ResLib.Icons8_32x32.Icons8_Military_blunderbuss.png"},
            {"Military_Bomb", "Tripous.ResLib.Icons8_32x32.Icons8_Military_bomb.png"},
            {"Military_Boots", "Tripous.ResLib.Icons8_32x32.Icons8_Military_boots.png"},
            {"Military_Camo_Cream", "Tripous.ResLib.Icons8_32x32.Icons8_Military_camo_cream.png"},
            {"Military_Cannon", "Tripous.ResLib.Icons8_32x32.Icons8_Military_cannon.png"},
            {"Military_Explosion", "Tripous.ResLib.Icons8_32x32.Icons8_Military_explosion.png"},
            {"Military_Flash_Bang", "Tripous.ResLib.Icons8_32x32.Icons8_Military_flash_bang.png"},
            {"Military_Gatling_Gun", "Tripous.ResLib.Icons8_32x32.Icons8_Military_gatling_gun.png"},
            {"Military_Grenade", "Tripous.ResLib.Icons8_32x32.Icons8_Military_grenade.png"},
            {"Military_Gun", "Tripous.ResLib.Icons8_32x32.Icons8_Military_gun.png"},
            {"Military_Helmet", "Tripous.ResLib.Icons8_32x32.Icons8_Military_helmet.png"},
            {"Military_Incendiary_Grenade", "Tripous.ResLib.Icons8_32x32.Icons8_Military_incendiary_grenade.png"},
            {"Military_Knife", "Tripous.ResLib.Icons8_32x32.Icons8_Military_knife.png"},
            {"Military_Magazin", "Tripous.ResLib.Icons8_32x32.Icons8_Military_magazin.png"},
            {"Military_Marine_Radio", "Tripous.ResLib.Icons8_32x32.Icons8_Military_marine_radio.png"},
            {"Military_Medal", "Tripous.ResLib.Icons8_32x32.Icons8_Military_medal.png"},
            {"Military_Missile", "Tripous.ResLib.Icons8_32x32.Icons8_Military_missile.png"},
            {"Military_Mortar", "Tripous.ResLib.Icons8_32x32.Icons8_Military_mortar.png"},
            {"Military_Mushroom_Cloud", "Tripous.ResLib.Icons8_32x32.Icons8_Military_mushroom_cloud.png"},
            {"Military_Nightvision", "Tripous.ResLib.Icons8_32x32.Icons8_Military_nightvision.png"},
            {"Military_Rifle", "Tripous.ResLib.Icons8_32x32.Icons8_Military_rifle.png"},
            {"Military_Rpg", "Tripous.ResLib.Icons8_32x32.Icons8_Military_rpg.png"},
            {"Military_Rucksach", "Tripous.ResLib.Icons8_32x32.Icons8_Military_rucksach.png"},
            {"Military_Self_Distract_Button", "Tripous.ResLib.Icons8_32x32.Icons8_Military_self_distract_button.png"},
            {"Military_Service_Air_Force", "Tripous.ResLib.Icons8_32x32.Icons8_Military_Service_air_force.png"},
            {"Military_Service_British_Army", "Tripous.ResLib.Icons8_32x32.Icons8_Military_Service_british-army.png"},
            {"Military_Service_Royal_Marines", "Tripous.ResLib.Icons8_32x32.Icons8_Military_Service_royal_marines.png"},
            {"Military_Service_Royal_Navy", "Tripous.ResLib.Icons8_32x32.Icons8_Military_Service_royal_navy.png"},
            {"Military_Smoke_Explosion", "Tripous.ResLib.Icons8_32x32.Icons8_Military_smoke_explosion.png"},
            {"Military_Sniper_Rifle", "Tripous.ResLib.Icons8_32x32.Icons8_Military_sniper_rifle.png"},
            {"Military_Tent", "Tripous.ResLib.Icons8_32x32.Icons8_Military_tent.png"},
            {"Military_Walkie_Talkie_Radio", "Tripous.ResLib.Icons8_32x32.Icons8_Military_walkie_talkie_radio.png"},
            {"Military_Webbing", "Tripous.ResLib.Icons8_32x32.Icons8_Military_webbing.png"},
            {"Miscs_Conference", "Tripous.ResLib.Icons8_32x32.Icons8_Miscs_conference.png"},
            {"Miscs_Paper", "Tripous.ResLib.Icons8_32x32.Icons8_Miscs_paper.png"},
            {"Miscs_Rock", "Tripous.ResLib.Icons8_32x32.Icons8_Miscs_rock.png"},
            {"Miscs_Scissors", "Tripous.ResLib.Icons8_32x32.Icons8_Miscs_scissors.png"},
            {"Movie_Genre_Action", "Tripous.ResLib.Icons8_32x32.Icons8_Movie_Genre_action.png"},
            {"Movie_Genre_Actions2", "Tripous.ResLib.Icons8_32x32.Icons8_Movie_Genre_actions2.png"},
            {"Movie_Genre_Adventures", "Tripous.ResLib.Icons8_32x32.Icons8_Movie_Genre_adventures.png"},
            {"Movie_Genre_Comedy", "Tripous.ResLib.Icons8_32x32.Icons8_Movie_Genre_comedy.png"},
            {"Movie_Genre_Comedy2", "Tripous.ResLib.Icons8_32x32.Icons8_Movie_Genre_comedy2.png"},
            {"Movie_Genre_Crime", "Tripous.ResLib.Icons8_32x32.Icons8_Movie_Genre_crime.png"},
            {"Movie_Genre_Detective", "Tripous.ResLib.Icons8_32x32.Icons8_Movie_Genre_detective.png"},
            {"Movie_Genre_Documentary", "Tripous.ResLib.Icons8_32x32.Icons8_Movie_Genre_documentary.png"},
            {"Movie_Genre_Drama", "Tripous.ResLib.Icons8_32x32.Icons8_Movie_Genre_drama.png"},
            {"Movie_Genre_Erotic_Bottom", "Tripous.ResLib.Icons8_32x32.Icons8_Movie_Genre_erotic_bottom.png"},
            {"Movie_Genre_Erotic_Breast", "Tripous.ResLib.Icons8_32x32.Icons8_Movie_Genre_erotic_breast.png"},
            {"Movie_Genre_Fantasy", "Tripous.ResLib.Icons8_32x32.Icons8_Movie_Genre_fantasy.png"},
            {"Movie_Genre_Historical", "Tripous.ResLib.Icons8_32x32.Icons8_Movie_Genre_historical.png"},
            {"Movie_Genre_Horror", "Tripous.ResLib.Icons8_32x32.Icons8_Movie_Genre_horror.png"},
            {"Movie_Genre_Music", "Tripous.ResLib.Icons8_32x32.Icons8_Movie_Genre_music.png"},
            {"Movie_Genre_Novel", "Tripous.ResLib.Icons8_32x32.Icons8_Movie_Genre_novel.png"},
            {"Movie_Genre_Sci_Fi", "Tripous.ResLib.Icons8_32x32.Icons8_Movie_Genre_sci_fi.png"},
            {"Movie_Genre_Sport", "Tripous.ResLib.Icons8_32x32.Icons8_Movie_Genre_sport.png"},
            {"Movie_Genre_Triller", "Tripous.ResLib.Icons8_32x32.Icons8_Movie_Genre_triller.png"},
            {"Movie_Genre_Western", "Tripous.ResLib.Icons8_32x32.Icons8_Movie_Genre_western.png"},
            {"MS_Office_Excel", "Tripous.ResLib.Icons8_32x32.Icons8_MS_Office_excel.png"},
            {"MS_Office_Novel", "Tripous.ResLib.Icons8_32x32.Icons8_MS_Office_novel.png"},
            {"MS_Office_One_Note", "Tripous.ResLib.Icons8_32x32.Icons8_MS_Office_one_note.png"},
            {"MS_Office_Outlook", "Tripous.ResLib.Icons8_32x32.Icons8_MS_Office_outlook.png"},
            {"MS_Office_Powerpoint", "Tripous.ResLib.Icons8_32x32.Icons8_MS_Office_powerpoint.png"},
            {"MS_Office_Publisher", "Tripous.ResLib.Icons8_32x32.Icons8_MS_Office_publisher.png"},
            {"MS_Office_Share_Point", "Tripous.ResLib.Icons8_32x32.Icons8_MS_Office_share_point.png"},
            {"MS_Office_Word", "Tripous.ResLib.Icons8_32x32.Icons8_MS_Office_word.png"},
            {"MU_Degrees", "Tripous.ResLib.Icons8_32x32.Icons8_MU_degrees.png"},
            {"MU_Length", "Tripous.ResLib.Icons8_32x32.Icons8_MU_length.png"},
            {"MU_Pressure", "Tripous.ResLib.Icons8_32x32.Icons8_MU_pressure.png"},
            {"MU_Speed", "Tripous.ResLib.Icons8_32x32.Icons8_MU_speed.png"},
            {"MU_Surface", "Tripous.ResLib.Icons8_32x32.Icons8_MU_surface.png"},
            {"MU_Temperature", "Tripous.ResLib.Icons8_32x32.Icons8_MU_temperature.png"},
            {"MU_Time", "Tripous.ResLib.Icons8_32x32.Icons8_MU_time.png"},
            {"MU_Volume", "Tripous.ResLib.Icons8_32x32.Icons8_MU_volume.png"},
            {"MU_Weight", "Tripous.ResLib.Icons8_32x32.Icons8_MU_weight.png"},
            {"Music_Alto_Saxophone", "Tripous.ResLib.Icons8_32x32.Icons8_Music_alto_saxophone.png"},
            {"Music_Applouse", "Tripous.ResLib.Icons8_32x32.Icons8_Music_applouse.png"},
            {"Music_Audio_Wave", "Tripous.ResLib.Icons8_32x32.Icons8_Music_audio_wave.png"},
            {"Music_Audio_Wave2", "Tripous.ResLib.Icons8_32x32.Icons8_Music_audio_wave2.png"},
            {"Music_Autograf", "Tripous.ResLib.Icons8_32x32.Icons8_Music_autograf.png"},
            {"Music_Bandmasters_Mace", "Tripous.ResLib.Icons8_32x32.Icons8_Music_bandmasters_mace.png"},
            {"Music_Bass_Drum", "Tripous.ResLib.Icons8_32x32.Icons8_Music_bass_drum.png"},
            {"Music_Bell_Lyre", "Tripous.ResLib.Icons8_32x32.Icons8_Music_bell_lyre.png"},
            {"Music_Boombox", "Tripous.ResLib.Icons8_32x32.Icons8_Music_boombox.png"},
            {"Music_Bugle", "Tripous.ResLib.Icons8_32x32.Icons8_Music_bugle.png"},
            {"Music_Clarnet", "Tripous.ResLib.Icons8_32x32.Icons8_Music_clarnet.png"},
            {"Music_Conduktor", "Tripous.ResLib.Icons8_32x32.Icons8_music_conduktor.png"},
            {"Music_Cornet", "Tripous.ResLib.Icons8_32x32.Icons8_Music_cornet.png"},
            {"Music_Cymbals", "Tripous.ResLib.Icons8_32x32.Icons8_Music_cymbals.png"},
            {"Music_Dj", "Tripous.ResLib.Icons8_32x32.Icons8_Music_dj.png"},
            {"Music_French_Horn", "Tripous.ResLib.Icons8_32x32.Icons8_Music_french_horn.png"},
            {"Music_Guitar", "Tripous.ResLib.Icons8_32x32.Icons8_Music_guitar.png"},
            {"Music_Herald_Trumpet", "Tripous.ResLib.Icons8_32x32.Icons8_Music_herald_trumpet.png"},
            {"Music_Loudspeaker", "Tripous.ResLib.Icons8_32x32.Icons8_Music_loudspeaker.png"},
            {"Music_Microphone", "Tripous.ResLib.Icons8_32x32.Icons8_Music_microphone.png"},
            {"Music_Microphone2", "Tripous.ResLib.Icons8_32x32.Icons8_Music_microphone2.png"},
            {"Music_Note", "Tripous.ResLib.Icons8_32x32.Icons8_Music_note.png"},
            {"Music_Piccolo", "Tripous.ResLib.Icons8_32x32.Icons8_Music_piccolo.png"},
            {"Music_Radio1", "Tripous.ResLib.Icons8_32x32.Icons8_Music_radio1.png"},
            {"Music_Radio2", "Tripous.ResLib.Icons8_32x32.Icons8_Music_radio2.png"},
            {"Music_Record", "Tripous.ResLib.Icons8_32x32.Icons8_music_record.png"},
            {"Music_Saxophone", "Tripous.ResLib.Icons8_32x32.Icons8_Music_saxophone.png"},
            {"Music_Side_Drum", "Tripous.ResLib.Icons8_32x32.Icons8_Music_side_drum.png"},
            {"Music_Trambone", "Tripous.ResLib.Icons8_32x32.Icons8_Music_trambone.png"},
            {"Music_Treble_Clef", "Tripous.ResLib.Icons8_32x32.Icons8_Music_treble_clef.png"},
            {"Music_Trumpet", "Tripous.ResLib.Icons8_32x32.Icons8_Music_trumpet.png"},
            {"Music_Tuba", "Tripous.ResLib.Icons8_32x32.Icons8_Music_tuba.png"},
            {"Music_Violin", "Tripous.ResLib.Icons8_32x32.Icons8_Music_violin.png"},
            {"Music_Xylophone", "Tripous.ResLib.Icons8_32x32.Icons8_Music_xylophone.png"},
            {"Network_High_Connection", "Tripous.ResLib.Icons8_32x32.Icons8_Network_high_connection.png"},
            {"Network_Low_Connection", "Tripous.ResLib.Icons8_32x32.Icons8_Network_low_connection.png"},
            {"Network_Medium_Connection", "Tripous.ResLib.Icons8_32x32.Icons8_Network_medium_connection.png"},
            {"Network_No_Connection", "Tripous.ResLib.Icons8_32x32.Icons8_Network_no_connection.png"},
            {"Nui1", "Tripous.ResLib.Icons8_32x32.Icons8_nui1.png"},
            {"Nui2", "Tripous.ResLib.Icons8_32x32.Icons8_nui2.png"},
            {"Number_0", "Tripous.ResLib.Icons8_32x32.Icons8_Number_0.png"},
            {"Number_0_Filled", "Tripous.ResLib.Icons8_32x32.Icons8_Number_0_filled.png"},
            {"Number_1", "Tripous.ResLib.Icons8_32x32.Icons8_Number_1.png"},
            {"Number_1_Filled", "Tripous.ResLib.Icons8_32x32.Icons8_Number_1_filled.png"},
            {"Number_2", "Tripous.ResLib.Icons8_32x32.Icons8_Number_2.png"},
            {"Number_2_Filled", "Tripous.ResLib.Icons8_32x32.Icons8_Number_2_filled.png"},
            {"Number_3", "Tripous.ResLib.Icons8_32x32.Icons8_Number_3.png"},
            {"Number_3_Filled", "Tripous.ResLib.Icons8_32x32.Icons8_Number_3_filled.png"},
            {"Number_4", "Tripous.ResLib.Icons8_32x32.Icons8_Number_4.png"},
            {"Number_4_Filled", "Tripous.ResLib.Icons8_32x32.Icons8_Number_4_filled.png"},
            {"Number_5", "Tripous.ResLib.Icons8_32x32.Icons8_Number_5.png"},
            {"Number_5_Filled", "Tripous.ResLib.Icons8_32x32.Icons8_Number_5_filled.png"},
            {"Number_6", "Tripous.ResLib.Icons8_32x32.Icons8_Number_6.png"},
            {"Number_6_Filled", "Tripous.ResLib.Icons8_32x32.Icons8_Number_6_filled.png"},
            {"Number_7", "Tripous.ResLib.Icons8_32x32.Icons8_Number_7.png"},
            {"Number_7_Filled", "Tripous.ResLib.Icons8_32x32.Icons8_Number_7_filled.png"},
            {"Number_8", "Tripous.ResLib.Icons8_32x32.Icons8_Number_8.png"},
            {"Number_8_Filled", "Tripous.ResLib.Icons8_32x32.Icons8_Number_8_filled.png"},
            {"Number_9", "Tripous.ResLib.Icons8_32x32.Icons8_Number_9.png"},
            {"Number_9_Filled", "Tripous.ResLib.Icons8_32x32.Icons8_Number_9_filled.png"},
            {"Object_Box", "Tripous.ResLib.Icons8_32x32.Icons8_Object_box.png"},
            {"Object_Burn_Cd", "Tripous.ResLib.Icons8_32x32.Icons8_Object_burn_cd.png"},
            {"Object_Empty_Filter", "Tripous.ResLib.Icons8_32x32.Icons8_Object_empty_filter.png"},
            {"Object_Female", "Tripous.ResLib.Icons8_32x32.Icons8_Object_female.png"},
            {"Object_Filing_Cabinet", "Tripous.ResLib.Icons8_32x32.Icons8_Object_filing_cabinet.png"},
            {"Object_Filled_Filter", "Tripous.ResLib.Icons8_32x32.Icons8_Object_filled_filter.png"},
            {"Object_Hot_Articcle", "Tripous.ResLib.Icons8_32x32.Icons8_Object_hot_articcle.png"},
            {"Object_Joystick", "Tripous.ResLib.Icons8_32x32.Icons8_Object_joystick.png"},
            {"Object_Lifebuoy", "Tripous.ResLib.Icons8_32x32.Icons8_Object_lifebuoy.png"},
            {"Object_Male", "Tripous.ResLib.Icons8_32x32.Icons8_Object_male.png"},
            {"Object_Megafone1", "Tripous.ResLib.Icons8_32x32.Icons8_Object_megafone1.png"},
            {"Object_Megafone2", "Tripous.ResLib.Icons8_32x32.Icons8_Object_megafone2.png"},
            {"Object_No_Smoking", "Tripous.ResLib.Icons8_32x32.Icons8_Object_no_smoking.png"},
            {"Object_Note", "Tripous.ResLib.Icons8_32x32.Icons8_Object_note.png"},
            {"Object_Paper_Plane", "Tripous.ResLib.Icons8_32x32.Icons8_Object_paper_plane.png"},
            {"Object_Phone1", "Tripous.ResLib.Icons8_32x32.Icons8_Object_phone1.png"},
            {"Object_Phone2", "Tripous.ResLib.Icons8_32x32.Icons8_Object_phone2.png"},
            {"Object_Plugin", "Tripous.ResLib.Icons8_32x32.Icons8_Object_plugin.png"},
            {"Object_Pocket_Lantern", "Tripous.ResLib.Icons8_32x32.Icons8_Object_pocket_lantern.png"},
            {"Object_Poo", "Tripous.ResLib.Icons8_32x32.Icons8_Object_poo.png"},
            {"Object_Rocket", "Tripous.ResLib.Icons8_32x32.Icons8_Object_rocket.png"},
            {"Object_Running_Man", "Tripous.ResLib.Icons8_32x32.Icons8_Object_running_man.png"},
            {"Object_Sandglass", "Tripous.ResLib.Icons8_32x32.Icons8_Object_sandglass.png"},
            {"Object_Scale", "Tripous.ResLib.Icons8_32x32.Icons8_Object_scale.png"},
            {"Object_Scales", "Tripous.ResLib.Icons8_32x32.Icons8_Object_scales.png"},
            {"Object_Signal_Horn", "Tripous.ResLib.Icons8_32x32.Icons8_Object_signal_horn.png"},
            {"Object_Smoking", "Tripous.ResLib.Icons8_32x32.Icons8_Object_smoking.png"},
            {"Object_Software_Box", "Tripous.ResLib.Icons8_32x32.Icons8_Object_software_box.png"},
            {"Object_Switch_Off", "Tripous.ResLib.Icons8_32x32.Icons8_Object_switch_off.png"},
            {"Object_Switch_On", "Tripous.ResLib.Icons8_32x32.Icons8_Object_switch_on.png"},
            {"Object_Tear_Of_Calendar", "Tripous.ResLib.Icons8_32x32.Icons8_Object_tear_of_calendar.png"},
            {"Object_Timer", "Tripous.ResLib.Icons8_32x32.Icons8_Object_timer.png"},
            {"Object_Umbrella", "Tripous.ResLib.Icons8_32x32.Icons8_Object_umbrella.png"},
            {"Office_3D_Printer", "Tripous.ResLib.Icons8_32x32.Icons8_Office_3d_printer.png"},
            {"Office_Cnc_Machine", "Tripous.ResLib.Icons8_32x32.Icons8_Office_cnc_machine.png"},
            {"Office_Phone", "Tripous.ResLib.Icons8_32x32.Icons8_Office_phone.png"},
            {"Office_Planner", "Tripous.ResLib.Icons8_32x32.Icons8_Office_planner.png"},
            {"Office_Printer", "Tripous.ResLib.Icons8_32x32.Icons8_Office_printer.png"},
            {"Office_Tool_Box", "Tripous.ResLib.Icons8_32x32.Icons8_Office_tool_box.png"},
            {"Office_Video_Projector", "Tripous.ResLib.Icons8_32x32.Icons8_Office_video_projector.png"},
            {"Office_Wired_Network", "Tripous.ResLib.Icons8_32x32.Icons8_Office_wired_network.png"},
            {"OS_Be_Os", "Tripous.ResLib.Icons8_32x32.Icons8_OS_be_os.png"},
            {"OS_Dos", "Tripous.ResLib.Icons8_32x32.Icons8_OS_dos.png"},
            {"OS_Free_Bsd", "Tripous.ResLib.Icons8_32x32.Icons8_OS_free_bsd.png"},
            {"OS_Haiku", "Tripous.ResLib.Icons8_32x32.Icons8_OS_haiku.png"},
            {"OS_Linux", "Tripous.ResLib.Icons8_32x32.Icons8_OS_linux.png"},
            {"OS_Mac_Os", "Tripous.ResLib.Icons8_32x32.Icons8_OS_mac_os.png"},
            {"OS_Unix", "Tripous.ResLib.Icons8_32x32.Icons8_OS_unix.png"},
            {"OS_Windows", "Tripous.ResLib.Icons8_32x32.Icons8_OS_windows.png"},
            {"OS_Windows8", "Tripous.ResLib.Icons8_32x32.Icons8_OS_windows8.png"},
            {"Os2", "Tripous.ResLib.Icons8_32x32.Icons8_os2.png"},
            {"Page_1", "Tripous.ResLib.Icons8_32x32.Icons8_Page_1.png"},
            {"Page_2", "Tripous.ResLib.Icons8_32x32.Icons8_Page_2.png"},
            {"Page_3", "Tripous.ResLib.Icons8_32x32.Icons8_Page_3.png"},
            {"Page_4", "Tripous.ResLib.Icons8_32x32.Icons8_Page_4.png"},
            {"Pager_First", "Tripous.ResLib.Icons8_32x32.Icons8_Pager_first.png"},
            {"Pager_Last", "Tripous.ResLib.Icons8_32x32.Icons8_Pager_last.png"},
            {"Pager_Next", "Tripous.ResLib.Icons8_32x32.Icons8_Pager_next.png"},
            {"Pager_Previous", "Tripous.ResLib.Icons8_32x32.Icons8_Pager_previous.png"},
            {"Payment_Method_Amex", "Tripous.ResLib.Icons8_32x32.Icons8_Payment_Method_amex.png"},
            {"Payment_Method_Bank_Cards", "Tripous.ResLib.Icons8_32x32.Icons8_Payment_Method_bank_cards.png"},
            {"Payment_Method_Banknotes", "Tripous.ResLib.Icons8_32x32.Icons8_Payment_Method_banknotes.png"},
            {"Payment_Method_Barcode", "Tripous.ResLib.Icons8_32x32.Icons8_Payment_Method_barcode.png"},
            {"Payment_Method_Card_In_Use", "Tripous.ResLib.Icons8_32x32.Icons8_Payment_Method_card_in_use.png"},
            {"Payment_Method_Card_Inserting", "Tripous.ResLib.Icons8_32x32.Icons8_Payment_Method_card_inserting.png"},
            {"Payment_Method_Cash_Receiving", "Tripous.ResLib.Icons8_32x32.Icons8_Payment_Method_cash_receiving.png"},
            {"Payment_Method_Check_Book", "Tripous.ResLib.Icons8_32x32.Icons8_Payment_Method_check_book.png"},
            {"Payment_Method_Coins", "Tripous.ResLib.Icons8_32x32.Icons8_Payment_Method_coins.png"},
            {"Payment_Method_Jcb", "Tripous.ResLib.Icons8_32x32.Icons8_Payment_Method_jcb.png"},
            {"Payment_Method_Mastercard", "Tripous.ResLib.Icons8_32x32.Icons8_Payment_Method_mastercard.png"},
            {"Payment_Method_Moneybox", "Tripous.ResLib.Icons8_32x32.Icons8_Payment_Method_moneybox.png"},
            {"Payment_Method_Purse", "Tripous.ResLib.Icons8_32x32.Icons8_Payment_Method_purse.png"},
            {"Payment_Method_Shopping_Basket", "Tripous.ResLib.Icons8_32x32.Icons8_Payment_Method_shopping_basket.png"},
            {"Payment_Method_Visa", "Tripous.ResLib.Icons8_32x32.Icons8_Payment_Method_visa.png"},
            {"Payment_Method_Wallet", "Tripous.ResLib.Icons8_32x32.Icons8_Payment_Method_wallet.png"},
            {"Pet_Bird", "Tripous.ResLib.Icons8_32x32.Icons8_Pet_bird.png"},
            {"Pet_Cat", "Tripous.ResLib.Icons8_32x32.Icons8_Pet_cat.png"},
            {"Pet_Dog", "Tripous.ResLib.Icons8_32x32.Icons8_Pet_dog.png"},
            {"Pet_Fish", "Tripous.ResLib.Icons8_32x32.Icons8_Pet_fish.png"},
            {"Pet_Rabbit", "Tripous.ResLib.Icons8_32x32.Icons8_Pet_rabbit.png"},
            {"Phone_Call_Transfer", "Tripous.ResLib.Icons8_32x32.Icons8_Phone_call_transfer.png"},
            {"Phone_Conference_Call", "Tripous.ResLib.Icons8_32x32.Icons8_Phone_conference_call.png"},
            {"Phone_Dnd", "Tripous.ResLib.Icons8_32x32.Icons8_Phone_dnd.png"},
            {"Phone_Headset", "Tripous.ResLib.Icons8_32x32.Icons8_Phone_headset.png"},
            {"Phone_Missed_Call", "Tripous.ResLib.Icons8_32x32.Icons8_Phone_missed_call.png"},
            {"Phone_Speaker", "Tripous.ResLib.Icons8_32x32.Icons8_Phone_speaker.png"},
            {"Phone_Video_Call", "Tripous.ResLib.Icons8_32x32.Icons8_Phone_video_call.png"},
            {"Photo_Video_Add_Image", "Tripous.ResLib.Icons8_32x32.Icons8_Photo_Video_add_image.png"},
            {"Photo_Video_Camcoder", "Tripous.ResLib.Icons8_32x32.Icons8_Photo_Video_camcoder.png"},
            {"Photo_Video_Camcoder_Pro", "Tripous.ResLib.Icons8_32x32.Icons8_Photo_Video_camcoder_pro.png"},
            {"Photo_Video_Clapperboard", "Tripous.ResLib.Icons8_32x32.Icons8_Photo_Video_clapperboard.png"},
            {"Photo_Video_Compact_Camera", "Tripous.ResLib.Icons8_32x32.Icons8_Photo_Video_compact_camera.png"},
            {"Photo_Video_Edit_Image", "Tripous.ResLib.Icons8_32x32.Icons8_Photo_Video_edit_image.png"},
            {"Photo_Video_Film", "Tripous.ResLib.Icons8_32x32.Icons8_Photo_Video_film.png"},
            {"Photo_Video_Film_Reel", "Tripous.ResLib.Icons8_32x32.Icons8_Photo_Video_film_reel.png"},
            {"Photo_Video_Film2", "Tripous.ResLib.Icons8_32x32.Icons8_Photo_Video_film2.png"},
            {"Photo_Video_Gallery", "Tripous.ResLib.Icons8_32x32.Icons8_Photo_Video_gallery.png"},
            {"Photo_Video_Integrated_Webcam", "Tripous.ResLib.Icons8_32x32.Icons8_Photo_Video_integrated_webcam.png"},
            {"Photo_Video_Old_Time_Camera", "Tripous.ResLib.Icons8_32x32.Icons8_Photo_Video_old_time_camera.png"},
            {"Photo_Video_Remove_Image", "Tripous.ResLib.Icons8_32x32.Icons8_Photo_Video_remove_image.png"},
            {"Photo_Video_Slr_Camera", "Tripous.ResLib.Icons8_32x32.Icons8_Photo_Video_slr_camera.png"},
            {"Photo_Video_Slr_Camera2", "Tripous.ResLib.Icons8_32x32.Icons8_Photo_Video_slr_camera2.png"},
            {"Photo_Video_Stack_Of_Photos", "Tripous.ResLib.Icons8_32x32.Icons8_Photo_Video_stack_of_photos.png"},
            {"Photo_Video_Start", "Tripous.ResLib.Icons8_32x32.Icons8_Photo_Video_start.png"},
            {"Photo_Video_Webcam", "Tripous.ResLib.Icons8_32x32.Icons8_Photo_Video_webcam.png"},
            {"Plants_Barley", "Tripous.ResLib.Icons8_32x32.Icons8_Plants_barley.png"},
            {"Plants_Berry", "Tripous.ResLib.Icons8_32x32.Icons8_Plants_berry.png"},
            {"Plants_Citrus", "Tripous.ResLib.Icons8_32x32.Icons8_Plants_citrus.png"},
            {"Plants_Coniferous_Tree", "Tripous.ResLib.Icons8_32x32.Icons8_Plants_coniferous_tree.png"},
            {"Plants_Deciduous_Tree", "Tripous.ResLib.Icons8_32x32.Icons8_Plants_deciduous_tree.png"},
            {"Plants_Flower", "Tripous.ResLib.Icons8_32x32.Icons8_Plants_flower.png"},
            {"Plants_Grapes", "Tripous.ResLib.Icons8_32x32.Icons8_Plants_grapes.png"},
            {"Plants_Grass", "Tripous.ResLib.Icons8_32x32.Icons8_Plants_grass.png"},
            {"Plants_Hazelnut", "Tripous.ResLib.Icons8_32x32.Icons8_Plants_hazelnut.png"},
            {"Plants_Hops", "Tripous.ResLib.Icons8_32x32.Icons8_Plants_hops.png"},
            {"Plants_Leaf", "Tripous.ResLib.Icons8_32x32.Icons8_Plants_leaf.png"},
            {"Plants_Leaf2", "Tripous.ResLib.Icons8_32x32.Icons8_Plants_leaf2.png"},
            {"Plants_Leaf3", "Tripous.ResLib.Icons8_32x32.Icons8_Plants_leaf3.png"},
            {"Plants_Nut", "Tripous.ResLib.Icons8_32x32.Icons8_Plants_nut.png"},
            {"Plants_Palm_Tree", "Tripous.ResLib.Icons8_32x32.Icons8_Plants_palm_tree.png"},
            {"Plants_Peanuts", "Tripous.ResLib.Icons8_32x32.Icons8_Plants_peanuts.png"},
            {"Plants_Soy", "Tripous.ResLib.Icons8_32x32.Icons8_Plants_soy.png"},
            {"Plants_Tomato", "Tripous.ResLib.Icons8_32x32.Icons8_Plants_tomato.png"},
            {"Plants_Wheat", "Tripous.ResLib.Icons8_32x32.Icons8_Plants_wheat.png"},
            {"Power_Button_Hibernate", "Tripous.ResLib.Icons8_32x32.Icons8_Power_Button_hibernate.png"},
            {"Power_Button_Restart", "Tripous.ResLib.Icons8_32x32.Icons8_Power_Button_restart.png"},
            {"Power_Button_Shutdown", "Tripous.ResLib.Icons8_32x32.Icons8_Power_Button_shutdown.png"},
            {"Power_Button_Sleep", "Tripous.ResLib.Icons8_32x32.Icons8_Power_Button_sleep.png"},
            {"Print_Preview_Fit_To_Width", "Tripous.ResLib.Icons8_32x32.Icons8_Print_Preview_fit_to_width.png"},
            {"Print_Preview_One_Page", "Tripous.ResLib.Icons8_32x32.Icons8_Print_Preview_one_page.png"},
            {"Print_Preview_Two_Page", "Tripous.ResLib.Icons8_32x32.Icons8_Print_Preview_two_page.png"},
            {"Printed_Matter_Book", "Tripous.ResLib.Icons8_32x32.Icons8_Printed_Matter_book.png"},
            {"Printed_Matter_Book_Stack", "Tripous.ResLib.Icons8_32x32.Icons8_Printed_Matter_book_stack.png"},
            {"Printed_Matter_Books", "Tripous.ResLib.Icons8_32x32.Icons8_Printed_Matter_books.png"},
            {"Printed_Matter_Magazine", "Tripous.ResLib.Icons8_32x32.Icons8_Printed_Matter_magazine.png"},
            {"Printed_Matter_Newspaper", "Tripous.ResLib.Icons8_32x32.Icons8_Printed_Matter_newspaper.png"},
            {"Repair_Drill", "Tripous.ResLib.Icons8_32x32.Icons8_Repair_drill.png"},
            {"Repair_Hammer", "Tripous.ResLib.Icons8_32x32.Icons8_Repair_hammer.png"},
            {"Repair_Nail", "Tripous.ResLib.Icons8_32x32.Icons8_Repair_nail.png"},
            {"Repair_Paint_Brush", "Tripous.ResLib.Icons8_32x32.Icons8_Repair_paint_brush.png"},
            {"Repair_Paint_Bucket", "Tripous.ResLib.Icons8_32x32.Icons8_Repair_paint_bucket.png"},
            {"Repair_Screw", "Tripous.ResLib.Icons8_32x32.Icons8_Repair_screw.png"},
            {"Repair_Screwdriver", "Tripous.ResLib.Icons8_32x32.Icons8_Repair_screwdriver.png"},
            {"Repair_Tape_Measure", "Tripous.ResLib.Icons8_32x32.Icons8_Repair_tape_measure.png"},
            {"Repair_Wallpaper_Roll", "Tripous.ResLib.Icons8_32x32.Icons8_Repair_wallpaper_roll.png"},
            {"Scheduler_Date_From", "Tripous.ResLib.Icons8_32x32.Icons8_Scheduler_date_from.png"},
            {"Scheduler_Date_To", "Tripous.ResLib.Icons8_32x32.Icons8_Scheduler_date_to.png"},
            {"Scheduler_Day_View", "Tripous.ResLib.Icons8_32x32.Icons8_Scheduler_day_view.png"},
            {"Scheduler_Gantt_Chart", "Tripous.ResLib.Icons8_32x32.Icons8_Scheduler_gantt_chart.png"},
            {"Scheduler_Grid", "Tripous.ResLib.Icons8_32x32.Icons8_Scheduler_grid.png"},
            {"Scheduler_List", "Tripous.ResLib.Icons8_32x32.Icons8_Scheduler_list.png"},
            {"Scheduler_Month_View", "Tripous.ResLib.Icons8_32x32.Icons8_Scheduler_month_view.png"},
            {"Scheduler_Timeline", "Tripous.ResLib.Icons8_32x32.Icons8_Scheduler_timeline.png"},
            {"Scheduler_Today", "Tripous.ResLib.Icons8_32x32.Icons8_Scheduler_today.png"},
            {"Scheduler_Week_View", "Tripous.ResLib.Icons8_32x32.Icons8_Scheduler_week_view.png"},
            {"Science_Business", "Tripous.ResLib.Icons8_32x32.Icons8_Science_business.png"},
            {"Science_Dna_Helix", "Tripous.ResLib.Icons8_32x32.Icons8_Science_dna_helix.png"},
            {"Science_Geography", "Tripous.ResLib.Icons8_32x32.Icons8_Science_geography.png"},
            {"Science_Geometry", "Tripous.ResLib.Icons8_32x32.Icons8_Science_geometry.png"},
            {"Science_Informatics", "Tripous.ResLib.Icons8_32x32.Icons8_Science_informatics.png"},
            {"Science_Law", "Tripous.ResLib.Icons8_32x32.Icons8_Science_law.png"},
            {"Science_Literature", "Tripous.ResLib.Icons8_32x32.Icons8_Science_literature.png"},
            {"Science_Math", "Tripous.ResLib.Icons8_32x32.Icons8_Science_math.png"},
            {"Science_Physics", "Tripous.ResLib.Icons8_32x32.Icons8_Science_physics.png"},
            {"Science_Plasmid", "Tripous.ResLib.Icons8_32x32.Icons8_Science_plasmid.png"},
            {"Science_Psyhology", "Tripous.ResLib.Icons8_32x32.Icons8_Science_psyhology.png"},
            {"Science_School", "Tripous.ResLib.Icons8_32x32.Icons8_Science_school.png"},
            {"Science_Test_Tube", "Tripous.ResLib.Icons8_32x32.Icons8_Science_test_tube.png"},
            {"Science_Trigonometry", "Tripous.ResLib.Icons8_32x32.Icons8_Science_trigonometry.png"},
            {"Science_University", "Tripous.ResLib.Icons8_32x32.Icons8_Science_university.png"},
            {"Security_App_Shield", "Tripous.ResLib.Icons8_32x32.Icons8_Security_app_shield.png"},
            {"Security_Delete_Shield", "Tripous.ResLib.Icons8_32x32.Icons8_Security_delete_shield.png"},
            {"Security_Firewall", "Tripous.ResLib.Icons8_32x32.Icons8_Security_firewall.png"},
            {"Security_Key", "Tripous.ResLib.Icons8_32x32.Icons8_Security_key.png"},
            {"Security_Question_Shield", "Tripous.ResLib.Icons8_32x32.Icons8_Security_question_shield.png"},
            {"Security_Refresh_Shield", "Tripous.ResLib.Icons8_32x32.Icons8_Security_refresh_shield.png"},
            {"Security_Restriction_Shield", "Tripous.ResLib.Icons8_32x32.Icons8_Security_restriction_shield.png"},
            {"Security_Shield", "Tripous.ResLib.Icons8_32x32.Icons8_Security_shield.png"},
            {"Security_User_Shield", "Tripous.ResLib.Icons8_32x32.Icons8_Security_user_shield.png"},
            {"Security_Warning_Shield", "Tripous.ResLib.Icons8_32x32.Icons8_Security_warning_shield.png"},
            {"Security_Web_Shield", "Tripous.ResLib.Icons8_32x32.Icons8_Security_web_shield.png"},
            {"Sewing_Bobbin", "Tripous.ResLib.Icons8_32x32.Icons8_Sewing_bobbin.png"},
            {"Sewing_Button", "Tripous.ResLib.Icons8_32x32.Icons8_Sewing_button.png"},
            {"Sewing_Needle", "Tripous.ResLib.Icons8_32x32.Icons8_Sewing_needle.png"},
            {"Sewing_Pin_Cushion", "Tripous.ResLib.Icons8_32x32.Icons8_Sewing_pin_cushion.png"},
            {"Sewing_Tape_Measure", "Tripous.ResLib.Icons8_32x32.Icons8_Sewing_tape_measure.png"},
            {"Sewing_Thimble", "Tripous.ResLib.Icons8_32x32.Icons8_Sewing_thimble.png"},
            {"Shoe_Polish", "Tripous.ResLib.Icons8_32x32.Icons8_shoe_polish.png"},
            {"Shoe_Polish_Beeswax", "Tripous.ResLib.Icons8_32x32.Icons8_Shoe_Polish_beeswax.png"},
            {"Shoe_Polish_Beeswax2", "Tripous.ResLib.Icons8_32x32.Icons8_Shoe_Polish_beeswax2.png"},
            {"Shoe_Polish_Polish_Cloth", "Tripous.ResLib.Icons8_32x32.Icons8_Shoe_Polish_polish_cloth.png"},
            {"Shoe_Polish_Shoe_Brush1", "Tripous.ResLib.Icons8_32x32.Icons8_Shoe_Polish_shoe_brush1.png"},
            {"Shoe_Polish_Shoe_Brush2", "Tripous.ResLib.Icons8_32x32.Icons8_Shoe_Polish_shoe_brush2.png"},
            {"Social_Network_Bebo", "Tripous.ResLib.Icons8_32x32.Icons8_Social_Network_bebo.png"},
            {"Social_Network_Facebook", "Tripous.ResLib.Icons8_32x32.Icons8_Social_Network_facebook.png"},
            {"Social_Network_Foursquare", "Tripous.ResLib.Icons8_32x32.Icons8_Social_Network_foursquare.png"},
            {"Social_Network_Google_Plus", "Tripous.ResLib.Icons8_32x32.Icons8_Social_Network_google_plus.png"},
            {"Social_Network_Instagram", "Tripous.ResLib.Icons8_32x32.Icons8_Social_Network_instagram.png"},
            {"Social_Network_Linkedin", "Tripous.ResLib.Icons8_32x32.Icons8_Social_Network_linkedin.png"},
            {"Social_Network_Myspace", "Tripous.ResLib.Icons8_32x32.Icons8_Social_Network_myspace.png"},
            {"Social_Network_Twitter", "Tripous.ResLib.Icons8_32x32.Icons8_Social_Network_twitter.png"},
            {"Social_Network_Vk_Com", "Tripous.ResLib.Icons8_32x32.Icons8_Social_Network_vk.com.png"},
            {"Social_Network_Vkontakte", "Tripous.ResLib.Icons8_32x32.Icons8_Social_Network_vkontakte.png"},
            {"Social_Network_Xing", "Tripous.ResLib.Icons8_32x32.Icons8_Social_Network_xing.png"},
            {"Sport_Back", "Tripous.ResLib.Icons8_32x32.Icons8_Sport_back.png"},
            {"Sport_Barbell", "Tripous.ResLib.Icons8_32x32.Icons8_Sport_barbell.png"},
            {"Sport_Base_Jumping", "Tripous.ResLib.Icons8_32x32.Icons8_Sport_base_jumping.png"},
            {"Sport_Basketball", "Tripous.ResLib.Icons8_32x32.Icons8_Sport_basketball.png"},
            {"Sport_Canopy", "Tripous.ResLib.Icons8_32x32.Icons8_Sport_canopy.png"},
            {"Sport_Championship_Belt", "Tripous.ResLib.Icons8_32x32.Icons8_Sport_championship_belt.png"},
            {"Sport_Chest", "Tripous.ResLib.Icons8_32x32.Icons8_Sport_chest.png"},
            {"Sport_Climbing", "Tripous.ResLib.Icons8_32x32.Icons8_Sport_climbing.png"},
            {"Sport_Drop_Zone", "Tripous.ResLib.Icons8_32x32.Icons8_Sport_drop_zone.png"},
            {"Sport_Dumbbell", "Tripous.ResLib.Icons8_32x32.Icons8_Sport_dumbbell.png"},
            {"Sport_Finish_Flag", "Tripous.ResLib.Icons8_32x32.Icons8_Sport_finish_flag.png"},
            {"Sport_Fishing", "Tripous.ResLib.Icons8_32x32.Icons8_Sport_fishing.png"},
            {"Sport_Football", "Tripous.ResLib.Icons8_32x32.Icons8_Sport_football.png"},
            {"Sport_Football2", "Tripous.ResLib.Icons8_32x32.Icons8_Sport_football2.png"},
            {"Sport_Frisbee", "Tripous.ResLib.Icons8_32x32.Icons8_Sport_frisbee.png"},
            {"Sport_Hand_Biceps", "Tripous.ResLib.Icons8_32x32.Icons8_Sport_hand_biceps.png"},
            {"Sport_Jump_Rope", "Tripous.ResLib.Icons8_32x32.Icons8_Sport_jump_rope.png"},
            {"Sport_Leg", "Tripous.ResLib.Icons8_32x32.Icons8_Sport_leg.png"},
            {"Sport_Medal2", "Tripous.ResLib.Icons8_32x32.Icons8_Sport_medal2.png"},
            {"Sport_Mountain_Biking", "Tripous.ResLib.Icons8_32x32.Icons8_Sport_mountain_biking.png"},
            {"Sport_Neck", "Tripous.ResLib.Icons8_32x32.Icons8_Sport_neck.png"},
            {"Sport_Padding", "Tripous.ResLib.Icons8_32x32.Icons8_Sport_padding.png"},
            {"Sport_Ping_Pong", "Tripous.ResLib.Icons8_32x32.Icons8_Sport_ping_pong.png"},
            {"Sport_Prelum", "Tripous.ResLib.Icons8_32x32.Icons8_Sport_prelum.png"},
            {"Sport_Regular_Biking", "Tripous.ResLib.Icons8_32x32.Icons8_Sport_regular_biking.png"},
            {"Sport_Rugby", "Tripous.ResLib.Icons8_32x32.Icons8_Sport_rugby.png"},
            {"Sport_Running", "Tripous.ResLib.Icons8_32x32.Icons8_Sport_running.png"},
            {"Sport_Shoulders", "Tripous.ResLib.Icons8_32x32.Icons8_Sport_shoulders.png"},
            {"Sport_Skiing", "Tripous.ResLib.Icons8_32x32.Icons8_Sport_skiing.png"},
            {"Sport_Skydiving", "Tripous.ResLib.Icons8_32x32.Icons8_Sport_skydiving.png"},
            {"Sport_Skydiving_Gear", "Tripous.ResLib.Icons8_32x32.Icons8_Sport_skydiving_gear.png"},
            {"Sport_Stopwatch", "Tripous.ResLib.Icons8_32x32.Icons8_Sport_stopwatch.png"},
            {"Sport_Swimming", "Tripous.ResLib.Icons8_32x32.Icons8_Sport_swimming.png"},
            {"Sport_Tennis", "Tripous.ResLib.Icons8_32x32.Icons8_Sport_tennis.png"},
            {"Sport_Time_Trial_Biking", "Tripous.ResLib.Icons8_32x32.Icons8_Sport_time_trial_biking.png"},
            {"Sport_Torso", "Tripous.ResLib.Icons8_32x32.Icons8_Sport_torso.png"},
            {"Sport_Trekking", "Tripous.ResLib.Icons8_32x32.Icons8_Sport_trekking.png"},
            {"Sport_Trophy", "Tripous.ResLib.Icons8_32x32.Icons8_Sport_trophy.png"},
            {"Sport_Weightlift", "Tripous.ResLib.Icons8_32x32.Icons8_Sport_weightlift.png"},
            {"Sport_Wheel", "Tripous.ResLib.Icons8_32x32.Icons8_Sport_wheel.png"},
            {"Sport_Yoga", "Tripous.ResLib.Icons8_32x32.Icons8_Sport_yoga.png"},
            {"Subculture_Bacon", "Tripous.ResLib.Icons8_32x32.Icons8_Subculture_bacon.png"},
            {"Subculture_Beer", "Tripous.ResLib.Icons8_32x32.Icons8_Subculture_beer.png"},
            {"Subculture_Bicycle", "Tripous.ResLib.Icons8_32x32.Icons8_Subculture_bicycle.png"},
            {"Subculture_Coffee", "Tripous.ResLib.Icons8_32x32.Icons8_Subculture_coffee.png"},
            {"Subculture_Glasses", "Tripous.ResLib.Icons8_32x32.Icons8_Subculture_glasses.png"},
            {"Subculture_Hand_Poking_Tool", "Tripous.ResLib.Icons8_32x32.Icons8_Subculture_hand_poking_tool.png"},
            {"Subculture_Mustache", "Tripous.ResLib.Icons8_32x32.Icons8_Subculture_mustache.png"},
            {"Subculture_Tattoo", "Tripous.ResLib.Icons8_32x32.Icons8_Subculture_tattoo.png"},
            {"Subculture_Tattoo_Machine", "Tripous.ResLib.Icons8_32x32.Icons8_Subculture_tattoo_machine.png"},
            {"System_Add_Property", "Tripous.ResLib.Icons8_32x32.Icons8_System_add_property.png"},
            {"System_Bottom_Toolbar", "Tripous.ResLib.Icons8_32x32.Icons8_System_bottom_toolbar.png"},
            {"System_Dashboard", "Tripous.ResLib.Icons8_32x32.Icons8_System_dashboard.png"},
            {"System_Delete", "Tripous.ResLib.Icons8_32x32.Icons8_System_delete.png"},
            {"System_Delete_Property", "Tripous.ResLib.Icons8_32x32.Icons8_System_delete_property.png"},
            {"System_Edit_Property", "Tripous.ResLib.Icons8_32x32.Icons8_System_edit_property.png"},
            {"System_Error", "Tripous.ResLib.Icons8_32x32.Icons8_System_error.png"},
            {"System_Help", "Tripous.ResLib.Icons8_32x32.Icons8_System_help.png"},
            {"System_Left_Sidebar", "Tripous.ResLib.Icons8_32x32.Icons8_System_Left_Sidebar.png"},
            {"System_Login", "Tripous.ResLib.Icons8_32x32.Icons8_System_login.png"},
            {"System_Logout", "Tripous.ResLib.Icons8_32x32.Icons8_System_logout.png"},
            {"System_Pin", "Tripous.ResLib.Icons8_32x32.Icons8_System_pin.png"},
            {"System_Pin2", "Tripous.ResLib.Icons8_32x32.Icons8_System_pin2.png"},
            {"System_Private", "Tripous.ResLib.Icons8_32x32.Icons8_System_private.png"},
            {"System_Public", "Tripous.ResLib.Icons8_32x32.Icons8_System_public.png"},
            {"System_Save", "Tripous.ResLib.Icons8_32x32.Icons8_System_save.png"},
            {"System_Save_As", "Tripous.ResLib.Icons8_32x32.Icons8_System_save_as.png"},
            {"System_Settings", "Tripous.ResLib.Icons8_32x32.Icons8_System_settings.png"},
            {"System_Show_Property", "Tripous.ResLib.Icons8_32x32.Icons8_System_show_property.png"},
            {"System_Top_Toolbar", "Tripous.ResLib.Icons8_32x32.Icons8_System_top_toolbar.png"},
            {"System_Unpin", "Tripous.ResLib.Icons8_32x32.Icons8_System_unpin.png"},
            {"System_Unpin2", "Tripous.ResLib.Icons8_32x32.Icons8_System_unpin2.png"},
            {"Tale_Genie", "Tripous.ResLib.Icons8_32x32.Icons8_Tale_genie.png"},
            {"Tale_Lamp", "Tripous.ResLib.Icons8_32x32.Icons8_Tale_lamp.png"},
            {"Tale_Lamp_Genie", "Tripous.ResLib.Icons8_32x32.Icons8_Tale_lamp_genie.png"},
            {"Textedit_Attach", "Tripous.ResLib.Icons8_32x32.Icons8_TextEdit_attach.png"},
            {"Textedit_Bg_Color", "Tripous.ResLib.Icons8_32x32.Icons8_TextEdit_bg_color.png"},
            {"Textedit_Bold", "Tripous.ResLib.Icons8_32x32.Icons8_TextEdit_bold.png"},
            {"Textedit_Border_Color", "Tripous.ResLib.Icons8_32x32.Icons8_TextEdit_border_color.png"},
            {"Textedit_Center", "Tripous.ResLib.Icons8_32x32.Icons8_TextEdit_center.png"},
            {"Textedit_Cllipboard", "Tripous.ResLib.Icons8_32x32.Icons8_TextEdit_cllipboard.png"},
            {"Textedit_Compare", "Tripous.ResLib.Icons8_32x32.Icons8_TextEdit_compare.png"},
            {"Textedit_Copy", "Tripous.ResLib.Icons8_32x32.Icons8_TextEdit_copy.png"},
            {"Textedit_Cut", "Tripous.ResLib.Icons8_32x32.Icons8_TextEdit_cut.png"},
            {"Textedit_Decrease_Font", "Tripous.ResLib.Icons8_32x32.Icons8_TextEdit_decrease_font.png"},
            {"Textedit_Delete", "Tripous.ResLib.Icons8_32x32.Icons8_TextEdit_delete.png"},
            {"Textedit_Edit", "Tripous.ResLib.Icons8_32x32.Icons8_TextEdit_edit.png"},
            {"Textedit_Erase", "Tripous.ResLib.Icons8_32x32.Icons8_TextEdit_erase.png"},
            {"Textedit_Generic_Text", "Tripous.ResLib.Icons8_32x32.Icons8_TextEdit_generic_text.png"},
            {"Textedit_Increase_Font", "Tripous.ResLib.Icons8_32x32.Icons8_TextEdit_increase_font.png"},
            {"Textedit_Italic", "Tripous.ResLib.Icons8_32x32.Icons8_TextEdit_italic.png"},
            {"Textedit_Justify", "Tripous.ResLib.Icons8_32x32.Icons8_TextEdit_justify.png"},
            {"Textedit_Left", "Tripous.ResLib.Icons8_32x32.Icons8_TextEdit_left.png"},
            {"Textedit_Rename", "Tripous.ResLib.Icons8_32x32.Icons8_TextEdit_rename.png"},
            {"Textedit_Right", "Tripous.ResLib.Icons8_32x32.Icons8_TextEdit_right.png"},
            {"Theater_Audience", "Tripous.ResLib.Icons8_32x32.Icons8_Theater_audience.png"},
            {"Theater_Bunch_Flowers", "Tripous.ResLib.Icons8_32x32.Icons8_Theater_bunch_flowers.png"},
            {"Theater_Comedy_Mask", "Tripous.ResLib.Icons8_32x32.Icons8_Theater_comedy_mask.png"},
            {"Theater_Lyre", "Tripous.ResLib.Icons8_32x32.Icons8_Theater_lyre.png"},
            {"Theater_Opera_Glasses", "Tripous.ResLib.Icons8_32x32.Icons8_Theater_opera_glasses.png"},
            {"Theater_Theatre_Masks", "Tripous.ResLib.Icons8_32x32.Icons8_Theater_theatre_masks.png"},
            {"Theater_Tragedy_Mask", "Tripous.ResLib.Icons8_32x32.Icons8_Theater_tragedy_mask.png"},
            {"Touristic_Beach", "Tripous.ResLib.Icons8_32x32.Icons8_Touristic_beach.png"},
            {"Touristic_Cave", "Tripous.ResLib.Icons8_32x32.Icons8_Touristic_cave.png"},
            {"Touristic_Museum", "Tripous.ResLib.Icons8_32x32.Icons8_Touristic_museum.png"},
            {"Transport_Airplane_Landing", "Tripous.ResLib.Icons8_32x32.Icons8_Transport_airplane_landing.png"},
            {"Transport_Airplane_Takeoff", "Tripous.ResLib.Icons8_32x32.Icons8_Transport_airplane_takeoff.png"},
            {"Transport_Bicycle", "Tripous.ResLib.Icons8_32x32.Icons8_Transport_bicycle.png"},
            {"Transport_Bus", "Tripous.ResLib.Icons8_32x32.Icons8_Transport_bus.png"},
            {"Transport_Car", "Tripous.ResLib.Icons8_32x32.Icons8_Transport_car.png"},
            {"Transport_Car_Battery", "Tripous.ResLib.Icons8_32x32.Icons8_Transport_car_battery.png"},
            {"Transport_Cargo_Ship", "Tripous.ResLib.Icons8_32x32.Icons8_Transport_cargo_ship.png"},
            {"Transport_Cruise_Ship", "Tripous.ResLib.Icons8_32x32.Icons8_Transport_cruise_ship.png"},
            {"Transport_Dinghy", "Tripous.ResLib.Icons8_32x32.Icons8_Transport_dinghy.png"},
            {"Transport_Engine", "Tripous.ResLib.Icons8_32x32.Icons8_Transport_engine.png"},
            {"Transport_Ferry", "Tripous.ResLib.Icons8_32x32.Icons8_Transport_ferry.png"},
            {"Transport_Helicopter", "Tripous.ResLib.Icons8_32x32.Icons8_Transport_helicopter.png"},
            {"Transport_Motorcycle", "Tripous.ResLib.Icons8_32x32.Icons8_Transport_motorcycle.png"},
            {"Transport_Pickup", "Tripous.ResLib.Icons8_32x32.Icons8_Transport_pickup.png"},
            {"Transport_Piston", "Tripous.ResLib.Icons8_32x32.Icons8_Transport_piston.png"},
            {"Transport_Railroad_Car", "Tripous.ResLib.Icons8_32x32.Icons8_Transport_railroad_car.png"},
            {"Transport_Sail_Boat", "Tripous.ResLib.Icons8_32x32.Icons8_Transport_sail_boat.png"},
            {"Transport_Scooter", "Tripous.ResLib.Icons8_32x32.Icons8_Transport_scooter.png"},
            {"Transport_Spark_Plug", "Tripous.ResLib.Icons8_32x32.Icons8_Transport_spark_plug.png"},
            {"Transport_Speedometer", "Tripous.ResLib.Icons8_32x32.Icons8_Transport_speedometer.png"},
            {"Transport_Steering_Wheel", "Tripous.ResLib.Icons8_32x32.Icons8_Transport_steering_wheel.png"},
            {"Transport_Taxi", "Tripous.ResLib.Icons8_32x32.Icons8_Transport_taxi.png"},
            {"Transport_Tire", "Tripous.ResLib.Icons8_32x32.Icons8_Transport_tire.png"},
            {"Transport_Track", "Tripous.ResLib.Icons8_32x32.Icons8_Transport_track.png"},
            {"Transport_Tractor", "Tripous.ResLib.Icons8_32x32.Icons8_Transport_tractor.png"},
            {"Transport_Trailer", "Tripous.ResLib.Icons8_32x32.Icons8_Transport_trailer.png"},
            {"Transport_Train", "Tripous.ResLib.Icons8_32x32.Icons8_Transport_train.png"},
            {"Transport_Tram", "Tripous.ResLib.Icons8_32x32.Icons8_Transport_tram.png"},
            {"Transport_Tram2", "Tripous.ResLib.Icons8_32x32.Icons8_Transport_tram2.png"},
            {"Transport_Trolleybus", "Tripous.ResLib.Icons8_32x32.Icons8_Transport_trolleybus.png"},
            {"Transport_Yacht", "Tripous.ResLib.Icons8_32x32.Icons8_Transport_yacht.png"},
            {"Update_Available_Updates", "Tripous.ResLib.Icons8_32x32.Icons8_Update_available_updates.png"},
            {"Update_Downloading_Updates", "Tripous.ResLib.Icons8_32x32.Icons8_Update_downloading_updates.png"},
            {"Update_Installing_Updates", "Tripous.ResLib.Icons8_32x32.Icons8_Update_installing_updates.png"},
            {"Usb_Connected", "Tripous.ResLib.Icons8_32x32.Icons8_usb_connected.png"},
            {"Usb_Disconnected", "Tripous.ResLib.Icons8_32x32.Icons8_usb_disconnected.png"},
            {"Usb_Off", "Tripous.ResLib.Icons8_32x32.Icons8_usb_off.png"},
            {"Usb_On", "Tripous.ResLib.Icons8_32x32.Icons8_usb_on.png"},
            {"User", "Tripous.ResLib.Icons8_32x32.Icons8_user.png"},
            {"User_Add_User", "Tripous.ResLib.Icons8_32x32.Icons8_User_add_user.png"},
            {"User_Administrator", "Tripous.ResLib.Icons8_32x32.Icons8_User_administrator.png"},
            {"User_Administrator2", "Tripous.ResLib.Icons8_32x32.Icons8_User_administrator2.png"},
            {"User_Change_User", "Tripous.ResLib.Icons8_32x32.Icons8_User_change_user.png"},
            {"User_Checked_User", "Tripous.ResLib.Icons8_32x32.Icons8_User_checked_user.png"},
            {"User_Collaborator", "Tripous.ResLib.Icons8_32x32.Icons8_User_collaborator.png"},
            {"User_Conference", "Tripous.ResLib.Icons8_32x32.Icons8_User_conference.png"},
            {"User_Cook", "Tripous.ResLib.Icons8_32x32.Icons8_User_cook.png"},
            {"User_Doctor", "Tripous.ResLib.Icons8_32x32.Icons8_User_doctor.png"},
            {"User_Edit_User", "Tripous.ResLib.Icons8_32x32.Icons8_User_edit_user.png"},
            {"User_Fireman", "Tripous.ResLib.Icons8_32x32.Icons8_User_fireman.png"},
            {"User_Group", "Tripous.ResLib.Icons8_32x32.Icons8_User_group.png"},
            {"User_Guest", "Tripous.ResLib.Icons8_32x32.Icons8_User_guest.png"},
            {"User_Moderator", "Tripous.ResLib.Icons8_32x32.Icons8_User_moderator.png"},
            {"User_Nurse", "Tripous.ResLib.Icons8_32x32.Icons8_User_nurse.png"},
            {"User_Police", "Tripous.ResLib.Icons8_32x32.Icons8_User_police.png"},
            {"User_Remove_User", "Tripous.ResLib.Icons8_32x32.Icons8_User_remove_user.png"},
            {"User_Reviewer", "Tripous.ResLib.Icons8_32x32.Icons8_User_reviewer.png"},
            {"User_Student", "Tripous.ResLib.Icons8_32x32.Icons8_User_student.png"},
            {"User_Talk", "Tripous.ResLib.Icons8_32x32.Icons8_User_talk.png"},
            {"User_Worker", "Tripous.ResLib.Icons8_32x32.Icons8_User_worker.png"},
            {"User_Workers", "Tripous.ResLib.Icons8_32x32.Icons8_User_workers.png"},
            {"Video_Game_Console_Ps", "Tripous.ResLib.Icons8_32x32.Icons8_Video_Game_Console_ps.png"},
            {"Video_Game_Console_Wii", "Tripous.ResLib.Icons8_32x32.Icons8_Video_Game_Console_wii.png"},
            {"Video_Game_Console_Xbox", "Tripous.ResLib.Icons8_32x32.Icons8_Video_Game_Console_xbox.png"},
            {"Volume_Control_High", "Tripous.ResLib.Icons8_32x32.Icons8_Volume_Control_High.png"},
            {"Volume_Control_Listen", "Tripous.ResLib.Icons8_32x32.Icons8_Volume_Control_listen.png"},
            {"Volume_Control_Low", "Tripous.ResLib.Icons8_32x32.Icons8_Volume_Control_Low.png"},
            {"Volume_Control_Mute", "Tripous.ResLib.Icons8_32x32.Icons8_Volume_Control_mute.png"},
            {"Volume_Control_Not_Listen", "Tripous.ResLib.Icons8_32x32.Icons8_Volume_Control_not_listen.png"},
            {"Weather_Chance_Of_Storm", "Tripous.ResLib.Icons8_32x32.Icons8_Weather_chance_of_storm.png"},
            {"Weather_Cloud_Lighting", "Tripous.ResLib.Icons8_32x32.Icons8_Weather_cloud_lighting.png"},
            {"Weather_Clouds", "Tripous.ResLib.Icons8_32x32.Icons8_Weather_clouds.png"},
            {"Weather_Dust", "Tripous.ResLib.Icons8_32x32.Icons8_Weather_dust.png"},
            {"Weather_Fog_Day", "Tripous.ResLib.Icons8_32x32.Icons8_Weather_fog_day.png"},
            {"Weather_Fog_Night", "Tripous.ResLib.Icons8_32x32.Icons8_Weather_fog_night.png"},
            {"Weather_Hail", "Tripous.ResLib.Icons8_32x32.Icons8_Weather_hail.png"},
            {"Weather_Icy", "Tripous.ResLib.Icons8_32x32.Icons8_Weather_icy.png"},
            {"Weather_Little_Rain", "Tripous.ResLib.Icons8_32x32.Icons8_Weather_little_rain.png"},
            {"Weather_Little_Snow", "Tripous.ResLib.Icons8_32x32.Icons8_Weather_little_snow.png"},
            {"Weather_Moon", "Tripous.ResLib.Icons8_32x32.Icons8_Weather_moon.png"},
            {"Weather_Partly_Cloudy_Day", "Tripous.ResLib.Icons8_32x32.Icons8_Weather_partly_cloudy_day.png"},
            {"Weather_Partly_Cloudy_Night", "Tripous.ResLib.Icons8_32x32.Icons8_Weather_partly_cloudy_night.png"},
            {"Weather_Rain", "Tripous.ResLib.Icons8_32x32.Icons8_Weather_rain.png"},
            {"Weather_Sleet", "Tripous.ResLib.Icons8_32x32.Icons8_Weather_sleet.png"},
            {"Weather_Snow", "Tripous.ResLib.Icons8_32x32.Icons8_Weather_snow.png"},
            {"Weather_Snow_Storm", "Tripous.ResLib.Icons8_32x32.Icons8_Weather_snow_storm.png"},
            {"Weather_Storm", "Tripous.ResLib.Icons8_32x32.Icons8_Weather_storm.png"},
            {"Weather_Sun", "Tripous.ResLib.Icons8_32x32.Icons8_Weather_sun.png"},
            {"Weather_Thermometer", "Tripous.ResLib.Icons8_32x32.Icons8_Weather_thermometer.png"},
            {"Web_Css", "Tripous.ResLib.Icons8_32x32.Icons8_Web_css.png"},
            {"Web_Html", "Tripous.ResLib.Icons8_32x32.Icons8_Web_html.png"},
            {"Web_Js", "Tripous.ResLib.Icons8_32x32.Icons8_Web_js.png"},
            {"Web_Php", "Tripous.ResLib.Icons8_32x32.Icons8_Web_php.png"},
            {"Website_Section_About", "Tripous.ResLib.Icons8_32x32.Icons8_Website_Section_about.png"},
            {"Website_Section_Contacts", "Tripous.ResLib.Icons8_32x32.Icons8_Website_Section_contacts.png"},
            {"Website_Section_Contacts2", "Tripous.ResLib.Icons8_32x32.Icons8_Website_Section_contacts2.png"},
            {"Website_Section_News", "Tripous.ResLib.Icons8_32x32.Icons8_Website_Section_news.png"},
            {"Website_Section_Product", "Tripous.ResLib.Icons8_32x32.Icons8_Website_Section_product.png"},
            {"Website_Section_Services", "Tripous.ResLib.Icons8_32x32.Icons8_Website_Section_services.png"},
            {"Website_Section_Solutions", "Tripous.ResLib.Icons8_32x32.Icons8_Website_Section_solutions.png"},
            {"Website_Section_Support", "Tripous.ResLib.Icons8_32x32.Icons8_Website_Section_support.png"},
            {"Wedding_Cake", "Tripous.ResLib.Icons8_32x32.Icons8_wedding_cake.png"},
            {"Wedding_Champagne", "Tripous.ResLib.Icons8_32x32.Icons8_Wedding_champagne.png"},
            {"Wedding_Day", "Tripous.ResLib.Icons8_32x32.Icons8_wedding_day.png"},
            {"Wedding_Photo", "Tripous.ResLib.Icons8_32x32.Icons8_wedding_photo.png"},
            {"Wedding_Ring", "Tripous.ResLib.Icons8_32x32.Icons8_Wedding_ring.png"},
            {"Wedding_Rings", "Tripous.ResLib.Icons8_32x32.Icons8_wedding_rings.png"},
            {"Wedding_Two_Hearts", "Tripous.ResLib.Icons8_32x32.Icons8_Wedding_two_hearts.png"},
            {"Window_Close", "Tripous.ResLib.Icons8_32x32.Icons8_Window_Close.png"},
            {"Window_Maximize", "Tripous.ResLib.Icons8_32x32.Icons8_Window_Maximize.png"},
            {"Window_Minimize", "Tripous.ResLib.Icons8_32x32.Icons8_Window_Minimize.png"},
            {"Window_Restore", "Tripous.ResLib.Icons8_32x32.Icons8_Window_Restore.png"},
            };


            #endregion

        }

}
