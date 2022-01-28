$col = New-Object System.Drawing.Text.InstalledFontCollection
$fonts = $col.Families
$lcid = (Get-Culture en-US).lcid
foreach ($font in $fonts) { Write-Output $font.GetName($lcid) }
