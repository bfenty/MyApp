function MyModule::create( %this )
{
	exec("./scripts/scenewindow.cs");
	createSceneWindow();
	createScene();
	mySceneWindow.setScene(myScene);
}

function MyModule::destroy( %this )
{
	destroySceneWindow();
}