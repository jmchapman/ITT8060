$(document).ready(function () {
var list_1_Tuple_2_String__String__NilTuple_2_String__String_, list_1_Tuple_2_String__String__ConsTuple_2_String__String_, list_1_String__NilString, list_1_String__ConsString, WorldBankRuntime__GetIndicators$, WorldBankRuntime__GetCountry$, WorldBankRuntime__GetCountries$, WorldBankRuntime__AsyncGetIndicator$, WorldBankCountry___ctor$, Utils__getJSONPrefix$, Utils__encodeURIComponent$, UnfoldEnumerator_2_Int32__Tuple_2_Country__JQuery___ctor$Int32_Tuple_2_Country__JQuery_, UnfoldEnumerator_2_Int32__IJsonDocument___ctor$Int32_IJsonDocument_, UnfoldEnumerator_2_IEnumerator_1_Tuple_2_Int32__Double__HighchartsDataPoint___ctor$IEnumerator_1_Tuple_2_Int32__Double__HighchartsDataPoint_, UnfoldEnumerator_2_IEnumerator_1_IJsonDocument__Tuple_2_Int32__Double___ctor$IEnumerator_1_IJsonDocument__Tuple_2_Int32__Double_, UnfoldEnumerator_2_FSharpList_1_String__String___ctor$FSharpList_1_String__String, TupleTuple_2_Int32__Double__IEnumerator_1_IJsonDocument_, TupleTuple_2_Country__JQuery__Int32, TupleString_String, TupleString_FSharpList_1_String_, TupleInt32_Double, TupleIJsonDocument__Int32, TupleHighchartsDataPoint__IEnumerator_1_Tuple_2_Int32__Double_, TupleFSharpFunc_2_IEnumerable_1_Tuple_2_Int32__Double__Unit__FSharpFunc_2_Exception__Unit__FSharpFunc_2_String__Unit_, TupleCountry__JQuery_, Seq__Unfold$Int32__Tuple_2_Country__JQuery_Int32_Tuple_2_Country__JQuery_, Seq__Unfold$Int32__IJsonDocument_Int32_IJsonDocument_, Seq__Unfold$IEnumerator_1_Tuple_2_Int32__Double__HighchartsDataPoint_IEnumerator_1_Tuple_2_Int32__Double__HighchartsDataPoint_, Seq__Unfold$IEnumerator_1_IJsonDocument__Tuple_2_Int32__Double_IEnumerator_1_IJsonDocument__Tuple_2_Int32__Double_, Seq__Unfold$FSharpList_1_String__String_FSharpList_1_String__String, Seq__ToArray$String_String, Seq__ToArray$HighchartsDataPoint_HighchartsDataPoint_, Seq__OfList$String_String, Seq__OfArray$Tuple_2_Country__JQuery_Tuple_2_Country__JQuery_, Seq__OfArray$IJsonDocument_IJsonDocument_, Seq__Map$Tuple_2_Int32__Double__HighchartsDataPoint_Tuple_2_Int32__Double__HighchartsDataPoint_, Seq__IterateIndexed$String_String, Seq__IterateIndexed$HighchartsDataPoint_HighchartsDataPoint_, Seq__FromFactory$Tuple_2_Int32__Double_Tuple_2_Int32__Double_, Seq__FromFactory$Tuple_2_Country__JQuery_Tuple_2_Country__JQuery_, Seq__FromFactory$String_String, Seq__FromFactory$IJsonDocument_IJsonDocument_, Seq__FromFactory$HighchartsDataPoint_HighchartsDataPoint_, Seq__FoldIndexedAux$Unit__String_Unit__String, Seq__FoldIndexedAux$Unit__HighchartsDataPoint_Unit__HighchartsDataPoint_, Seq__FoldIndexed$String__Unit_String_Unit_, Seq__FoldIndexed$HighchartsDataPoint__Unit_HighchartsDataPoint__Unit_, Seq__Enumerator$Tuple_2_Int32__Double_Tuple_2_Int32__Double_, Seq__Enumerator$String_String, Seq__Enumerator$IJsonDocument_IJsonDocument_, Seq__Enumerator$HighchartsDataPoint_HighchartsDataPoint_, Seq__Delay$Tuple_2_Int32__Double_Tuple_2_Int32__Double_, Seq__Delay$HighchartsDataPoint_HighchartsDataPoint_, Seq__Choose$IJsonDocument__Tuple_2_Int32__Double_IJsonDocument__Tuple_2_Int32__Double_, Runtime__worldBankUrl$, Program__op_Dynamic$JQuery_JQuery_, Program__makeCheckInfos$, Program__main$, Program__jq$, Program__get_data$, Program__data, Program__countries$, Option__IsSome$Int32_Int32, Option__IsSome$IEnumerator_1_Tuple_2_Int32__Double_IEnumerator_1_Tuple_2_Int32__Double_, Option__IsSome$IEnumerator_1_IJsonDocument_IEnumerator_1_IJsonDocument_, Option__IsSome$FSharpList_1_String_FSharpList_1_String_, Option__GetValue$Tuple_2_Tuple_2_Int32__Double__IEnumerator_1_IJsonDocument_Tuple_2_Tuple_2_Int32__Double__IEnumerator_1_IJsonDocument_, Option__GetValue$Tuple_2_Tuple_2_Country__JQuery__Int32_Tuple_2_Tuple_2_Country__JQuery__Int32_, Option__GetValue$Tuple_2_String__FSharpList_1_String_Tuple_2_String__FSharpList_1_String_, Option__GetValue$Tuple_2_Int32__Double_Tuple_2_Int32__Double_, Option__GetValue$Tuple_2_IJsonDocument__Int32_Tuple_2_IJsonDocument__Int32_, Option__GetValue$Tuple_2_HighchartsDataPoint__IEnumerator_1_Tuple_2_Int32__Double_Tuple_2_HighchartsDataPoint__IEnumerator_1_Tuple_2_Int32__Double_, Option__GetValue$Object_Object_, Option__GetValue$JsonValue_JsonValue_, Option__GetValue$Int32_Int32, Option__GetValue$IEnumerator_1_Tuple_2_Int32__Double_IEnumerator_1_Tuple_2_Int32__Double_, Option__GetValue$IEnumerator_1_IJsonDocument_IEnumerator_1_IJsonDocument_, Option__GetValue$FSharpRef_1_Boolean_FSharpRef_1_Boolean_, Option__GetValue$FSharpList_1_String_FSharpList_1_String_, Option__GetValue$Decimal_Decimal, Option__GetValue$CancellationToken_CancellationToken_, List__Tail$String_String, List__Reverse$String_String, List__Map$Tuple_2_String__String__String_Tuple_2_String__String__String, List__Map$String__String_String_String, List__Head$String_String, List__FoldIndexedAux$list_1_String__Tuple_2_String__String_list_1_String__Tuple_2_String__String_, List__FoldIndexedAux$list_1_String__String_list_1_String__String, List__FoldIndexed$Tuple_2_String__String__list_1_String_Tuple_2_String__String__list_1_String_, List__FoldIndexed$String__list_1_String_String_list_1_String_, List__Fold$Tuple_2_String__String__list_1_String_Tuple_2_String__String__list_1_String_, List__Fold$String__list_1_String_String_list_1_String_, List__Empty$Tuple_2_String__String_Tuple_2_String__String_, List__Empty$String_String, List__CreateCons$Tuple_2_String__String_Tuple_2_String__String_, List__CreateCons$String_String, JsonValue__Null, JsRuntime__TryGetProperty$, JsRuntime__Identity2Of2$, JsRuntime__Identity1Of2$, JsRuntime__Identity$, JsRuntime__GetProperty$, JsRuntime__GetNonOptionalValue$, JsRuntime__GetArrayChildrenByTypeTag$IJsonDocument_IJsonDocument_, JsRuntime__GetArrayChildByTypeTag$, JsRuntime__EmptyString$, JsRuntime__ConvertArray$IJsonDocument_IJsonDocument_, JsHelpers__jstypeof$, JsHelpers__isNull$, JsHelpers__isArray$, JsHelpers__hasProperty$, FunScriptExtensions__number$, FSharpString__Concat$, CreateEnumerable_1_Tuple_2_Int32__Double___ctor$Tuple_2_Int32__Double_, CreateEnumerable_1_Tuple_2_Country__JQuery___ctor$Tuple_2_Country__JQuery_, CreateEnumerable_1_String___ctor$String, CreateEnumerable_1_IJsonDocument___ctor$IJsonDocument_, CreateEnumerable_1_HighchartsDataPoint___ctor$HighchartsDataPoint_, CancellationToken___ctor$, CancellationToken__ThrowIfCancellationRequested$, Async__StartImmediate$, Async__FromContinuations$IEnumerable_1_Tuple_2_Int32__Double_IEnumerable_1_Tuple_2_Int32__Double_, Async_1_protectedCont$Unit_Unit_, Async_1_protectedCont$IEnumerable_1_Tuple_2_Int32__Double_IEnumerable_1_Tuple_2_Int32__Double_, Async_1_invokeCont$Unit_Unit_, Async_1_get_async$, Async_1_Unit__ContUnit_, Async_1_IEnumerable_1_Tuple_2_Int32__Double__ContIEnumerable_1_Tuple_2_Int32__Double_, AsyncParams_1_Unit___ctor$Unit_, AsyncParams_1_Indicator___ctor$Indicator_, AsyncParamsAux___ctor$, AsyncBuilder___ctor$, AsyncBuilder__Zero$, AsyncBuilder__While$, AsyncBuilder__Return$Unit_Unit_, AsyncBuilder__For$Tuple_2_Country__JQuery_Tuple_2_Country__JQuery_, AsyncBuilder__Delay$Unit_Unit_, AsyncBuilder__Combine$Unit_Unit_, AsyncBuilder__Bind$Unit__Unit_Unit__Unit_, AsyncBuilder__Bind$Indicator__Unit_Indicator__Unit_, Array__ZeroCreate$Tuple_2_Country__JQuery_Tuple_2_Country__JQuery_, Array__ZeroCreate$String_String, Array__ZeroCreate$Object_Object_, Array__ZeroCreate$IJsonDocument_IJsonDocument_, Array__ZeroCreate$HighchartsDataPoint_HighchartsDataPoint_, Array__MapIndexed$Object__IJsonDocument_Object__IJsonDocument_, Array__MapIndexed$Country__Tuple_2_Country__JQuery_Country__Tuple_2_Country__JQuery_, Array__Map$Object__IJsonDocument_Object__IJsonDocument_, Array__Length$Tuple_2_Country__JQuery_Tuple_2_Country__JQuery_, Array__Length$Object_Object_, Array__Length$Country_Country_, Array__Iterate$Tuple_2_Country__JQuery_Tuple_2_Country__JQuery_, Array__FoldIndexed$Unit__Tuple_2_Country__JQuery_Unit__Tuple_2_Country__JQuery_, Array__Fold$Tuple_2_Country__JQuery__Unit_Tuple_2_Country__JQuery__Unit_, Array__Choose$Object__Object_Object__Object_, Array__BoxedLength$;
  Array__BoxedLength$ = (function(xs)
  {
    return xs.length;;
  });
  Array__Choose$Object__Object_Object__Object_ = (function(f,xs)
  {
    var ys = Array__ZeroCreate$Object_Object_(0);
    var j = 0;
    for (var i = 0; i <= (Array__Length$Object_Object_(xs) - 1); i++)
    {
      var matchValue = f(xs[i]);
      if ((matchValue.Tag == 0.000000)) 
      {
        ;
      }
      else
      {
        var y = Option__GetValue$Object_Object_(matchValue);
        ys[j] = y;
        null;
        j = (j + 1);
        null;
      };
    };
    return ys;
  });
  Array__Fold$Tuple_2_Country__JQuery__Unit_Tuple_2_Country__JQuery__Unit_ = (function(f,seed,xs)
  {
    return Array__FoldIndexed$Unit__Tuple_2_Country__JQuery_Unit__Tuple_2_Country__JQuery_((function(_arg1)
    {
      return (function(acc)
      {
        return (function(x)
        {
          return f(acc)(x);
        });
      });
    }), seed, xs);
  });
  Array__FoldIndexed$Unit__Tuple_2_Country__JQuery_Unit__Tuple_2_Country__JQuery_ = (function(f,seed,xs)
  {
    var acc = seed;
    for (var i = 0; i <= (Array__Length$Tuple_2_Country__JQuery_Tuple_2_Country__JQuery_(xs) - 1); i++)
    {
      acc = f(i)(acc)(xs[i]);
      null;
    };
    return acc;
  });
  Array__Iterate$Tuple_2_Country__JQuery_Tuple_2_Country__JQuery_ = (function(f,xs)
  {
    var _1656;
    return Array__Fold$Tuple_2_Country__JQuery__Unit_Tuple_2_Country__JQuery__Unit_((function(unitVar0)
    {
      return (function(x)
      {
        return f(x);
      });
    }), _1656, xs);
  });
  Array__Length$Country_Country_ = (function(xs)
  {
    return xs.length;;
  });
  Array__Length$Object_Object_ = (function(xs)
  {
    return xs.length;;
  });
  Array__Length$Tuple_2_Country__JQuery_Tuple_2_Country__JQuery_ = (function(xs)
  {
    return xs.length;;
  });
  Array__Map$Object__IJsonDocument_Object__IJsonDocument_ = (function(f,xs)
  {
    return Array__MapIndexed$Object__IJsonDocument_Object__IJsonDocument_((function(_arg1)
    {
      return (function(x)
      {
        return f(x);
      });
    }), xs);
  });
  Array__MapIndexed$Country__Tuple_2_Country__JQuery_Country__Tuple_2_Country__JQuery_ = (function(f,xs)
  {
    var ys = Array__ZeroCreate$Tuple_2_Country__JQuery_Tuple_2_Country__JQuery_(Array__Length$Country_Country_(xs));
    for (var i = 0; i <= (Array__Length$Country_Country_(xs) - 1); i++)
    {
      ys[i] = f(i)(xs[i]);
      null;
    };
    return ys;
  });
  Array__MapIndexed$Object__IJsonDocument_Object__IJsonDocument_ = (function(f,xs)
  {
    var ys = Array__ZeroCreate$IJsonDocument_IJsonDocument_(Array__Length$Object_Object_(xs));
    for (var i = 0; i <= (Array__Length$Object_Object_(xs) - 1); i++)
    {
      ys[i] = f(i)(xs[i]);
      null;
    };
    return ys;
  });
  Array__ZeroCreate$HighchartsDataPoint_HighchartsDataPoint_ = (function(size)
  {
    return new Array(size);;
  });
  Array__ZeroCreate$IJsonDocument_IJsonDocument_ = (function(size)
  {
    return new Array(size);;
  });
  Array__ZeroCreate$Object_Object_ = (function(size)
  {
    return new Array(size);;
  });
  Array__ZeroCreate$String_String = (function(size)
  {
    return new Array(size);;
  });
  Array__ZeroCreate$Tuple_2_Country__JQuery_Tuple_2_Country__JQuery_ = (function(size)
  {
    return new Array(size);;
  });
  AsyncBuilder__Bind$Indicator__Unit_Indicator__Unit_ = (function(x,_arg1,f)
  {
    var v = _arg1.Item;
    return (function(_f)
    {
      return Async_1_protectedCont$Unit_Unit_(_f);
    })((function(k)
    {
      var cont = (function(a)
      {
        var patternInput = f(a);
        var r = patternInput.Item;
        return r(k);
      });
      return v((new AsyncParams_1_Indicator___ctor$Indicator_(cont, k.Aux)));
    }));
  });
  AsyncBuilder__Bind$Unit__Unit_Unit__Unit_ = (function(x,_arg1,f)
  {
    var v = _arg1.Item;
    return (function(_f)
    {
      return Async_1_protectedCont$Unit_Unit_(_f);
    })((function(k)
    {
      var cont = (function(a)
      {
        var patternInput = f(a);
        var r = patternInput.Item;
        return r(k);
      });
      return v((new AsyncParams_1_Unit___ctor$Unit_(cont, k.Aux)));
    }));
  });
  AsyncBuilder__Combine$Unit_Unit_ = (function(x,work1,work2)
  {
    return AsyncBuilder__Bind$Unit__Unit_Unit__Unit_(x, work1, (function(unitVar0)
    {
      return work2;
    }));
  });
  AsyncBuilder__Delay$Unit_Unit_ = (function(x,f)
  {
    return (function(_f)
    {
      return Async_1_protectedCont$Unit_Unit_(_f);
    })((function(k)
    {
      var _1528;
      var patternInput = f(_1528);
      var r = patternInput.Item;
      return r(k);
    }));
  });
  AsyncBuilder__For$Tuple_2_Country__JQuery_Tuple_2_Country__JQuery_ = (function(x,seq,body)
  {
    var enumerator = seq.GetEnumerator();
    return AsyncBuilder__While$(x, (function(unitVar0)
    {
      return enumerator.MoveNext();
    }), AsyncBuilder__Delay$Unit_Unit_(x, (function(unitVar0)
    {
      return body(enumerator.get_Current());
    })));
  });
  AsyncBuilder__Return$Unit_Unit_ = (function(x,v)
  {
    return (function(f)
    {
      return Async_1_protectedCont$Unit_Unit_(f);
    })((function(k)
    {
      return Async_1_invokeCont$Unit_Unit_(k, v);
    }));
  });
  AsyncBuilder__While$ = (function(x,cond,body)
  {
    var _1536;
    if (cond(_1536)) 
    {
      return AsyncBuilder__Bind$Unit__Unit_Unit__Unit_(x, body, (function(unitVar0)
      {
        return AsyncBuilder__While$(x, cond, body);
      }));
    }
    else
    {
      var _1565;
      return AsyncBuilder__Return$Unit_Unit_(x, _1565);
    };
  });
  AsyncBuilder__Zero$ = (function(x,unitVar1)
  {
    return (function(f)
    {
      return Async_1_protectedCont$Unit_Unit_(f);
    })((function(k)
    {
      var _1484;
      return Async_1_invokeCont$Unit_Unit_(k, _1484);
    }));
  });
  AsyncBuilder___ctor$ = (function(unitVar0)
  {
    ;
  });
  AsyncParamsAux___ctor$ = (function(StackCounter,ExceptionCont,CancelledCont,CancellationToken)
  {
    var __this = this;
    __this.StackCounter = StackCounter;
    __this.ExceptionCont = ExceptionCont;
    __this.CancelledCont = CancelledCont;
    __this.CancellationToken = CancellationToken;
  });
  AsyncParams_1_Indicator___ctor$Indicator_ = (function(Cont,Aux)
  {
    var __this = this;
    __this.Cont = Cont;
    __this.Aux = Aux;
  });
  AsyncParams_1_Unit___ctor$Unit_ = (function(Cont,Aux)
  {
    var __this = this;
    __this.Cont = Cont;
    __this.Aux = Aux;
  });
  Async_1_IEnumerable_1_Tuple_2_Int32__Double__ContIEnumerable_1_Tuple_2_Int32__Double_ = (function(Item)
  {
    var __this = this;
    __this.Tag = 0.000000;
    __this._CaseName = "Cont";
    __this.Item = Item;
  });
  Async_1_Unit__ContUnit_ = (function(Item)
  {
    var __this = this;
    __this.Tag = 0.000000;
    __this._CaseName = "Cont";
    __this.Item = Item;
  });
  Async_1_get_async$ = (function()
  {
    return (new AsyncBuilder___ctor$());
  });
  Async_1_invokeCont$Unit_Unit_ = (function(k,value)
  {
    return k.Cont(value);
  });
  Async_1_protectedCont$IEnumerable_1_Tuple_2_Int32__Double_IEnumerable_1_Tuple_2_Int32__Double_ = (function(f)
  {
    return (new Async_1_IEnumerable_1_Tuple_2_Int32__Double__ContIEnumerable_1_Tuple_2_Int32__Double_((function(args)
    {
      CancellationToken__ThrowIfCancellationRequested$(args.Aux.CancellationToken);
      args.Aux.StackCounter.contents = (args.Aux.StackCounter.contents + 1);
      null;
      if ((args.Aux.StackCounter.contents > 1000)) 
      {
        args.Aux.StackCounter.contents = 0;
        null;
        return window.setTimeout((function(unitVar0)
        {
          try
          {
            return f(args);
          }
          catch(ex){
            return args.Aux.ExceptionCont(ex);
          };
        }), 1.000000);
      }
      else
      {
        try
        {
          return f(args);
        }
        catch(ex){
          return args.Aux.ExceptionCont(ex);
        };
      };
    })));
  });
  Async_1_protectedCont$Unit_Unit_ = (function(f)
  {
    return (new Async_1_Unit__ContUnit_((function(args)
    {
      CancellationToken__ThrowIfCancellationRequested$(args.Aux.CancellationToken);
      args.Aux.StackCounter.contents = (args.Aux.StackCounter.contents + 1);
      null;
      if ((args.Aux.StackCounter.contents > 1000)) 
      {
        args.Aux.StackCounter.contents = 0;
        null;
        return window.setTimeout((function(unitVar0)
        {
          try
          {
            return f(args);
          }
          catch(ex){
            return args.Aux.ExceptionCont(ex);
          };
        }), 1.000000);
      }
      else
      {
        try
        {
          return f(args);
        }
        catch(ex){
          return args.Aux.ExceptionCont(ex);
        };
      };
    })));
  });
  Async__FromContinuations$IEnumerable_1_Tuple_2_Int32__Double_IEnumerable_1_Tuple_2_Int32__Double_ = (function(f)
  {
    return (function(_f)
    {
      return Async_1_protectedCont$IEnumerable_1_Tuple_2_Int32__Double_IEnumerable_1_Tuple_2_Int32__Double_(_f);
    })((function(k)
    {
      return f((new TupleFSharpFunc_2_IEnumerable_1_Tuple_2_Int32__Double__Unit__FSharpFunc_2_Exception__Unit__FSharpFunc_2_String__Unit_(k.Cont, k.Aux.ExceptionCont, k.Aux.CancelledCont)));
    }));
  });
  Async__StartImmediate$ = (function(workflow,cancellationToken)
  {
    var _1601;
    if ((cancellationToken.Tag == 1.000000)) 
    {
      var v = Option__GetValue$CancellationToken_CancellationToken_(cancellationToken);
      _1601 = v;
    }
    else
    {
      _1601 = (new CancellationToken___ctor$({Tag: 0.000000}));
    };
    var token = _1601;
    var f = workflow.Item;
    var aux = (new AsyncParamsAux___ctor$({contents: 0}, (function(value)
    {
      var ignored0 = value;
    }), (function(value)
    {
      var ignored0 = value;
    }), token));
    return f((new AsyncParams_1_Unit___ctor$Unit_((function(value)
    {
      var ignored0 = value;
    }), aux)));
  });
  CancellationToken__ThrowIfCancellationRequested$ = (function(x,unitVar1)
  {
    var matchValue = x.Cell;
    if ((matchValue.Tag == 1.000000)) 
    {
      var cell = Option__GetValue$FSharpRef_1_Boolean_FSharpRef_1_Boolean_(matchValue);
      if (cell.contents) 
      {
        var _cell = Option__GetValue$FSharpRef_1_Boolean_FSharpRef_1_Boolean_(matchValue);
        throw ("OperationCancelledException");
        return null;
      }
      else
      {
        ;
      };
    }
    else
    {
      ;
    };
  });
  CancellationToken___ctor$ = (function(Cell)
  {
    var __this = this;
    __this.Cell = Cell;
  });
  CreateEnumerable_1_HighchartsDataPoint___ctor$HighchartsDataPoint_ = (function(factory)
  {
    var __this = this;
    __this.factory = factory;
  });
  CreateEnumerable_1_IJsonDocument___ctor$IJsonDocument_ = (function(factory)
  {
    var __this = this;
    __this.factory = factory;
  });
  CreateEnumerable_1_String___ctor$String = (function(factory)
  {
    var __this = this;
    __this.factory = factory;
  });
  CreateEnumerable_1_Tuple_2_Country__JQuery___ctor$Tuple_2_Country__JQuery_ = (function(factory)
  {
    var __this = this;
    __this.factory = factory;
  });
  CreateEnumerable_1_Tuple_2_Int32__Double___ctor$Tuple_2_Int32__Double_ = (function(factory)
  {
    var __this = this;
    __this.factory = factory;
  });
  FSharpString__Concat$ = (function(sep,strings)
  {
    return Seq__ToArray$String_String(strings).join(sep);
  });
  FunScriptExtensions__number$ = (function(a)
  {
    return a*1.0;;
  });
  JsHelpers__hasProperty$ = (function(o,name)
  {
    return typeof(o[name]) != "undefined";;
  });
  JsHelpers__isArray$ = (function(o)
  {
    return Array.isArray(o);;
  });
  JsHelpers__isNull$ = (function(o)
  {
    return o==null;;
  });
  JsHelpers__jstypeof$ = (function(o)
  {
    return typeof(o);;
  });
  JsRuntime__ConvertArray$IJsonDocument_IJsonDocument_ = (function(value,mapping)
  {
    return value;;
  });
  JsRuntime__EmptyString$ = (function(arg)
  {
    return "";;
  });
  JsRuntime__GetArrayChildByTypeTag$ = (function(value,cultureStr,tagCode)
  {
    var arr = JsRuntime__GetArrayChildrenByTypeTag$IJsonDocument_IJsonDocument_(value, cultureStr, tagCode, (function(delegateArg)
    {
      return delegateArg;
    }));
    if ((Array__BoxedLength$(arr) == 1)) 
    {
      return arr[0];
    }
    else
    {
      throw ("JSON mismatch: Expected single value, but found multiple.");
      return null;
    };
  });
  JsRuntime__GetArrayChildrenByTypeTag$IJsonDocument_IJsonDocument_ = (function(doc,cultureStr,tagCode,mapping)
  {
    var matchTag = (function(value)
    {
      if (JsHelpers__isNull$(value)) 
      {
        return {Tag: 0.000000};
      }
      else
      {
        if (((JsHelpers__jstypeof$(value) == "boolean") && (tagCode == "Boolean"))) 
        {
          return {Tag: 1.000000, Value: value};
        }
        else
        {
          if (((JsHelpers__jstypeof$(value) == "number") && (tagCode == "Number"))) 
          {
            return {Tag: 1.000000, Value: value};
          }
          else
          {
            if (((JsHelpers__jstypeof$(value) == "string") && (tagCode == "Number"))) 
            {
              return {Tag: 1.000000, Value: (1 * value)};
            }
            else
            {
              if (((JsHelpers__jstypeof$(value) == "string") && (tagCode == "String"))) 
              {
                return {Tag: 1.000000, Value: value};
              }
              else
              {
                if ((JsHelpers__isArray$(value) && (tagCode == "Array"))) 
                {
                  return {Tag: 1.000000, Value: value};
                }
                else
                {
                  if (((JsHelpers__jstypeof$(value) == "object") && (tagCode == "Record"))) 
                  {
                    return {Tag: 1.000000, Value: value};
                  }
                  else
                  {
                    return {Tag: 0.000000};
                  };
                };
              };
            };
          };
        };
      };
    });
    if (JsHelpers__isArray$(doc)) 
    {
      var _mapping = (function(x)
      {
        return (function(arg00)
        {
          return mapping(arg00);
        })((function(value)
        {
          return value;
        })(x));
      });
      var chooser = matchTag;
      return (function(array)
      {
        return Array__Map$Object__IJsonDocument_Object__IJsonDocument_(_mapping, array);
      })((function(array)
      {
        return Array__Choose$Object__Object_Object__Object_(chooser, array);
      })((function(value)
      {
        return value;
      })(doc)));
    }
    else
    {
      throw ("JSON mismatch: Expected Array node");
      return null;
    };
  });
  JsRuntime__GetNonOptionalValue$ = (function(path,json,original)
  {
    if ((json.Tag == 0.000000)) 
    {
      return (new JsonValue__Null());
    }
    else
    {
      var j = Option__GetValue$JsonValue_JsonValue_(json);
      return j;
    };
  });
  JsRuntime__GetProperty$ = (function(json,name)
  {
    return json[name];;
  });
  JsRuntime__Identity$ = (function(arg)
  {
    return arg;;
  });
  JsRuntime__Identity1Of2$ = (function(arg,arg2)
  {
    return arg;;
  });
  JsRuntime__Identity2Of2$ = (function(arg,arg2)
  {
    return arg2;;
  });
  JsRuntime__TryGetProperty$ = (function(json,name)
  {
    if (JsHelpers__hasProperty$(json, name)) 
    {
      return (function(arg0)
      {
        return {Tag: 1.000000, Value: arg0};
      })(JsRuntime__GetProperty$(json, name));
    }
    else
    {
      return {Tag: 0.000000};
    };
  });
  JsonValue__Null = (function()
  {
    var __this = this;
    __this.Tag = 6.000000;
    __this._CaseName = "Null";
  });
  List__CreateCons$String_String = (function(x,xs)
  {
    return (new list_1_String__ConsString(x, xs));
  });
  List__CreateCons$Tuple_2_String__String_Tuple_2_String__String_ = (function(x,xs)
  {
    return (new list_1_Tuple_2_String__String__ConsTuple_2_String__String_(x, xs));
  });
  List__Empty$String_String = (function()
  {
    return (new list_1_String__NilString());
  });
  List__Empty$Tuple_2_String__String_Tuple_2_String__String_ = (function()
  {
    return (new list_1_Tuple_2_String__String__NilTuple_2_String__String_());
  });
  List__Fold$String__list_1_String_String_list_1_String_ = (function(f,seed,xs)
  {
    return List__FoldIndexed$String__list_1_String_String_list_1_String_((function(_arg1)
    {
      return (function(acc)
      {
        return (function(x)
        {
          return f(acc)(x);
        });
      });
    }), seed, xs);
  });
  List__Fold$Tuple_2_String__String__list_1_String_Tuple_2_String__String__list_1_String_ = (function(f,seed,xs)
  {
    return List__FoldIndexed$Tuple_2_String__String__list_1_String_Tuple_2_String__String__list_1_String_((function(_arg1)
    {
      return (function(acc)
      {
        return (function(x)
        {
          return f(acc)(x);
        });
      });
    }), seed, xs);
  });
  List__FoldIndexed$String__list_1_String_String_list_1_String_ = (function(f,seed,xs)
  {
    return List__FoldIndexedAux$list_1_String__String_list_1_String__String(f, 0, seed, xs);
  });
  List__FoldIndexed$Tuple_2_String__String__list_1_String_Tuple_2_String__String__list_1_String_ = (function(f,seed,xs)
  {
    return List__FoldIndexedAux$list_1_String__Tuple_2_String__String_list_1_String__Tuple_2_String__String_(f, 0, seed, xs);
  });
  List__FoldIndexedAux$list_1_String__String_list_1_String__String = (function(f,i,acc,_arg1)
  {
    if ((_arg1.Tag == 1.000000)) 
    {
      var xs = _arg1.Item2;
      var x = _arg1.Item1;
      return List__FoldIndexedAux$list_1_String__String_list_1_String__String(f, (i + 1), f(i)(acc)(x), xs);
    }
    else
    {
      return acc;
    };
  });
  List__FoldIndexedAux$list_1_String__Tuple_2_String__String_list_1_String__Tuple_2_String__String_ = (function(f,i,acc,_arg1)
  {
    if ((_arg1.Tag == 1.000000)) 
    {
      var xs = _arg1.Item2;
      var x = _arg1.Item1;
      return List__FoldIndexedAux$list_1_String__Tuple_2_String__String_list_1_String__Tuple_2_String__String_(f, (i + 1), f(i)(acc)(x), xs);
    }
    else
    {
      return acc;
    };
  });
  List__Head$String_String = (function(_arg1)
  {
    if ((_arg1.Tag == 1.000000)) 
    {
      var xs = _arg1.Item2;
      var x = _arg1.Item1;
      return x;
    }
    else
    {
      throw ("List was empty");
      return null;
    };
  });
  List__Map$String__String_String_String = (function(f,xs)
  {
    return (function(_xs)
    {
      return List__Reverse$String_String(_xs);
    })(List__Fold$String__list_1_String_String_list_1_String_((function(acc)
    {
      return (function(x)
      {
        return (new list_1_String__ConsString(f(x), acc));
      });
    }), (new list_1_String__NilString()), xs));
  });
  List__Map$Tuple_2_String__String__String_Tuple_2_String__String__String = (function(f,xs)
  {
    return (function(_xs)
    {
      return List__Reverse$String_String(_xs);
    })(List__Fold$Tuple_2_String__String__list_1_String_Tuple_2_String__String__list_1_String_((function(acc)
    {
      return (function(x)
      {
        return (new list_1_String__ConsString(f(x), acc));
      });
    }), (new list_1_String__NilString()), xs));
  });
  List__Reverse$String_String = (function(xs)
  {
    return List__Fold$String__list_1_String_String_list_1_String_((function(acc)
    {
      return (function(x)
      {
        return (new list_1_String__ConsString(x, acc));
      });
    }), (new list_1_String__NilString()), xs);
  });
  List__Tail$String_String = (function(_arg1)
  {
    if ((_arg1.Tag == 1.000000)) 
    {
      var xs = _arg1.Item2;
      var x = _arg1.Item1;
      return xs;
    }
    else
    {
      throw ("List was empty");
      return null;
    };
  });
  Option__GetValue$CancellationToken_CancellationToken_ = (function(option)
  {
    return option.Value;;
  });
  Option__GetValue$Decimal_Decimal = (function(option)
  {
    return option.Value;;
  });
  Option__GetValue$FSharpList_1_String_FSharpList_1_String_ = (function(option)
  {
    return option.Value;;
  });
  Option__GetValue$FSharpRef_1_Boolean_FSharpRef_1_Boolean_ = (function(option)
  {
    return option.Value;;
  });
  Option__GetValue$IEnumerator_1_IJsonDocument_IEnumerator_1_IJsonDocument_ = (function(option)
  {
    return option.Value;;
  });
  Option__GetValue$IEnumerator_1_Tuple_2_Int32__Double_IEnumerator_1_Tuple_2_Int32__Double_ = (function(option)
  {
    return option.Value;;
  });
  Option__GetValue$Int32_Int32 = (function(option)
  {
    return option.Value;;
  });
  Option__GetValue$JsonValue_JsonValue_ = (function(option)
  {
    return option.Value;;
  });
  Option__GetValue$Object_Object_ = (function(option)
  {
    return option.Value;;
  });
  Option__GetValue$Tuple_2_HighchartsDataPoint__IEnumerator_1_Tuple_2_Int32__Double_Tuple_2_HighchartsDataPoint__IEnumerator_1_Tuple_2_Int32__Double_ = (function(option)
  {
    return option.Value;;
  });
  Option__GetValue$Tuple_2_IJsonDocument__Int32_Tuple_2_IJsonDocument__Int32_ = (function(option)
  {
    return option.Value;;
  });
  Option__GetValue$Tuple_2_Int32__Double_Tuple_2_Int32__Double_ = (function(option)
  {
    return option.Value;;
  });
  Option__GetValue$Tuple_2_String__FSharpList_1_String_Tuple_2_String__FSharpList_1_String_ = (function(option)
  {
    return option.Value;;
  });
  Option__GetValue$Tuple_2_Tuple_2_Country__JQuery__Int32_Tuple_2_Tuple_2_Country__JQuery__Int32_ = (function(option)
  {
    return option.Value;;
  });
  Option__GetValue$Tuple_2_Tuple_2_Int32__Double__IEnumerator_1_IJsonDocument_Tuple_2_Tuple_2_Int32__Double__IEnumerator_1_IJsonDocument_ = (function(option)
  {
    return option.Value;;
  });
  Option__IsSome$FSharpList_1_String_FSharpList_1_String_ = (function(option)
  {
    return ((option.Tag == 1.000000) && true);
  });
  Option__IsSome$IEnumerator_1_IJsonDocument_IEnumerator_1_IJsonDocument_ = (function(option)
  {
    return ((option.Tag == 1.000000) && true);
  });
  Option__IsSome$IEnumerator_1_Tuple_2_Int32__Double_IEnumerator_1_Tuple_2_Int32__Double_ = (function(option)
  {
    return ((option.Tag == 1.000000) && true);
  });
  Option__IsSome$Int32_Int32 = (function(option)
  {
    return ((option.Tag == 1.000000) && true);
  });
  Program__countries$ = (function(unitVar0)
  {
    var _this = WorldBankRuntime__GetCountries$(Program__data);
    var __this = WorldBankRuntime__GetCountries$(Program__data);
    var ___this = WorldBankRuntime__GetCountries$(Program__data);
    return [WorldBankRuntime__GetCountry$(_this, "EST", "Estonia"), WorldBankRuntime__GetCountry$(__this, "EUU", "European Union"), WorldBankRuntime__GetCountry$(___this, "LVA", "Latvia")];
  });
  Program__get_data$ = (function()
  {
    return {ServiceUrl: "http://api.worldbank.org", Source: "World Development Indicators;Global Financial Development"};
  });
  Program__jq$ = (function(selector)
  {
    return ((window.$)(selector));
  });
  Program__main$ = (function(unitVar0)
  {
    var infos = Program__makeCheckInfos$();
    var render = (function(_unitVar0)
    {
      return (function(builder_)
      {
        return AsyncBuilder__Delay$Unit_Unit_(builder_, (function(unitVar)
        {
          var opts = ({});
          var titleOptions = ({});
          (titleOptions.text) = "School enrollment, tertiary (% gross)";
          null;
          (opts.title) = titleOptions;
          null;
          var subTitleOptions = ({});
          (subTitleOptions.text) = "Source: WorldBank";
          null;
          (opts.subtitle) = subTitleOptions;
          null;
          (opts.series) = [];
          null;
          return AsyncBuilder__Combine$Unit_Unit_(builder_, AsyncBuilder__For$Tuple_2_Country__JQuery_Tuple_2_Country__JQuery_(builder_, Seq__OfArray$Tuple_2_Country__JQuery_Tuple_2_Country__JQuery_(infos), (function(_arg1)
          {
            var country = _arg1.Items[0.000000];
            var check = _arg1.Items[1.000000];
            if ((check.is(":checked"))) 
            {
              var _this = WorldBankRuntime__GetIndicators$(country);
              return AsyncBuilder__Bind$Indicator__Unit_Indicator__Unit_(builder_, WorldBankRuntime__AsyncGetIndicator$(_this, "SE.TER.ENRR"), (function(_arg2)
              {
                var vals = _arg2;
                var mapping = (function(tupledArg)
                {
                  var k = tupledArg.Items[0.000000];
                  var v = tupledArg.Items[1.000000];
                  var p = ({});
                  (p.x) = FunScriptExtensions__number$(k);
                  null;
                  (p.y) = FunScriptExtensions__number$(v);
                  null;
                  return p;
                });
                var data = (function(source)
                {
                  return Seq__ToArray$HighchartsDataPoint_HighchartsDataPoint_(source);
                })((function(source)
                {
                  return Seq__Map$Tuple_2_Int32__Double__HighchartsDataPoint_Tuple_2_Int32__Double__HighchartsDataPoint_(mapping, source);
                })(vals));
                var series = ({});
                (series.data) = data;
                null;
                (series.name) = country.Name;
                null;
                (series.type) = "line";
                null;
                (function(value)
                {
                  var ignored0 = value;
                })(((opts.series).push(series)));
                return AsyncBuilder__Zero$(builder_);
              }));
            }
            else
            {
              return AsyncBuilder__Zero$(builder_);
            };
          })), AsyncBuilder__Delay$Unit_Unit_(builder_, (function(_unitVar)
          {
            var chartElement = Program__op_Dynamic$JQuery_JQuery_((function(selector)
            {
              return Program__jq$(selector);
            }), "chart");
            (function(value)
            {
              var ignored0 = value;
            })((chartElement.highcharts(opts)));
            return AsyncBuilder__Zero$(builder_);
          })));
        }));
      })(Async_1_get_async$());
    });
    var _1626;
    (function(arg00)
    {
      return Async__StartImmediate$(arg00, {Tag: 0.000000});
    })(render(_1626));
    var action = (function(tupledArg)
    {
      var _arg2 = tupledArg.Items[0.000000];
      var check = tupledArg.Items[1.000000];
      return (function(value)
      {
        var ignored0 = value;
      })((check.click((function(_arg1)
      {
        var _1648;
        return (function(value)
        {
          return value;
        })((function(arg00)
        {
          return Async__StartImmediate$(arg00, {Tag: 0.000000});
        })(render(_1648)));
      }))));
    });
    return (function(array)
    {
      return Array__Iterate$Tuple_2_Country__JQuery_Tuple_2_Country__JQuery_(action, array);
    })(infos);
  });
  Program__makeCheckInfos$ = (function(unitVar0)
  {
    var mapping = (function(index)
    {
      return (function(country)
      {
        var input = Program__jq$("\u003cinput\u003e");
        (function(value)
        {
          var ignored0 = value;
        })((input.attr("type", "checkbox")));
        var label = Program__jq$("\u003clabel\u003e");
        (function(value)
        {
          var ignored0 = value;
        })((label.append([input])));
        (function(value)
        {
          var ignored0 = value;
        })((label.append([country.Name])));
        var panel = ((index % 2) + 1);
        var panelId = ("#countryList" + panel.toString());
        (function(value)
        {
          var ignored0 = value;
        })((label.appendTo(Program__jq$(panelId))));
        return (new TupleCountry__JQuery_(country, input));
      });
    });
    return (function(array)
    {
      return Array__MapIndexed$Country__Tuple_2_Country__JQuery_Country__Tuple_2_Country__JQuery_(mapping, array);
    })(Program__countries$());
  });
  Program__op_Dynamic$JQuery_JQuery_ = (function(jq,name)
  {
    return jq(("#" + name));
  });
  Runtime__worldBankUrl$ = (function(wb,functions,props)
  {
    var sep = "";
    var mapping = (function(m)
    {
      return ("/" + Utils__encodeURIComponent$(m));
    });
    var _sep = "";
    var _mapping = (function(tupledArg)
    {
      var key = tupledArg.Items[0.000000];
      var value = tupledArg.Items[1.000000];
      return ((("\u0026" + key) + "=") + Utils__encodeURIComponent$(value));
    });
    return ((((wb.ServiceUrl + "/") + (function(strings)
    {
      return FSharpString__Concat$(sep, Seq__OfList$String_String(strings));
    })((function(list)
    {
      return List__Map$String__String_String_String(mapping, list);
    })(functions))) + "?per_page=1000") + (function(strings)
    {
      return FSharpString__Concat$(_sep, Seq__OfList$String_String(strings));
    })((function(list)
    {
      return List__Map$Tuple_2_String__String__String_Tuple_2_String__String__String(_mapping, list);
    })(props)));
  });
  Seq__Choose$IJsonDocument__Tuple_2_Int32__Double_IJsonDocument__Tuple_2_Int32__Double_ = (function(f,xs)
  {
    var trySkipToNext;
    trySkipToNext = (function(_enum)
    {
      if (_enum.MoveNext()) 
      {
        var matchValue = f(_enum.get_Current());
        if ((matchValue.Tag == 1.000000)) 
        {
          var value = Option__GetValue$Tuple_2_Int32__Double_Tuple_2_Int32__Double_(matchValue);
          return {Tag: 1.000000, Value: (new TupleTuple_2_Int32__Double__IEnumerator_1_IJsonDocument_(value, _enum))};
        }
        else
        {
          return trySkipToNext(_enum);
        };
      }
      else
      {
        return {Tag: 0.000000};
      };
    });
    return (function(_f)
    {
      return Seq__Delay$Tuple_2_Int32__Double_Tuple_2_Int32__Double_(_f);
    })((function(unitVar0)
    {
      var _f = trySkipToNext;
      return (function(seed)
      {
        return Seq__Unfold$IEnumerator_1_IJsonDocument__Tuple_2_Int32__Double_IEnumerator_1_IJsonDocument__Tuple_2_Int32__Double_(_f, seed);
      })(Seq__Enumerator$IJsonDocument_IJsonDocument_(xs));
    }));
  });
  Seq__Delay$HighchartsDataPoint_HighchartsDataPoint_ = (function(f)
  {
    return Seq__FromFactory$HighchartsDataPoint_HighchartsDataPoint_((function(unitVar0)
    {
      var _1262;
      return Seq__Enumerator$HighchartsDataPoint_HighchartsDataPoint_(f(_1262));
    }));
  });
  Seq__Delay$Tuple_2_Int32__Double_Tuple_2_Int32__Double_ = (function(f)
  {
    return Seq__FromFactory$Tuple_2_Int32__Double_Tuple_2_Int32__Double_((function(unitVar0)
    {
      var _763;
      return Seq__Enumerator$Tuple_2_Int32__Double_Tuple_2_Int32__Double_(f(_763));
    }));
  });
  Seq__Enumerator$HighchartsDataPoint_HighchartsDataPoint_ = (function(xs)
  {
    return xs.GetEnumerator();
  });
  Seq__Enumerator$IJsonDocument_IJsonDocument_ = (function(xs)
  {
    return xs.GetEnumerator();
  });
  Seq__Enumerator$String_String = (function(xs)
  {
    return xs.GetEnumerator();
  });
  Seq__Enumerator$Tuple_2_Int32__Double_Tuple_2_Int32__Double_ = (function(xs)
  {
    return xs.GetEnumerator();
  });
  Seq__FoldIndexed$HighchartsDataPoint__Unit_HighchartsDataPoint__Unit_ = (function(f,seed,xs)
  {
    return Seq__FoldIndexedAux$Unit__HighchartsDataPoint_Unit__HighchartsDataPoint_(f, seed, Seq__Enumerator$HighchartsDataPoint_HighchartsDataPoint_(xs));
  });
  Seq__FoldIndexed$String__Unit_String_Unit_ = (function(f,seed,xs)
  {
    return Seq__FoldIndexedAux$Unit__String_Unit__String(f, seed, Seq__Enumerator$String_String(xs));
  });
  Seq__FoldIndexedAux$Unit__HighchartsDataPoint_Unit__HighchartsDataPoint_ = (function(f,acc,xs)
  {
    var i = {contents: 0};
    var _acc = {contents: acc};
    while (xs.MoveNext())
    {
      _acc.contents = f(i.contents)(_acc.contents)(xs.get_Current());
      null;
      i.contents = (i.contents + 1);
      null;
    };
    return _acc.contents;
  });
  Seq__FoldIndexedAux$Unit__String_Unit__String = (function(f,acc,xs)
  {
    var i = {contents: 0};
    var _acc = {contents: acc};
    while (xs.MoveNext())
    {
      _acc.contents = f(i.contents)(_acc.contents)(xs.get_Current());
      null;
      i.contents = (i.contents + 1);
      null;
    };
    return _acc.contents;
  });
  Seq__FromFactory$HighchartsDataPoint_HighchartsDataPoint_ = (function(f)
  {
    var impl;
    impl = (new CreateEnumerable_1_HighchartsDataPoint___ctor$HighchartsDataPoint_(f));
    return {GetEnumerator: (function(unitVar1)
    {
      return (function(__,unitVar1)
      {
        var _1265;
        return __.factory(_1265);
      })(impl, unitVar1);
    })};
  });
  Seq__FromFactory$IJsonDocument_IJsonDocument_ = (function(f)
  {
    var impl;
    impl = (new CreateEnumerable_1_IJsonDocument___ctor$IJsonDocument_(f));
    return {GetEnumerator: (function(unitVar1)
    {
      return (function(__,unitVar1)
      {
        var _752;
        return __.factory(_752);
      })(impl, unitVar1);
    })};
  });
  Seq__FromFactory$String_String = (function(f)
  {
    var impl;
    impl = (new CreateEnumerable_1_String___ctor$String(f));
    return {GetEnumerator: (function(unitVar1)
    {
      return (function(__,unitVar1)
      {
        var _400;
        return __.factory(_400);
      })(impl, unitVar1);
    })};
  });
  Seq__FromFactory$Tuple_2_Country__JQuery_Tuple_2_Country__JQuery_ = (function(f)
  {
    var impl;
    impl = (new CreateEnumerable_1_Tuple_2_Country__JQuery___ctor$Tuple_2_Country__JQuery_(f));
    return {GetEnumerator: (function(unitVar1)
    {
      return (function(__,unitVar1)
      {
        var _217;
        return __.factory(_217);
      })(impl, unitVar1);
    })};
  });
  Seq__FromFactory$Tuple_2_Int32__Double_Tuple_2_Int32__Double_ = (function(f)
  {
    var impl;
    impl = (new CreateEnumerable_1_Tuple_2_Int32__Double___ctor$Tuple_2_Int32__Double_(f));
    return {GetEnumerator: (function(unitVar1)
    {
      return (function(__,unitVar1)
      {
        var _767;
        return __.factory(_767);
      })(impl, unitVar1);
    })};
  });
  Seq__IterateIndexed$HighchartsDataPoint_HighchartsDataPoint_ = (function(f,xs)
  {
    var _1182;
    return Seq__FoldIndexed$HighchartsDataPoint__Unit_HighchartsDataPoint__Unit_((function(i)
    {
      return (function(unitVar1)
      {
        return (function(x)
        {
          return f(i)(x);
        });
      });
    }), _1182, xs);
  });
  Seq__IterateIndexed$String_String = (function(f,xs)
  {
    var _424;
    return Seq__FoldIndexed$String__Unit_String_Unit_((function(i)
    {
      return (function(unitVar1)
      {
        return (function(x)
        {
          return f(i)(x);
        });
      });
    }), _424, xs);
  });
  Seq__Map$Tuple_2_Int32__Double__HighchartsDataPoint_Tuple_2_Int32__Double__HighchartsDataPoint_ = (function(f,xs)
  {
    return (function(_f)
    {
      return Seq__Delay$HighchartsDataPoint_HighchartsDataPoint_(_f);
    })((function(unitVar0)
    {
      var _f = (function(_enum)
      {
        if (_enum.MoveNext()) 
        {
          return {Tag: 1.000000, Value: (new TupleHighchartsDataPoint__IEnumerator_1_Tuple_2_Int32__Double_(f(_enum.get_Current()), _enum))};
        }
        else
        {
          return {Tag: 0.000000};
        };
      });
      return (function(seed)
      {
        return Seq__Unfold$IEnumerator_1_Tuple_2_Int32__Double__HighchartsDataPoint_IEnumerator_1_Tuple_2_Int32__Double__HighchartsDataPoint_(_f, seed);
      })(Seq__Enumerator$Tuple_2_Int32__Double_Tuple_2_Int32__Double_(xs));
    }));
  });
  Seq__OfArray$IJsonDocument_IJsonDocument_ = (function(xs)
  {
    var f = (function(i)
    {
      if ((i < Array__BoxedLength$(xs))) 
      {
        return {Tag: 1.000000, Value: (new TupleIJsonDocument__Int32(xs[i], (i + 1)))};
      }
      else
      {
        return {Tag: 0.000000};
      };
    });
    return (function(seed)
    {
      return Seq__Unfold$Int32__IJsonDocument_Int32_IJsonDocument_(f, seed);
    })(0);
  });
  Seq__OfArray$Tuple_2_Country__JQuery_Tuple_2_Country__JQuery_ = (function(xs)
  {
    var f = (function(i)
    {
      if ((i < Array__BoxedLength$(xs))) 
      {
        return {Tag: 1.000000, Value: (new TupleTuple_2_Country__JQuery__Int32(xs[i], (i + 1)))};
      }
      else
      {
        return {Tag: 0.000000};
      };
    });
    return (function(seed)
    {
      return Seq__Unfold$Int32__Tuple_2_Country__JQuery_Int32_Tuple_2_Country__JQuery_(f, seed);
    })(0);
  });
  Seq__OfList$String_String = (function(xs)
  {
    var f = (function(_arg1)
    {
      if ((_arg1.Tag == 1.000000)) 
      {
        var _xs = List__Tail$String_String(_arg1);
        var x = List__Head$String_String(_arg1);
        return {Tag: 1.000000, Value: (new TupleString_FSharpList_1_String_(x, _xs))};
      }
      else
      {
        return {Tag: 0.000000};
      };
    });
    return (function(seed)
    {
      return Seq__Unfold$FSharpList_1_String__String_FSharpList_1_String__String(f, seed);
    })(xs);
  });
  Seq__ToArray$HighchartsDataPoint_HighchartsDataPoint_ = (function(xs)
  {
    var ys = Array__ZeroCreate$HighchartsDataPoint_HighchartsDataPoint_(0);
    var f = (function(i)
    {
      return (function(x)
      {
        ys[i] = x;
        return null;
      });
    });
    (function(_xs)
    {
      return Seq__IterateIndexed$HighchartsDataPoint_HighchartsDataPoint_(f, _xs);
    })(xs);
    return ys;
  });
  Seq__ToArray$String_String = (function(xs)
  {
    var ys = Array__ZeroCreate$String_String(0);
    var f = (function(i)
    {
      return (function(x)
      {
        ys[i] = x;
        return null;
      });
    });
    (function(_xs)
    {
      return Seq__IterateIndexed$String_String(f, _xs);
    })(xs);
    return ys;
  });
  Seq__Unfold$FSharpList_1_String__String_FSharpList_1_String__String = (function(f,seed)
  {
    return Seq__FromFactory$String_String((function(unitVar0)
    {
      var impl;
      impl = (new UnfoldEnumerator_2_FSharpList_1_String__String___ctor$FSharpList_1_String__String(seed, f));
      return {get_Current: (function(unitVar1)
      {
        return (function(__,unitVar1)
        {
          return __.current;
        })(impl, unitVar1);
      }), Dispose: (function(unitVar1)
      {
        return (function(__,unitVar1)
        {
          ;
        })(impl, unitVar1);
      }), MoveNext: (function(unitVar1)
      {
        return (function(__,unitVar1)
        {
          var next = (function(_unitVar0)
          {
            var currAcc = Option__GetValue$FSharpList_1_String_FSharpList_1_String_(__.acc);
            var x = __.unfold(currAcc);
            if ((x.Tag == 1.000000)) 
            {
              var value = Option__GetValue$Tuple_2_String__FSharpList_1_String_Tuple_2_String__FSharpList_1_String_(x).Items[0.000000];
              var nextAcc = Option__GetValue$Tuple_2_String__FSharpList_1_String_Tuple_2_String__FSharpList_1_String_(x).Items[1.000000];
              __.acc = {Tag: 1.000000, Value: nextAcc};
              __.current = value;
              return true;
            }
            else
            {
              __.acc = {Tag: 0.000000};
              __.current = null;
              return false;
            };
          });
          return (Option__IsSome$FSharpList_1_String_FSharpList_1_String_(__.acc) && (function()
          {
            var _378;
            return next(_378);
          })());
        })(impl, unitVar1);
      }), Reset: (function(unitVar1)
      {
        return (function(__,unitVar1)
        {
          __.acc = {Tag: 1.000000, Value: __.seed};
          __.current = null;
        })(impl, unitVar1);
      })};
    }));
  });
  Seq__Unfold$IEnumerator_1_IJsonDocument__Tuple_2_Int32__Double_IEnumerator_1_IJsonDocument__Tuple_2_Int32__Double_ = (function(f,seed)
  {
    return Seq__FromFactory$Tuple_2_Int32__Double_Tuple_2_Int32__Double_((function(unitVar0)
    {
      var impl;
      impl = (new UnfoldEnumerator_2_IEnumerator_1_IJsonDocument__Tuple_2_Int32__Double___ctor$IEnumerator_1_IJsonDocument__Tuple_2_Int32__Double_(seed, f));
      return {get_Current: (function(unitVar1)
      {
        return (function(__,unitVar1)
        {
          return __.current;
        })(impl, unitVar1);
      }), Dispose: (function(unitVar1)
      {
        return (function(__,unitVar1)
        {
          ;
        })(impl, unitVar1);
      }), MoveNext: (function(unitVar1)
      {
        return (function(__,unitVar1)
        {
          var next = (function(_unitVar0)
          {
            var currAcc = Option__GetValue$IEnumerator_1_IJsonDocument_IEnumerator_1_IJsonDocument_(__.acc);
            var x = __.unfold(currAcc);
            if ((x.Tag == 1.000000)) 
            {
              var value = Option__GetValue$Tuple_2_Tuple_2_Int32__Double__IEnumerator_1_IJsonDocument_Tuple_2_Tuple_2_Int32__Double__IEnumerator_1_IJsonDocument_(x).Items[0.000000];
              var nextAcc = Option__GetValue$Tuple_2_Tuple_2_Int32__Double__IEnumerator_1_IJsonDocument_Tuple_2_Tuple_2_Int32__Double__IEnumerator_1_IJsonDocument_(x).Items[1.000000];
              __.acc = {Tag: 1.000000, Value: nextAcc};
              __.current = value;
              return true;
            }
            else
            {
              __.acc = {Tag: 0.000000};
              __.current = null;
              return false;
            };
          });
          return (Option__IsSome$IEnumerator_1_IJsonDocument_IEnumerator_1_IJsonDocument_(__.acc) && (function()
          {
            var _814;
            return next(_814);
          })());
        })(impl, unitVar1);
      }), Reset: (function(unitVar1)
      {
        return (function(__,unitVar1)
        {
          __.acc = {Tag: 1.000000, Value: __.seed};
          __.current = null;
        })(impl, unitVar1);
      })};
    }));
  });
  Seq__Unfold$IEnumerator_1_Tuple_2_Int32__Double__HighchartsDataPoint_IEnumerator_1_Tuple_2_Int32__Double__HighchartsDataPoint_ = (function(f,seed)
  {
    return Seq__FromFactory$HighchartsDataPoint_HighchartsDataPoint_((function(unitVar0)
    {
      var impl;
      impl = (new UnfoldEnumerator_2_IEnumerator_1_Tuple_2_Int32__Double__HighchartsDataPoint___ctor$IEnumerator_1_Tuple_2_Int32__Double__HighchartsDataPoint_(seed, f));
      return {get_Current: (function(unitVar1)
      {
        return (function(__,unitVar1)
        {
          return __.current;
        })(impl, unitVar1);
      }), Dispose: (function(unitVar1)
      {
        return (function(__,unitVar1)
        {
          ;
        })(impl, unitVar1);
      }), MoveNext: (function(unitVar1)
      {
        return (function(__,unitVar1)
        {
          var next = (function(_unitVar0)
          {
            var currAcc = Option__GetValue$IEnumerator_1_Tuple_2_Int32__Double_IEnumerator_1_Tuple_2_Int32__Double_(__.acc);
            var x = __.unfold(currAcc);
            if ((x.Tag == 1.000000)) 
            {
              var value = Option__GetValue$Tuple_2_HighchartsDataPoint__IEnumerator_1_Tuple_2_Int32__Double_Tuple_2_HighchartsDataPoint__IEnumerator_1_Tuple_2_Int32__Double_(x).Items[0.000000];
              var nextAcc = Option__GetValue$Tuple_2_HighchartsDataPoint__IEnumerator_1_Tuple_2_Int32__Double_Tuple_2_HighchartsDataPoint__IEnumerator_1_Tuple_2_Int32__Double_(x).Items[1.000000];
              __.acc = {Tag: 1.000000, Value: nextAcc};
              __.current = value;
              return true;
            }
            else
            {
              __.acc = {Tag: 0.000000};
              __.current = null;
              return false;
            };
          });
          return (Option__IsSome$IEnumerator_1_Tuple_2_Int32__Double_IEnumerator_1_Tuple_2_Int32__Double_(__.acc) && (function()
          {
            var _1320;
            return next(_1320);
          })());
        })(impl, unitVar1);
      }), Reset: (function(unitVar1)
      {
        return (function(__,unitVar1)
        {
          __.acc = {Tag: 1.000000, Value: __.seed};
          __.current = null;
        })(impl, unitVar1);
      })};
    }));
  });
  Seq__Unfold$Int32__IJsonDocument_Int32_IJsonDocument_ = (function(f,seed)
  {
    return Seq__FromFactory$IJsonDocument_IJsonDocument_((function(unitVar0)
    {
      var impl;
      impl = (new UnfoldEnumerator_2_Int32__IJsonDocument___ctor$Int32_IJsonDocument_(seed, f));
      return {get_Current: (function(unitVar1)
      {
        return (function(__,unitVar1)
        {
          return __.current;
        })(impl, unitVar1);
      }), Dispose: (function(unitVar1)
      {
        return (function(__,unitVar1)
        {
          ;
        })(impl, unitVar1);
      }), MoveNext: (function(unitVar1)
      {
        return (function(__,unitVar1)
        {
          var next = (function(_unitVar0)
          {
            var currAcc = Option__GetValue$Int32_Int32(__.acc);
            var x = __.unfold(currAcc);
            if ((x.Tag == 1.000000)) 
            {
              var value = Option__GetValue$Tuple_2_IJsonDocument__Int32_Tuple_2_IJsonDocument__Int32_(x).Items[0.000000];
              var nextAcc = Option__GetValue$Tuple_2_IJsonDocument__Int32_Tuple_2_IJsonDocument__Int32_(x).Items[1.000000];
              __.acc = {Tag: 1.000000, Value: nextAcc};
              __.current = value;
              return true;
            }
            else
            {
              __.acc = {Tag: 0.000000};
              __.current = null;
              return false;
            };
          });
          return (Option__IsSome$Int32_Int32(__.acc) && (function()
          {
            var _730;
            return next(_730);
          })());
        })(impl, unitVar1);
      }), Reset: (function(unitVar1)
      {
        return (function(__,unitVar1)
        {
          __.acc = {Tag: 1.000000, Value: __.seed};
          __.current = null;
        })(impl, unitVar1);
      })};
    }));
  });
  Seq__Unfold$Int32__Tuple_2_Country__JQuery_Int32_Tuple_2_Country__JQuery_ = (function(f,seed)
  {
    return Seq__FromFactory$Tuple_2_Country__JQuery_Tuple_2_Country__JQuery_((function(unitVar0)
    {
      var impl;
      impl = (new UnfoldEnumerator_2_Int32__Tuple_2_Country__JQuery___ctor$Int32_Tuple_2_Country__JQuery_(seed, f));
      return {get_Current: (function(unitVar1)
      {
        return (function(__,unitVar1)
        {
          return __.current;
        })(impl, unitVar1);
      }), Dispose: (function(unitVar1)
      {
        return (function(__,unitVar1)
        {
          ;
        })(impl, unitVar1);
      }), MoveNext: (function(unitVar1)
      {
        return (function(__,unitVar1)
        {
          var next = (function(_unitVar0)
          {
            var currAcc = Option__GetValue$Int32_Int32(__.acc);
            var x = __.unfold(currAcc);
            if ((x.Tag == 1.000000)) 
            {
              var value = Option__GetValue$Tuple_2_Tuple_2_Country__JQuery__Int32_Tuple_2_Tuple_2_Country__JQuery__Int32_(x).Items[0.000000];
              var nextAcc = Option__GetValue$Tuple_2_Tuple_2_Country__JQuery__Int32_Tuple_2_Tuple_2_Country__JQuery__Int32_(x).Items[1.000000];
              __.acc = {Tag: 1.000000, Value: nextAcc};
              __.current = value;
              return true;
            }
            else
            {
              __.acc = {Tag: 0.000000};
              __.current = null;
              return false;
            };
          });
          return (Option__IsSome$Int32_Int32(__.acc) && (function()
          {
            var _195;
            return next(_195);
          })());
        })(impl, unitVar1);
      }), Reset: (function(unitVar1)
      {
        return (function(__,unitVar1)
        {
          __.acc = {Tag: 1.000000, Value: __.seed};
          __.current = null;
        })(impl, unitVar1);
      })};
    }));
  });
  TupleCountry__JQuery_ = (function(Item0,Item1)
  {
    var __this = this;
    __this.Items = [Item0, Item1];
    __this.Items = [Item0, Item1];
  });
  TupleFSharpFunc_2_IEnumerable_1_Tuple_2_Int32__Double__Unit__FSharpFunc_2_Exception__Unit__FSharpFunc_2_String__Unit_ = (function(Item0,Item1,Item2)
  {
    var __this = this;
    __this.Items = [Item0, Item1, Item2];
    __this.Items = [Item0, Item1, Item2];
    __this.Items = [Item0, Item1, Item2];
  });
  TupleHighchartsDataPoint__IEnumerator_1_Tuple_2_Int32__Double_ = (function(Item0,Item1)
  {
    var __this = this;
    __this.Items = [Item0, Item1];
    __this.Items = [Item0, Item1];
  });
  TupleIJsonDocument__Int32 = (function(Item0,Item1)
  {
    var __this = this;
    __this.Items = [Item0, Item1];
    __this.Items = [Item0, Item1];
  });
  TupleInt32_Double = (function(Item0,Item1)
  {
    var __this = this;
    __this.Items = [Item0, Item1];
    __this.Items = [Item0, Item1];
  });
  TupleString_FSharpList_1_String_ = (function(Item0,Item1)
  {
    var __this = this;
    __this.Items = [Item0, Item1];
    __this.Items = [Item0, Item1];
  });
  TupleString_String = (function(Item0,Item1)
  {
    var __this = this;
    __this.Items = [Item0, Item1];
    __this.Items = [Item0, Item1];
  });
  TupleTuple_2_Country__JQuery__Int32 = (function(Item0,Item1)
  {
    var __this = this;
    __this.Items = [Item0, Item1];
    __this.Items = [Item0, Item1];
  });
  TupleTuple_2_Int32__Double__IEnumerator_1_IJsonDocument_ = (function(Item0,Item1)
  {
    var __this = this;
    __this.Items = [Item0, Item1];
    __this.Items = [Item0, Item1];
  });
  UnfoldEnumerator_2_FSharpList_1_String__String___ctor$FSharpList_1_String__String = (function(seed,unfold)
  {
    var __this = this;
    __this.seed = seed;
    __this.unfold = unfold;
    __this.acc = {Tag: 1.000000, Value: __this.seed};
    __this.current = null;
  });
  UnfoldEnumerator_2_IEnumerator_1_IJsonDocument__Tuple_2_Int32__Double___ctor$IEnumerator_1_IJsonDocument__Tuple_2_Int32__Double_ = (function(seed,unfold)
  {
    var __this = this;
    __this.seed = seed;
    __this.unfold = unfold;
    __this.acc = {Tag: 1.000000, Value: __this.seed};
    __this.current = null;
  });
  UnfoldEnumerator_2_IEnumerator_1_Tuple_2_Int32__Double__HighchartsDataPoint___ctor$IEnumerator_1_Tuple_2_Int32__Double__HighchartsDataPoint_ = (function(seed,unfold)
  {
    var __this = this;
    __this.seed = seed;
    __this.unfold = unfold;
    __this.acc = {Tag: 1.000000, Value: __this.seed};
    __this.current = null;
  });
  UnfoldEnumerator_2_Int32__IJsonDocument___ctor$Int32_IJsonDocument_ = (function(seed,unfold)
  {
    var __this = this;
    __this.seed = seed;
    __this.unfold = unfold;
    __this.acc = {Tag: 1.000000, Value: __this.seed};
    __this.current = null;
  });
  UnfoldEnumerator_2_Int32__Tuple_2_Country__JQuery___ctor$Int32_Tuple_2_Country__JQuery_ = (function(seed,unfold)
  {
    var __this = this;
    __this.seed = seed;
    __this.unfold = unfold;
    __this.acc = {Tag: 1.000000, Value: __this.seed};
    __this.current = null;
  });
  Utils__encodeURIComponent$ = (function(s)
  {
    return encodeURIComponent(s);;
  });
  Utils__getJSONPrefix$ = (function(url,callback)
  {
    
  $.ajax({
    url: url,
    dataType: 'jsonp',
    jsonp: 'prefix',
    jsonpCallback: 'prefix',
    error: function(jqXHR, textStatus, errorThrown){
        console.log(textStatus + errorThrown);
    },
    success: function(data){
        callback(data);
    }
  });
;
  });
  WorldBankCountry___ctor$ = (function(Context,Code,Name)
  {
    var __this = this;
    __this.Context = Context;
    __this.Code = Code;
    __this.Name = Name;
  });
  WorldBankRuntime__AsyncGetIndicator$ = (function(country,indicator)
  {
    return Async__FromContinuations$IEnumerable_1_Tuple_2_Int32__Double_IEnumerable_1_Tuple_2_Int32__Double_((function(tupledArg)
    {
      var cont = tupledArg.Items[0.000000];
      var econt = tupledArg.Items[1.000000];
      var ccont = tupledArg.Items[2.000000];
      var wb = country.Context;
      var countryCode = country.Code;
      var url = Runtime__worldBankUrl$(wb, List__CreateCons$String_String("countries", List__CreateCons$String_String(countryCode, List__CreateCons$String_String("indicators", List__CreateCons$String_String(indicator, List__Empty$String_String())))), List__CreateCons$Tuple_2_String__String_Tuple_2_String__String_((new TupleString_String("date", "1900:2050")), List__CreateCons$Tuple_2_String__String_Tuple_2_String__String_((new TupleString_String("format", "jsonp")), List__Empty$Tuple_2_String__String_Tuple_2_String__String_())));
      return Utils__getJSONPrefix$(url, (function(json)
      {
        var data = JsRuntime__Identity1Of2$(JsRuntime__Identity$(json), "");
        var chooser = (function(v)
        {
          if (JsHelpers__isNull$(JsRuntime__Identity2Of2$("", JsRuntime__TryGetProperty$(v, "value")))) 
          {
            return {Tag: 0.000000};
          }
          else
          {
            var value = JsRuntime__TryGetProperty$(v, "date");
            return {Tag: 1.000000, Value: (new TupleInt32_Double(JsRuntime__GetNonOptionalValue$(JsRuntime__EmptyString$(value), JsRuntime__Identity2Of2$("", JsRuntime__Identity$(value)), JsRuntime__Identity$(value)), Option__GetValue$Decimal_Decimal(JsRuntime__Identity2Of2$("", JsRuntime__TryGetProperty$(v, "value")))))};
          };
        });
        var res = (function(source)
        {
          return Seq__Choose$IJsonDocument__Tuple_2_Int32__Double_IJsonDocument__Tuple_2_Int32__Double_(chooser, Seq__OfArray$IJsonDocument_IJsonDocument_(source));
        })(JsRuntime__ConvertArray$IJsonDocument_IJsonDocument_(JsRuntime__GetArrayChildByTypeTag$(data, "", "Array"), (function(t)
        {
          return t;
        })));
        return cont(res);
      }));
    }));
  });
  WorldBankRuntime__GetCountries$ = (function(data)
  {
    return data;
  });
  WorldBankRuntime__GetCountry$ = (function(countries,code,name)
  {
    return (new WorldBankCountry___ctor$(countries, code, name));
  });
  WorldBankRuntime__GetIndicators$ = (function(country)
  {
    return country;
  });
  list_1_String__ConsString = (function(Item1,Item2)
  {
    var __this = this;
    __this.Tag = 1.000000;
    __this._CaseName = "Cons";
    __this.Item1 = Item1;
    __this.Item2 = Item2;
  });
  list_1_String__NilString = (function()
  {
    var __this = this;
    __this.Tag = 0.000000;
    __this._CaseName = "Nil";
  });
  list_1_Tuple_2_String__String__ConsTuple_2_String__String_ = (function(Item1,Item2)
  {
    var __this = this;
    __this.Tag = 1.000000;
    __this._CaseName = "Cons";
    __this.Item1 = Item1;
    __this.Item2 = Item2;
  });
  list_1_Tuple_2_String__String__NilTuple_2_String__String_ = (function()
  {
    var __this = this;
    __this.Tag = 0.000000;
    __this._CaseName = "Nil";
  });
  Program__data = Program__get_data$();
  return Program__main$()
});