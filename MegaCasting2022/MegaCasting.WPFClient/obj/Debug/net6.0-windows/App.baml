   M S B A M L   `   `   `  ����P  LMegaCasting.WPFClient, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:MegaCasting.WPFClient.Converters MegaCasting.WPFClient.Converters  5      b ^PresentationFramework.Aero2, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35hKclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero2Microsoft.Windows.Themes 5          MegaCasting.WPFClient.App   5      W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      D	converter.clr-namespace:MegaCasting.WPFClient.Converters     5      ]themeKclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero2     5        �� 	Resources  5       �� MergedDictionaries �� SourceB  <MegaCasting.WPFClient.Converters.ObjectToVisibilityConverter &  "_SharedObjectToVisibilityConverter  ColumnHeaderGripperStyle �� 
TargetType �� Property �� Value �� 
TargetType �� Padding  DataGridRowStyle1)  #System.Windows.Controls.DataGridRow ��Name	 �� CornerRadius
 J� SnapsToDevicePixels?  9System.Windows.Controls.Primitives.SelectiveScrollingGrid � ColumnDefinitions � RowDefinitions?  9System.Windows.Controls.Primitives.DataGridCellsPresenter   
ItemsPanelA  ;System.Windows.Controls.Primitives.DataGridDetailsPresenter   DetailsVisibility$   SelectiveScrollingOrientation;  5System.Windows.Controls.SelectiveScrollingOrientation   Vertical �� ConverterParameter&   System.Windows.Controls.DataGrid#   RowDetailsScrollingConverter �� 	Converter �� RelativeSource �� AncestorType:  4System.Windows.Controls.Primitives.DataGridRowHeader7	  1System.Windows.Controls.DataGridHeadersVisibility
 	  Row!   HeadersVisibilityConverter �� Triggers P� Property P� Value ]� 
Conditions �� Property �� Value  DataGridCellStyle1*
  $System.Windows.Controls.DataGridCell  DataGridColumnHeaderStyle1=  7System.Windows.Controls.Primitives.DataGridColumnHeader3  -Microsoft.Windows.Themes.DataGridHeaderBorder   	IsPressed J� IsMouseOver    	IsHovered!   CanUserSort"   IsClickable#   SortDirection$   SortDirection%   SeparatorVisibility&   SeparatorVisibility'   SeparatorBrush(   SeparatorBrush) n�Name�� 5   
    5	      �� 5      $I Cpack://application:,,,/MahApps.Metro;component/Styles/Controls.xaml?�6%   �� 5      $F @pack://application:,,,/MahApps.Metro;component/Styles/Fonts.xaml?�6%   �� 5      $R Lpack://application:,,,/MahApps.Metro;component/Styles/Themes/Light.Blue.xaml?�6%   �� 5      $ Styles\Style.xaml?�6%   %p  &	        &	      &	 %    &	      &	 �    7  7    5      64   �� 5      " n�65   .�5      ��  � ��$ 8��6*   �� 5       � ��
 ���� 6/   �� 5       �@�Cursor$ SizeWE��6+   �� 5       � �� 5      �� 5      " n�6*   .R�5      �� #��z��6%   # z��6O   5      5      5      �� 5      "  6.   .�5       ��  � ��
 �����6/   �� 5!       � ��$ 0 4 0 0q�6+   �� 5"       �@J�SnapsToDevicePixels$
 true��68   �� 5#       �@=�ErrorTemplate 6=   Z� �� 5$       �@ ValidationErrorTemplate 5%      �� 5&      .R�5'      �� 
���  ��$��2,0,0,0q�69   $��!��6J   $��Center=�6S   5(      5*      �� 5+       � �� 5,      �� 5-      "  6*   .R�5.      �� $ 
DGR_Border��6%   $	 0 8q�69   #��z��6G   $	 5��6q   $��0q�6�   $

 True��6�   ._�5/   "      50   &   �� 51   *   $
��Auto �6;   �� 52   *   $��* �6;    54   &   �� 55   *   $��* �68   �� 56   *   $
��Auto �68   .+�58   &     $��1��6=   #��z 6M   #
 z
 6w     59   &   $��1��6?   $��1��6O   #y�z 6s   6\   �� *AreRowDetailsFrozen+# Z # Z  �� "  6s    5:   &   $��2��68   $ Vertical=�6I   y�6�   �� *HeadersVisibility+# Z # Z  �� "  5;   #   5<      5=      5?       5@      P� 5A       �@J�IsMouseOver$
 True��65   . �5B      ��  � �� �#2e2e2e67   �� 5C       � �� �#ffffff67   5D      P� 5E       �@ 
IsSelected$
 True��64   . �5F      ��  � �� �#2e2e2e67   �� 5G       � �� �#ffffff67   5H      ]� 5I       5J      �� 5K       �@ 
IsSelected$
 true��6>   �� 5L       �@��IsSelectionActive$ false��6N   ./�5N      ��  � �� �#dfdfdf67   5O      5Q      �� 5R      " 
 6/   .�5S      ��  � ��
 ���� 6/   �� 5T       � ��$ Center=�66   �� 5U       �@�FocusVisualStyle 65   Z� �� 5V       � ��$
 15 0q�6+   �� 5W       � �� 5X      �� 5Y      " 
 6*   .R�5Z      �� #��z��6%   $��0q�6O   $

 True��6c   ._�5[   "   �� #
 z
 63   5\      5]      5_      5`      �� 5a      "  67   .�5b      ��  � ��$ Center=�6=   �� 5c       � ��
 ���� 6/   �� 5d       � �� �#9696966/   �� 5e       � ��$ 
15 0 15 10q�6+   �� 5f       � �� 5g      �� 5h      "  6*   .R�5i      � .+�5j   "     #��z��6=   #��z��6g   #��z��6�   # z��6�   #  z 6�   #" z! 6  # z��6E  #$ z# 6i  #& z% 6�  #( z' 6�  ._�5k   &   �� #��z��67   $
��True��6z   #
 z
 6�   #��z��6�   5l   #   n� 5m   "   $) PART_LeftHeaderGripper��6(   $
��Left=�6H   8��  6c   n� 5n   "   $) PART_RightHeaderGripper��6(   $��Right=�6I   8�� 6e   5o      5p      5r      5s      5u      5x      