   M S B A M L   `   `   `  ���� D  @HurPsyExp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:HurPsyExp.ExpDesignHurPsyExp.ExpDesign  K GHurPsyExpStrings, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM8clr-namespace:HurPsyExpStrings;assembly=HurPsyExpStringsHurPsyExpStrings &     HurPsyExp.ExpDesign.DesignWindow   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     7	expdesign!clr-namespace:HurPsyExp.ExpDesign     N	stringlib8clr-namespace:HurPsyExpStrings;assembly=HurPsyExpStrings     &   HurPsyExpStrings.StringResources    Title_DesignWindow � Title# Z  $	��800��$
��1400�� � WindowState$ 	Maximized=� � WindowStartupLocation$ CenterScreen=� � DataContext )   #HurPsyExp.ExpDesign.DesignViewModel   � 	Resources  �� MergedDictionaries �� Source   	MenuBrush �� 
StartPoint	 �� EndPoint
 � Color � Offset  MenuTextBrush �� Color  PreviewPanelBrush  HorizontallySizableControl �� 
TargetType � RowDefinitions �� Orientation   Tooltip_ResizeSlider � ToolTip � Minimum �� Path �� RelativeSource �� AncestorType � Maximum � Value��  �� $ DesignResources.xaml?�%�  &	        &	 �     &	 �     &	 �     �� $ 0.0,0.0&�$	 1.0,0.0&�.��� $
 	LightBlue��$ 0Q�� $
 LightSteelBlue��$
 0.25Q�� $
 LightSkyBlue��$
 0.75Q�� $
 SkyBlue��$ 1Q��� $ Black���� $ 	AliceBlue���� " >�.R��  �� $
��Auto ��� $��* �.+��� $ 
Horizontal=�$��0��# Z  �� $ MinWidth� �� " >� �� $ MaxWidth� �� " >� �� $ Width� �� " >��� $��1��#��z��#��z��.��]� -    ]�Name$ 	MainPanel��$
��True��.+�o� $	��Top=�#��[  #��[ ����   DesignPreferences �� Source# [ $ MenuFontSize�.@�m�    Header_ExperimentMenu#��Z $��2q�.@�m� #   Header_NewExperimentMenuItem#��Z  m� Command �� *NewExperimentCommand+m� $   Header_LoadExperimentMenuItem#��Z  �� *LoadExperimentCommand+m� $   Header_SaveExperimentMenuItem#��Z  �� *SaveExperimentCommand+9� $
��Left=� 9� ExpandDirection$ Right=�  9� 
IsExpanded$
  True��  PanelBackground#��[ ���� $��2q�!   Header_ElementsPanel#��Z! " � LayoutTransform" �� # �� Angle$# 90Q�.���� ._�'   !HurPsyExp.ExpDesign.ElementsPanel  #��[ ���� # [ $ MinPanelWidth����� # [ $ MaxPanelWidth����� # [ $ ElementsPanelWidth�9� $
��Left=�$ Right=�$
  True��#��[ ���� $��2q�$   Header_ExperimentPanel#��Z$ " �� $# 90Q�.���� ._�)   #HurPsyExp.ExpDesign.ExperimentPanel  #��[ ���� # [ $ MinPanelWidth����� # [ $ MaxPanelWidth����� # [ $ ExperimentPanelWidth�� 