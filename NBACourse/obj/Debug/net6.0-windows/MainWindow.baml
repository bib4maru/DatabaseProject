   M S B A M L   `   `   `  ????D  @NBACourse, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:NBACourse	NBACourse  5   	       NBACourse.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:NBACourse     5   	     ? Title$  
MainWindow??5   	   $	??450??6   $	??800??6)    ? WindowStartupLocation$ CenterScreen=?65    ? 
ResizeMode$ NoResize=?6Z   .??5	      ? 
???????.+?5
   
   ?? .@?5      ?? $%??Лига/Конференция??6   .??5      ? ???#999999.+?5      ?? $
??Left=?6    $??	53,10,0,0q?6;   $
??Wrap=?6N   $??Выберите лигу??6b   $	??Top=?6w   $??16(?6?   $
??Bold"?6?   ?? 5      $??10,31,0,203q?6!    ?? Orientation$ 
Horizontal=?66   $
??Left=?6O   $	??236??6j   .+?5      ?? -   5         ??Name$ 	SelectNBA??5   !   $?? ??64   $	??108??6?   $	??156??6K   ??5      ?? 5   "    ?? ImageSource$ Images/nba.png??6-    j? Stretch$ UniformToFill=?6J   5      ?? 5      -   5        $ SelectG??5   !   $?? ??62   $	??105??6=   $	??156??6I   ??5      ?? 5   "   $ UniformToFill=?6-   $: 4Images/nba-logo-silhouette-player-27-transformed.png??6E   5      5      &   System.Windows.Controls.DataGrid  5      -   5          Name$ ConferenceList??5      $??246,53,26,80q?67      AutoGenerateColumns$ False??6M   	   
IsReadOnly$
	 true??6i   
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Лига??61      Width5  /System.Windows.Controls.DataGridLengthConverter$ 90 6^   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6?   ?? *
LeagueName+6k     5      $ Конференция??61   $	 130 6c    6F   ?? *
ConfName+6q     5      $ Игрок недели ??61   $	 150 6f    6H   ?? *	PlayerOfW+6t     5      $ Игрок месяца??61   $ * 6e    6G   ?? *	PlayerOfM+6q   5!      ?? 5"      $
??Left=?6    $??
449,10,0,0q?6;   $
??Wrap=?6O   $??Конференции??6c   $	??Top=?6v   $??16(?6?   $
??Bold"?6?   ?? 5#      -   5        $ RefreshConf??5#      $??Обновить??62   $
??Left=?6E   $??674,331,0,0q?6`   $	??Top=?6u   $??94??6?   $??26??6?   6?   5$      5%      ?? 5&      $??Дивизион??6   .??5'      ? ???#999999.+?5(        -   5        $ DivionsList??5(      $ False??64   $
	 true??6P   $??130,42,111,70q?6b   
 5)        5*      $ Конференция??61   $	 130 6h    6F   ?? *Conf.ConfName+6v     5+      $ Дивизион??61   $	 130 6_    6C   ?? *	DivName+6m     5,      $- 'Защищающаяся команда??61   $	 150 6o    6O   ?? *MostDefTeam+6}     5-      $' !Атакующая команда??61   $ * 6o    6L   ?? *MostAttackTeam+6{   5/      ?? 50      -   5        $ 
RefreshDiv??50      $??Обновить??61   $
??Left=?6D   $??577,341,0,0q?6_   $	??Top=?6t   $??87??6?   $??26??6?   6?   51      52      ?? 53      $??Команда??6   .??54      ? ???#999999.+?55        -   5        $ TeamList??55      $??79,10,103,67q?61   $
	 true??6G   57      ?? 58      -   5        $ RefreshTeam??58      $??Обновить??62   $
??Left=?6E   $??612,344,0,0q?6`   $	??Top=?6u   $??79??6?   $??32??6?   6?   5:      5;      5<      5=      5>      