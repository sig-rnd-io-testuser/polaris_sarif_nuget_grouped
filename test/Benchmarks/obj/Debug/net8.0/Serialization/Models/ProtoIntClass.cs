// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Serialization/Models/ProtoIntClass.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Benchmarks.Models {

  /// <summary>Holder for reflection information generated from Serialization/Models/ProtoIntClass.proto</summary>
  public static partial class ProtoIntClassReflection {

    #region Descriptor
    /// <summary>File descriptor for Serialization/Models/ProtoIntClass.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ProtoIntClassReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CihTZXJpYWxpemF0aW9uL01vZGVscy9Qcm90b0ludENsYXNzLnByb3RvEhFC",
            "ZW5jaG1hcmtzLk1vZGVscyLeAQoNUHJvdG9JbnRDbGFzcxIVCg1teV9wcm9w",
            "ZXJ0eV8xGAEgASgFEhUKDW15X3Byb3BlcnR5XzIYAiABKAUSFQoNbXlfcHJv",
            "cGVydHlfMxgDIAEoBRIVCg1teV9wcm9wZXJ0eV80GAQgASgFEhUKDW15X3By",
            "b3BlcnR5XzUYBSABKAUSFQoNbXlfcHJvcGVydHlfNhgGIAEoBRIVCg1teV9w",
            "cm9wZXJ0eV83GAcgASgFEhUKDW15X3Byb3BlcnR5XzgYCCABKAUSFQoNbXlf",
            "cHJvcGVydHlfORgJIAEoBWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Benchmarks.Models.ProtoIntClass), global::Benchmarks.Models.ProtoIntClass.Parser, new[]{ "MyProperty1", "MyProperty2", "MyProperty3", "MyProperty4", "MyProperty5", "MyProperty6", "MyProperty7", "MyProperty8", "MyProperty9" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ProtoIntClass : pb::IMessage<ProtoIntClass>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ProtoIntClass> _parser = new pb::MessageParser<ProtoIntClass>(() => new ProtoIntClass());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ProtoIntClass> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Benchmarks.Models.ProtoIntClassReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ProtoIntClass() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ProtoIntClass(ProtoIntClass other) : this() {
      myProperty1_ = other.myProperty1_;
      myProperty2_ = other.myProperty2_;
      myProperty3_ = other.myProperty3_;
      myProperty4_ = other.myProperty4_;
      myProperty5_ = other.myProperty5_;
      myProperty6_ = other.myProperty6_;
      myProperty7_ = other.myProperty7_;
      myProperty8_ = other.myProperty8_;
      myProperty9_ = other.myProperty9_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ProtoIntClass Clone() {
      return new ProtoIntClass(this);
    }

    /// <summary>Field number for the "my_property_1" field.</summary>
    public const int MyProperty1FieldNumber = 1;
    private int myProperty1_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int MyProperty1 {
      get { return myProperty1_; }
      set {
        myProperty1_ = value;
      }
    }

    /// <summary>Field number for the "my_property_2" field.</summary>
    public const int MyProperty2FieldNumber = 2;
    private int myProperty2_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int MyProperty2 {
      get { return myProperty2_; }
      set {
        myProperty2_ = value;
      }
    }

    /// <summary>Field number for the "my_property_3" field.</summary>
    public const int MyProperty3FieldNumber = 3;
    private int myProperty3_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int MyProperty3 {
      get { return myProperty3_; }
      set {
        myProperty3_ = value;
      }
    }

    /// <summary>Field number for the "my_property_4" field.</summary>
    public const int MyProperty4FieldNumber = 4;
    private int myProperty4_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int MyProperty4 {
      get { return myProperty4_; }
      set {
        myProperty4_ = value;
      }
    }

    /// <summary>Field number for the "my_property_5" field.</summary>
    public const int MyProperty5FieldNumber = 5;
    private int myProperty5_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int MyProperty5 {
      get { return myProperty5_; }
      set {
        myProperty5_ = value;
      }
    }

    /// <summary>Field number for the "my_property_6" field.</summary>
    public const int MyProperty6FieldNumber = 6;
    private int myProperty6_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int MyProperty6 {
      get { return myProperty6_; }
      set {
        myProperty6_ = value;
      }
    }

    /// <summary>Field number for the "my_property_7" field.</summary>
    public const int MyProperty7FieldNumber = 7;
    private int myProperty7_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int MyProperty7 {
      get { return myProperty7_; }
      set {
        myProperty7_ = value;
      }
    }

    /// <summary>Field number for the "my_property_8" field.</summary>
    public const int MyProperty8FieldNumber = 8;
    private int myProperty8_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int MyProperty8 {
      get { return myProperty8_; }
      set {
        myProperty8_ = value;
      }
    }

    /// <summary>Field number for the "my_property_9" field.</summary>
    public const int MyProperty9FieldNumber = 9;
    private int myProperty9_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int MyProperty9 {
      get { return myProperty9_; }
      set {
        myProperty9_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ProtoIntClass);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ProtoIntClass other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (MyProperty1 != other.MyProperty1) return false;
      if (MyProperty2 != other.MyProperty2) return false;
      if (MyProperty3 != other.MyProperty3) return false;
      if (MyProperty4 != other.MyProperty4) return false;
      if (MyProperty5 != other.MyProperty5) return false;
      if (MyProperty6 != other.MyProperty6) return false;
      if (MyProperty7 != other.MyProperty7) return false;
      if (MyProperty8 != other.MyProperty8) return false;
      if (MyProperty9 != other.MyProperty9) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (MyProperty1 != 0) hash ^= MyProperty1.GetHashCode();
      if (MyProperty2 != 0) hash ^= MyProperty2.GetHashCode();
      if (MyProperty3 != 0) hash ^= MyProperty3.GetHashCode();
      if (MyProperty4 != 0) hash ^= MyProperty4.GetHashCode();
      if (MyProperty5 != 0) hash ^= MyProperty5.GetHashCode();
      if (MyProperty6 != 0) hash ^= MyProperty6.GetHashCode();
      if (MyProperty7 != 0) hash ^= MyProperty7.GetHashCode();
      if (MyProperty8 != 0) hash ^= MyProperty8.GetHashCode();
      if (MyProperty9 != 0) hash ^= MyProperty9.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (MyProperty1 != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(MyProperty1);
      }
      if (MyProperty2 != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(MyProperty2);
      }
      if (MyProperty3 != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(MyProperty3);
      }
      if (MyProperty4 != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(MyProperty4);
      }
      if (MyProperty5 != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(MyProperty5);
      }
      if (MyProperty6 != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(MyProperty6);
      }
      if (MyProperty7 != 0) {
        output.WriteRawTag(56);
        output.WriteInt32(MyProperty7);
      }
      if (MyProperty8 != 0) {
        output.WriteRawTag(64);
        output.WriteInt32(MyProperty8);
      }
      if (MyProperty9 != 0) {
        output.WriteRawTag(72);
        output.WriteInt32(MyProperty9);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (MyProperty1 != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(MyProperty1);
      }
      if (MyProperty2 != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(MyProperty2);
      }
      if (MyProperty3 != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(MyProperty3);
      }
      if (MyProperty4 != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(MyProperty4);
      }
      if (MyProperty5 != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(MyProperty5);
      }
      if (MyProperty6 != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(MyProperty6);
      }
      if (MyProperty7 != 0) {
        output.WriteRawTag(56);
        output.WriteInt32(MyProperty7);
      }
      if (MyProperty8 != 0) {
        output.WriteRawTag(64);
        output.WriteInt32(MyProperty8);
      }
      if (MyProperty9 != 0) {
        output.WriteRawTag(72);
        output.WriteInt32(MyProperty9);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (MyProperty1 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(MyProperty1);
      }
      if (MyProperty2 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(MyProperty2);
      }
      if (MyProperty3 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(MyProperty3);
      }
      if (MyProperty4 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(MyProperty4);
      }
      if (MyProperty5 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(MyProperty5);
      }
      if (MyProperty6 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(MyProperty6);
      }
      if (MyProperty7 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(MyProperty7);
      }
      if (MyProperty8 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(MyProperty8);
      }
      if (MyProperty9 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(MyProperty9);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ProtoIntClass other) {
      if (other == null) {
        return;
      }
      if (other.MyProperty1 != 0) {
        MyProperty1 = other.MyProperty1;
      }
      if (other.MyProperty2 != 0) {
        MyProperty2 = other.MyProperty2;
      }
      if (other.MyProperty3 != 0) {
        MyProperty3 = other.MyProperty3;
      }
      if (other.MyProperty4 != 0) {
        MyProperty4 = other.MyProperty4;
      }
      if (other.MyProperty5 != 0) {
        MyProperty5 = other.MyProperty5;
      }
      if (other.MyProperty6 != 0) {
        MyProperty6 = other.MyProperty6;
      }
      if (other.MyProperty7 != 0) {
        MyProperty7 = other.MyProperty7;
      }
      if (other.MyProperty8 != 0) {
        MyProperty8 = other.MyProperty8;
      }
      if (other.MyProperty9 != 0) {
        MyProperty9 = other.MyProperty9;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            MyProperty1 = input.ReadInt32();
            break;
          }
          case 16: {
            MyProperty2 = input.ReadInt32();
            break;
          }
          case 24: {
            MyProperty3 = input.ReadInt32();
            break;
          }
          case 32: {
            MyProperty4 = input.ReadInt32();
            break;
          }
          case 40: {
            MyProperty5 = input.ReadInt32();
            break;
          }
          case 48: {
            MyProperty6 = input.ReadInt32();
            break;
          }
          case 56: {
            MyProperty7 = input.ReadInt32();
            break;
          }
          case 64: {
            MyProperty8 = input.ReadInt32();
            break;
          }
          case 72: {
            MyProperty9 = input.ReadInt32();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            MyProperty1 = input.ReadInt32();
            break;
          }
          case 16: {
            MyProperty2 = input.ReadInt32();
            break;
          }
          case 24: {
            MyProperty3 = input.ReadInt32();
            break;
          }
          case 32: {
            MyProperty4 = input.ReadInt32();
            break;
          }
          case 40: {
            MyProperty5 = input.ReadInt32();
            break;
          }
          case 48: {
            MyProperty6 = input.ReadInt32();
            break;
          }
          case 56: {
            MyProperty7 = input.ReadInt32();
            break;
          }
          case 64: {
            MyProperty8 = input.ReadInt32();
            break;
          }
          case 72: {
            MyProperty9 = input.ReadInt32();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
