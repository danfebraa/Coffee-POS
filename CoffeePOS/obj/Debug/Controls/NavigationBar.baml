   M S B A M L   `   `   `  ����D  @CoffeePOS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:CoffeePOS.ControlsCoffeePOS.Controls  5      I)clr-namespace:CoffeePOS.States.NavigatorsCoffeePOS.States.Navigators  5      &     CoffeePOS.Controls.NavigationBar   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:CoffeePOS.Controls     5      9nav)clr-namespace:CoffeePOS.States.Navigators     5      .��5
      � 
�������  � RowDefinitions  5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   ��    BrushPrimary2#��[  6   $��0��6@    �� Padding$ 10q�6M     BrushPrimary1#��[ 6Z   $��Italic$�6�   $��28(�6�   $
��Bold"�6�   $��Coffee Shop POS��6�   �� 5   
    �� Orientation$ 
Horizontal=�6   $��1��6.     BrushPrimary3#��[ 6;   .+�5      	� *   $CoffeePOS.States.Navigators.ViewType   Food#��Z 6L   $
��Food��6|   $��10q�6�   #��[ 6�   #��[  6�   ��6   �� *UpdateCurrentViewModelCommand+6�   	� 5         Drinks#��Z 6L   $��Drinks��6~   $��10q�6�   #��[ 6�   #��[  6�   ��6   �� *UpdateCurrentViewModelCommand+6�   5      5      5      