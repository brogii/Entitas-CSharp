//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class Test2Entity {

    public My.Namespace.MyNamespaceComponent myNamespaceMyNamespace { get { return (My.Namespace.MyNamespaceComponent)GetComponent(Test2ComponentLookup.MyNamespaceMyNamespace); } }
    public bool hasMyNamespaceMyNamespace { get { return HasComponent(Test2ComponentLookup.MyNamespaceMyNamespace); } }

    public void AddMyNamespaceMyNamespace(string newValue) {
        var index = Test2ComponentLookup.MyNamespaceMyNamespace;
        var component = CreateComponent<My.Namespace.MyNamespaceComponent>(index);
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceMyNamespaceMyNamespace(string newValue) {
        var index = Test2ComponentLookup.MyNamespaceMyNamespace;
        var component = CreateComponent<My.Namespace.MyNamespaceComponent>(index);
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveMyNamespaceMyNamespace() {
        RemoveComponent(Test2ComponentLookup.MyNamespaceMyNamespace);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiInterfaceGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class Test2Entity : IMyNamespaceMyNamespaceEntity { }

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class Test2Matcher {

    static Entitas.IMatcher<Test2Entity> _matcherMyNamespaceMyNamespace;

    public static Entitas.IMatcher<Test2Entity> MyNamespaceMyNamespace {
        get {
            if (_matcherMyNamespaceMyNamespace == null) {
                var matcher = (Entitas.Matcher<Test2Entity>)Entitas.Matcher<Test2Entity>.AllOf(Test2ComponentLookup.MyNamespaceMyNamespace);
                matcher.componentNames = Test2ComponentLookup.componentNames;
                _matcherMyNamespaceMyNamespace = matcher;
            }

            return _matcherMyNamespaceMyNamespace;
        }
    }
}
