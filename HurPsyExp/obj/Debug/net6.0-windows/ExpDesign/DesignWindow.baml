   M S B A M L   `   `   `  ����D  @HurPsyExp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:HurPsyExp.ExpDesignHurPsyExp.ExpDesign  5   	   K GHurPsyExpStrings, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM8clr-namespace:HurPsyExpStrings;assembly=HurPsyExpStringsHurPsyExpStrings 5   	   &     HurPsyExp.ExpDesign.DesignWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7	expdesign!clr-namespace:HurPsyExp.ExpDesign     5   	   N	stringlib8clr-namespace:HurPsyExpStrings;assembly=HurPsyExpStrings     5   	   &   HurPsyExpStrings.StringResources    Title_DesignWindow � Title# Z  5	   	   $	��800��5
   	   $
��1400��6    � WindowState$ 	Maximized=�5   	    � WindowStartupLocation$ CenterScreen=�6!    � DataContext 5      )   #HurPsyExp.ExpDesign.DesignViewModel  5   
    � 	Resources 5       �� MergedDictionaries �� Source   	MenuBrush �� 
StartPoint	 �� EndPoint
 � Color � Offset  MenuTextBrush �� Color  PreviewPanelBrush  HorizontallySizableControl �� 
TargetType � RowDefinitions �� Orientation   Tooltip_ResizeSlider � ToolTip � Minimum �� Path �� RelativeSource �� AncestorType � Maximum � Value�� 5   
    5      �� 5      $ DesignResources.xaml?�6%   %   &	        &	     &	 /    &	 R    �� 5      $ 0.0,0.0&�5   "   $	 1.0,0.0&�67   .��5      � $
 	LightBlue��6   $ 0Q�61   � 5      $
 LightSteelBlue��6   $
 0.25Q�66   � 5      $
 LightSkyBlue��6   $
 0.75Q�64   � 5      $
 SkyBlue��6   $ 1Q�6/   5      �� 5      $ Black��64   �� 5       $ 	AliceBlue��68   �� 5$      " >�6A   .R�5%      �  5&      �� 5'      $
��Auto �6(   �� 5(      $��* �6(   .+�5+      �� $ 
Horizontal=�6   $��0��66   # Z 5,       5-      �� $ MinWidth� �� " >� 5.      �� $ MaxWidth� �� " >� 5/      �� $ Width� �� " >��� 50      $��1��6%   #��z��62   #��z��51      52      53      55      .��58      ]� -   5         ]�Name$ 	MainPanel��58      $
��True��6#   .+�59   
   o� $	��Top=�6   #��[  5:      #��[ 5;      ��5<      ��   DesignPreferences �� Source# [ $ MenuFontSize�.@�5=      m�    Header_ExperimentMenu#��Z 6   $��2q�6[   .@�5>      m� #   Header_NewExperimentMenuItem#��Z 6    m� Command 5?      �� *NewExperimentCommand+m� 5@      $   Header_LoadExperimentMenuItem#��Z 6    5A      �� *LoadExperimentCommand+m� 5B      $   Header_SaveExperimentMenuItem#��Z 6    5C      �� *SaveExperimentCommand+5D      5E      9� 5G   
   $
��Left=�6    9� ExpandDirection$ Right=�5H        9� 
IsExpanded$
  True��5I        PanelBackground#��[ 5J      ��5K      �� 5L      $��2q�6   !   Header_ElementsPanel#��Z! 5M      " � LayoutTransform" 5N      �� 5O      # �� Angle$# 90Q�6*   5Q      .��5T      �� ._�5U      '   !HurPsyExp.ExpDesign.ElementsPanel  #��[ 6*   ��5V      �� # [ $ MinPanelWidth���5W      �� # [ $ MaxPanelWidth���5X      �� # [ $ ElementsPanelWidth�5Y      5Z      9� 5\   
   $
��Left=�6   $ Right=�5]      $
  True��5^      #��[ 5_      ��5a      �� 5b      $��2q�6   $   Header_ExperimentPanel#��Z$ 6'   " 5c      �� 5d      $# 90Q�6*   5f      .��5i      �� ._�5j      )   #HurPsyExp.ExpDesign.ExperimentPanel  #��[ 6,   ��5k      �� # [ $ MinPanelWidth���5l      �� # [ $ MaxPanelWidth���5m      �� # [ $ ExperimentPanelWidth�5n      5o      � 5q   
   5s      5t      5u      