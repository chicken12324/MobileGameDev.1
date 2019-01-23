set /p name=commitname:
git add --all
git commit -m "%name%"
git push