   M S B A M L   `   `   `  ����D  @Poke-Team, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Poke_Team	Poke_Team  5      A%clr-namespace:Poke_Team.MVM.ViewModelPoke_Team.MVM.ViewModel  5          Poke_Team.MainWindow   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:Poke_Team     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      ;	viewModel%clr-namespace:Poke_Team.MVM.ViewModel     5        � Title$  	Poke-Team��5	      $	��920��5
      $	��600��5       � 
ResizeMode$ NoResize=�5       � WindowStartupLocation$ CenterScreen=�5       � WindowStyle$
 None=�5      
������  � AllowsTransparency .  � DataContext 5      +  %Poke_Team.MVM.ViewModel.MainViewModel  5   
   .��5      �� ���#272537 �� CornerRadius$ 10��5      ._�5   
   �  � ColumnDefinitions 5      �� 5      $	��200 �6#   61   �� 5      6%    � RowDefinitions 5      �� 5       $��75 �6    6.   �� 5!      6"   .+�5#      �� $��	Poke-Team��6   $��Center=�5$      $
��Left=�5%      
�������$��20(�5'      $0��*/Poke-Team;component/Fonts/#Press Start 2P)�6&   $��10, 0, 0, 0q�5(      �� 5*      $��1��6   .+�5,      	� $
��Home��6   $��50��5-      
�������$��16(�5/         MenuButtonTheme#��[  50      	 d� 	IsChecked$
	 TrueY�51      ��52      �� *HomeViewCommand+	� 54      $��Teams��6   $��50��55      
�������$��16(�57      #��[  58      ��59      �� *TeamViewCommand+	� 5;      $��Team Builder��6   $��50��5<      
�������$��16(�5>      #��[  5?      5B      �� 5D      $��1��6   $	��250��5E      $��40��5F      $��Center=�5G      $
��Left=�5H      $��5q�5I        TextBoxTheme#��[ 5J      �� 5L      $��1��6   $��1��5M      $��10q�5N      ��5O      �� *CurrentView+5P      5R      5S      