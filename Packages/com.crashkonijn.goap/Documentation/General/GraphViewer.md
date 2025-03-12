﻿# NodeViewer
The `Graph Viewer` is a tool that can be used to visualize any script, config or gameobject that has a (partial) GOAP config. Depending on the type of object it can show different information. For example, when selecting an agent during play it will also show the state of it's conditions based on the current WorldData.

The `Graph Viewer` can be accessed through `Tools/GOAP/Graph Viewer`, or by pressing `ctrl + g`.

The `Graph Viewer` can be used to visualize the following selected items:

- **AgentTypeScriptable**
- **CapabilityConfigScriptable**
- **ScriptableCapabilityFactoryBase**
- **AgentTypeFactoryBase**
- **AgentTypeBehaviour**
- **GoapActionProvider**

{% hint style="info" %}
The views look different when selecting a config, or when you select an agent during play. When viewing an agent during play certain information (effects, targetname) is ommitted to save space.
{% endhint %}

![Screenshot of NodeViewer](../images/goap-viewer.png)