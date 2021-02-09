#include "libllvm-c/DxilBindings.h"
#include <dxc/Support/WinIncludes.h>
#include <dxc/DXIL/DxilOperations.h>
#include <llvm/IR/IntrinsicInst.h>
#include <llvm/IR/AssemblyAnnotationWriter.h>
#include <llvm/IR/DebugInfoMetadata.h>
#include <llvm/Support/FormattedStream.h>
#include <dxc/DXIL/DxilInstructions.h>
#include <dxc/DXIL/DxilResourceProperties.h>

using namespace llvm;
using namespace hlsl;
using namespace hlsl::DXIL;
/* <py::lines('OPCODE-SIGS')>hctdb_instrhelp.get_opsigs()</py>*/
// OPCODE-SIGS:BEGIN
static const char *OpCodeSignatures[] =
    {
        "(index)",                                       // TempRegLoad
        "(index,value)",                                 // TempRegStore
        "(regIndex,index,component)",                    // MinPrecXRegLoad
        "(regIndex,index,component,value)",              // MinPrecXRegStore
        "(inputSigId,rowIndex,colIndex,gsVertexAxis)",   // LoadInput
        "(outputSigId,rowIndex,colIndex,value)",         // StoreOutput
        "(value)",                                       // FAbs
        "(value)",                                       // Saturate
        "(value)",                                       // IsNaN
        "(value)",                                       // IsInf
        "(value)",                                       // IsFinite
        "(value)",                                       // IsNormal
        "(value)",                                       // Cos
        "(value)",                                       // Sin
        "(value)",                                       // Tan
        "(value)",                                       // Acos
        "(value)",                                       // Asin
        "(value)",                                       // Atan
        "(value)",                                       // Hcos
        "(value)",                                       // Hsin
        "(value)",                                       // Htan
        "(value)",                                       // Exp
        "(value)",                                       // Frc
        "(value)",                                       // Log
        "(value)",                                       // Sqrt
        "(value)",                                       // Rsqrt
        "(value)",                                       // Round_ne
        "(value)",                                       // Round_ni
        "(value)",                                       // Round_pi
        "(value)",                                       // Round_z
        "(value)",                                       // Bfrev
        "(value)",                                       // Countbits
        "(value)",                                       // FirstbitLo
        "(value)",                                       // FirstbitHi
        "(value)",                                       // FirstbitSHi
        "(a,b)",                                         // FMax
        "(a,b)",                                         // FMin
        "(a,b)",                                         // IMax
        "(a,b)",                                         // IMin
        "(a,b)",                                         // UMax
        "(a,b)",                                         // UMin
        "(a,b)",                                         // IMul
        "(a,b)",                                         // UMul
        "(a,b)",                                         // UDiv
        "(a,b)",                                         // UAddc
        "(a,b)",                                         // USubb
        "(a,b,c)",                                       // FMad
        "(a,b,c)",                                       // Fma
        "(a,b,c)",                                       // IMad
        "(a,b,c)",                                       // UMad
        "(a,b,c)",                                       // Msad
        "(a,b,c)",                                       // Ibfe
        "(a,b,c)",                                       // Ubfe
        "(width,offset,value,replacedValue)",            // Bfi
        "(ax,ay,bx,by)",                                 // Dot2
        "(ax,ay,az,bx,by,bz)",                           // Dot3
        "(ax,ay,az,aw,bx,by,bz,bw)",                     // Dot4
        "(resourceClass,rangeId,index,nonUniformIndex)", // CreateHandle
        "(handle,byteOffset,alignment)",                 // CBufferLoad
        "(handle,regIndex)",                             // CBufferLoadLegacy
        "(srv,sampler,coord0,coord1,coord2,coord3,offset0,offset1,offset2,"
        "clamp)", // Sample
        "(srv,sampler,coord0,coord1,coord2,coord3,offset0,offset1,offset2,bias,"
        "clamp)", // SampleBias
        "(srv,sampler,coord0,coord1,coord2,coord3,offset0,offset1,offset2,LOD)", // SampleLevel
        "(srv,sampler,coord0,coord1,coord2,coord3,offset0,offset1,offset2,ddx0,"
        "ddx1,ddx2,ddy0,ddy1,ddy2,clamp)", // SampleGrad
        "(srv,sampler,coord0,coord1,coord2,coord3,offset0,offset1,offset2,"
        "compareValue,clamp)", // SampleCmp
        "(srv,sampler,coord0,coord1,coord2,coord3,offset0,offset1,offset2,"
        "compareValue)", // SampleCmpLevelZero
        "(srv,mipLevelOrSampleCount,coord0,coord1,coord2,offset0,offset1,"
        "offset2)", // TextureLoad
        "(srv,coord0,coord1,coord2,value0,value1,value2,value3,mask)", // TextureStore
        "(srv,index,wot)",                                      // BufferLoad
        "(uav,coord0,coord1,value0,value1,value2,value3,mask)", // BufferStore
        "(uav,inc)",         // BufferUpdateCounter
        "(status)",          // CheckAccessFullyMapped
        "(handle,mipLevel)", // GetDimensions
        "(srv,sampler,coord0,coord1,coord2,coord3,offset0,offset1,channel)", // TextureGather
        "(srv,sampler,coord0,coord1,coord2,coord3,offset0,offset1,channel,"
        "compareVale)", // TextureGatherCmp
        "(srv,index)",  // Texture2DMSGetSamplePosition
        "(index)",      // RenderTargetGetSamplePosition
        "()",           // RenderTargetGetSampleCount
        "(handle,atomicOp,offset0,offset1,offset2,newValue)", // AtomicBinOp
        "(handle,offset0,offset1,offset2,compareValue,newValue)", // AtomicCompareExchange
        "(barrierMode)",                                          // Barrier
        "(handle,sampler,coord0,coord1,coord2,clamped)", // CalculateLOD
        "(condition)",                                   // Discard
        "(value)",                                       // DerivCoarseX
        "(value)",                                       // DerivCoarseY
        "(value)",                                       // DerivFineX
        "(value)",                                       // DerivFineY
        "(inputSigId,inputRowIndex,inputColIndex,offsetX,offsetY)", // EvalSnapped
        "(inputSigId,inputRowIndex,inputColIndex,sampleIndex)", // EvalSampleIndex
        "(inputSigId,inputRowIndex,inputColIndex)",             // EvalCentroid
        "()",                                                   // SampleIndex
        "()",                                                   // Coverage
        "()",                                                   // InnerCoverage
        "(component)",                                          // ThreadId
        "(component)",                                          // GroupId
        "(component)",                 // ThreadIdInGroup
        "()",                          // FlattenedThreadIdInGroup
        "(streamId)",                  // EmitStream
        "(streamId)",                  // CutStream
        "(streamId)",                  // EmitThenCutStream
        "()",                          // GSInstanceID
        "(lo,hi)",                     // MakeDouble
        "(value)",                     // SplitDouble
        "(inputSigId,row,col,index)",  // LoadOutputControlPoint
        "(inputSigId,row,col)",        // LoadPatchConstant
        "(component)",                 // DomainLocation
        "(outputSigID,row,col,value)", // StorePatchConstant
        "()",                          // OutputControlPointID
        "()",                          // PrimitiveID
        "()",                          // CycleCounterLegacy
        "()",                          // WaveIsFirstLane
        "()",                          // WaveGetLaneIndex
        "()",                          // WaveGetLaneCount
        "(cond)",                      // WaveAnyTrue
        "(cond)",                      // WaveAllTrue
        "(value)",                     // WaveActiveAllEqual
        "(cond)",                      // WaveActiveBallot
        "(value,lane)",                // WaveReadLaneAt
        "(value)",                     // WaveReadLaneFirst
        "(value,op,sop)",              // WaveActiveOp
        "(value,op)",                  // WaveActiveBit
        "(value,op,sop)",              // WavePrefixOp
        "(value,quadLane)",            // QuadReadLaneAt
        "(value,op)",                  // QuadOp
        "(value)",                     // BitcastI16toF16
        "(value)",                     // BitcastF16toI16
        "(value)",                     // BitcastI32toF32
        "(value)",                     // BitcastF32toI32
        "(value)",                     // BitcastI64toF64
        "(value)",                     // BitcastF64toI64
        "(value)",                     // LegacyF32ToF16
        "(value)",                     // LegacyF16ToF32
        "(value)",                     // LegacyDoubleToFloat
        "(value)",                     // LegacyDoubleToSInt32
        "(value)",                     // LegacyDoubleToUInt32
        "(value)",                     // WaveAllBitCount
        "(value)",                     // WavePrefixBitCount
        "(inputSigId,inputRowIndex,inputColIndex,VertexID)", // AttributeAtVertex
        "()",                                                // ViewID
        "(srv,index,elementOffset,mask,alignment)",          // RawBufferLoad
        "(uav,index,elementOffset,value0,value1,value2,value3,mask,alignment)", // RawBufferStore
        "()",        // InstanceID
        "()",        // InstanceIndex
        "()",        // HitKind
        "()",        // RayFlags
        "(col)",     // DispatchRaysIndex
        "(col)",     // DispatchRaysDimensions
        "(col)",     // WorldRayOrigin
        "(col)",     // WorldRayDirection
        "(col)",     // ObjectRayOrigin
        "(col)",     // ObjectRayDirection
        "(row,col)", // ObjectToWorld
        "(row,col)", // WorldToObject
        "()",        // RayTMin
        "()",        // RayTCurrent
        "()",        // IgnoreHit
        "()",        // AcceptHitAndEndSearch
        "(AccelerationStructure,RayFlags,InstanceInclusionMask,"
        "RayContributionToHitGroupIndex,"
        "MultiplierForGeometryContributionToShaderIndex,MissShaderIndex,Origin_"
        "X,Origin_Y,Origin_Z,TMin,Direction_X,Direction_Y,Direction_Z,TMax,"
        "payload)",                               // TraceRay
        "(THit,HitKind,Attributes)",              // ReportHit
        "(ShaderIndex,Parameter)",                // CallShader
        "(Resource)",                             // CreateHandleForLib
        "()",                                     // PrimitiveIndex
        "(acc,ax,ay,bx,by)",                      // Dot2AddHalf
        "(acc,a,b)",                              // Dot4AddI8Packed
        "(acc,a,b)",                              // Dot4AddU8Packed
        "(value)",                                // WaveMatch
        "(value,mask0,mask1,mask2,mask3,op,sop)", // WaveMultiPrefixOp
        "(value,mask0,mask1,mask2,mask3)",        // WaveMultiPrefixBitCount
        "(numVertices,numPrimitives)",            // SetMeshOutputCounts
        "(PrimitiveIndex,VertexIndex0,VertexIndex1,VertexIndex2)", // EmitIndices
        "()",                                                // GetMeshPayload
        "(outputSigId,rowIndex,colIndex,value,vertexIndex)", // StoreVertexOutput
        "(outputSigId,rowIndex,colIndex,value,primitiveIndex)", // StorePrimitiveOutput
        "(threadGroupCountX,threadGroupCountY,threadGroupCountZ,payload)", // DispatchMesh
        "(feedbackTex,sampledTex,sampler,c0,c1,c2,c3,clamp)", // WriteSamplerFeedback
        "(feedbackTex,sampledTex,sampler,c0,c1,c2,c3,bias,clamp)", // WriteSamplerFeedbackBias
        "(feedbackTex,sampledTex,sampler,c0,c1,c2,c3,lod)", // WriteSamplerFeedbackLevel
        "(feedbackTex,sampledTex,sampler,c0,c1,c2,c3,ddx0,ddx1,ddx2,ddy0,ddy1,"
        "ddy2,clamp)",     // WriteSamplerFeedbackGrad
        "(constRayFlags)", // AllocateRayQuery
        "(rayQueryHandle,accelerationStructure,rayFlags,instanceInclusionMask,"
        "origin_X,origin_Y,origin_Z,tMin,direction_X,direction_Y,direction_Z,"
        "tMax)",                    // RayQuery_TraceRayInline
        "(rayQueryHandle)",         // RayQuery_Proceed
        "(rayQueryHandle)",         // RayQuery_Abort
        "(rayQueryHandle)",         // RayQuery_CommitNonOpaqueTriangleHit
        "(rayQueryHandle,t)",       // RayQuery_CommitProceduralPrimitiveHit
        "(rayQueryHandle)",         // RayQuery_CommittedStatus
        "(rayQueryHandle)",         // RayQuery_CandidateType
        "(rayQueryHandle,row,col)", // RayQuery_CandidateObjectToWorld3x4
        "(rayQueryHandle,row,col)", // RayQuery_CandidateWorldToObject3x4
        "(rayQueryHandle,row,col)", // RayQuery_CommittedObjectToWorld3x4
        "(rayQueryHandle,row,col)", // RayQuery_CommittedWorldToObject3x4
        "(rayQueryHandle)", // RayQuery_CandidateProceduralPrimitiveNonOpaque
        "(rayQueryHandle)", // RayQuery_CandidateTriangleFrontFace
        "(rayQueryHandle)", // RayQuery_CommittedTriangleFrontFace
        "(rayQueryHandle,component)", // RayQuery_CandidateTriangleBarycentrics
        "(rayQueryHandle,component)", // RayQuery_CommittedTriangleBarycentrics
        "(rayQueryHandle)",           // RayQuery_RayFlags
        "(rayQueryHandle,component)", // RayQuery_WorldRayOrigin
        "(rayQueryHandle,component)", // RayQuery_WorldRayDirection
        "(rayQueryHandle)",           // RayQuery_RayTMin
        "(rayQueryHandle)",           // RayQuery_CandidateTriangleRayT
        "(rayQueryHandle)",           // RayQuery_CommittedRayT
        "(rayQueryHandle)",           // RayQuery_CandidateInstanceIndex
        "(rayQueryHandle)",           // RayQuery_CandidateInstanceID
        "(rayQueryHandle)",           // RayQuery_CandidateGeometryIndex
        "(rayQueryHandle)",           // RayQuery_CandidatePrimitiveIndex
        "(rayQueryHandle,component)", // RayQuery_CandidateObjectRayOrigin
        "(rayQueryHandle,component)", // RayQuery_CandidateObjectRayDirection
        "(rayQueryHandle)",           // RayQuery_CommittedInstanceIndex
        "(rayQueryHandle)",           // RayQuery_CommittedInstanceID
        "(rayQueryHandle)",           // RayQuery_CommittedGeometryIndex
        "(rayQueryHandle)",           // RayQuery_CommittedPrimitiveIndex
        "(rayQueryHandle,component)", // RayQuery_CommittedObjectRayOrigin
        "(rayQueryHandle,component)", // RayQuery_CommittedObjectRayDirection
        "()",                         // GeometryIndex
        "(rayQueryHandle)", // RayQuery_CandidateInstanceContributionToHitGroupIndex
        "(rayQueryHandle)", // RayQuery_CommittedInstanceContributionToHitGroupIndex
        "(res,props)",      // AnnotateHandle
        "(bind,index,nonUniformIndex)",        // CreateHandleFromBinding
        "(index,samplerHeap,nonUniformIndex)", // CreateHandleFromHeap
        "(unpackMode,pk)",                     // Unpack4x8
        "(packMode,x,y,z,w)"                   // Pack4x8
};
// OPCODE-SIGS:END
LPCSTR ResourceKindToString(DXIL::ResourceKind RK) {
  switch (RK)
  {
  case DXIL::ResourceKind::Texture1D: return "Texture1D";
  case DXIL::ResourceKind::Texture2D: return "Texture2D";
  case DXIL::ResourceKind::Texture2DMS: return "Texture2DMS";
  case DXIL::ResourceKind::Texture3D: return "Texture3D";
  case DXIL::ResourceKind::TextureCube: return "TextureCube";
  case DXIL::ResourceKind::Texture1DArray: return "Texture1DArray";
  case DXIL::ResourceKind::Texture2DArray: return "Texture2DArray";
  case DXIL::ResourceKind::Texture2DMSArray: return "Texture2DMSArray";
  case DXIL::ResourceKind::TextureCubeArray: return "TextureCubeArray";
  case DXIL::ResourceKind::TypedBuffer: return "TypedBuffer";
  case DXIL::ResourceKind::RawBuffer: return "ByteAddressBuffer";
  case DXIL::ResourceKind::StructuredBuffer: return "StructuredBuffer";
  case DXIL::ResourceKind::CBuffer: return "CBuffer";
  case DXIL::ResourceKind::Sampler: return "Sampler";
  case DXIL::ResourceKind::TBuffer: return "TBuffer";
  case DXIL::ResourceKind::RTAccelerationStructure: return "RTAccelerationStructure";
  case DXIL::ResourceKind::FeedbackTexture2D: return "FeedbackTexture2D";
  case DXIL::ResourceKind::FeedbackTexture2DArray: return "FeedbackTexture2DArray";
  default:
    return "<invalid ResourceKind>";
  }
}
LPCSTR CompTypeToString(DXIL::ComponentType CompType) {
    switch (CompType) {
    case DXIL::ComponentType::I1: return "I1";
    case DXIL::ComponentType::I16: return "I16";
    case DXIL::ComponentType::U16: return "U16";
    case DXIL::ComponentType::I32: return "I32";
    case DXIL::ComponentType::U32: return "U32";
    case DXIL::ComponentType::I64: return "I64";
    case DXIL::ComponentType::U64: return "U64";
    case DXIL::ComponentType::F16: return "F16";
    case DXIL::ComponentType::F32: return "F32";
    case DXIL::ComponentType::F64: return "F64";
    case DXIL::ComponentType::SNormF16: return "SNormF16";
    case DXIL::ComponentType::UNormF16: return "UNormF16";
    case DXIL::ComponentType::SNormF32: return "SNormF32";
    case DXIL::ComponentType::UNormF32: return "UNormF32";
    case DXIL::ComponentType::SNormF64: return "SNormF64";
    case DXIL::ComponentType::UNormF64: return "UNormF64";
    default:
        return "<invalid CompType>";
    }
}
LPCSTR SamplerFeedbackTypeToString(DXIL::SamplerFeedbackType SFT) {
    switch (SFT) {
    case DXIL::SamplerFeedbackType::MinMip: return "MinMip";
    case DXIL::SamplerFeedbackType::MipRegionUsed: return "MipRegionUsed";
    default:
        return "<invalid sampler feedback type>";
    }
}
void PrintResourceProperties(DxilResourceProperties &RP,
                             formatted_raw_ostream &OS) {
  OS << "  resource: ";

  if (RP.getResourceClass() == DXIL::ResourceClass::CBuffer) {
    OS << "CBuffer";
    return;
  } else if (RP.getResourceClass() == DXIL::ResourceClass::SRV &&
             RP.getResourceKind() == DXIL::ResourceKind::TBuffer) {
    OS << "TBuffer";
    return;
  }

  if (RP.getResourceClass() == DXIL::ResourceClass::Sampler) {
    if (!RP.Basic.SamplerCmpOrHasCounter)
      OS << "SamplerState";
    else
      OS << "SamplerComparisonState";
    return;
  }

  bool bUAV = RP.isUAV();
  LPCSTR RW = bUAV ? (RP.Basic.IsROV ? "ROV" : "RW") : "";
  LPCSTR GC = bUAV && RP.Basic.IsGloballyCoherent ? "globallycoherent " : "";
  LPCSTR COUNTER = bUAV && RP.Basic.SamplerCmpOrHasCounter ? ", counter" : "";

  switch (RP.getResourceKind()) {
  case DXIL::ResourceKind::Texture1D:
  case DXIL::ResourceKind::Texture2D:
  case DXIL::ResourceKind::Texture3D:
  case DXIL::ResourceKind::TextureCube:
  case DXIL::ResourceKind::Texture1DArray:
  case DXIL::ResourceKind::Texture2DArray:
  case DXIL::ResourceKind::TextureCubeArray:
  case DXIL::ResourceKind::TypedBuffer:
    OS << GC << RW << ResourceKindToString(RP.getResourceKind());
    OS << "<" << CompTypeToString(RP.getCompType())
       << (bUAV && RP.Typed.CompCount > 1 ? "[vec]" : "") << ">";
    break;

  case DXIL::ResourceKind::Texture2DMS:
  case DXIL::ResourceKind::Texture2DMSArray:
    OS << ResourceKindToString(RP.getResourceKind());
    OS << "<" << CompTypeToString(RP.getCompType()) << ">";
    break;

  case DXIL::ResourceKind::RawBuffer:
    OS << GC << RW << ResourceKindToString(RP.getResourceKind());
    break;

  case DXIL::ResourceKind::StructuredBuffer:
    OS << GC << RW << ResourceKindToString(RP.getResourceKind());
    OS << "<stride=" << RP.StructStrideInBytes << COUNTER << ">";
    break;

  case DXIL::ResourceKind::RTAccelerationStructure:
    OS << ResourceKindToString(RP.getResourceKind());
    break;

  case DXIL::ResourceKind::FeedbackTexture2D:
  case DXIL::ResourceKind::FeedbackTexture2DArray:
    OS << ResourceKindToString(RP.getResourceKind());
    OS << "<" << SamplerFeedbackTypeToString(RP.SamplerFeedbackType) << ">";
    break;

  default:
    OS << "<invalid resource properties>";
    break;
  }
}
class DxcAssemblyAnnotationWriter : public llvm::AssemblyAnnotationWriter {
public:
    ~DxcAssemblyAnnotationWriter() {}
    void printInfoComment(const Value& V, formatted_raw_ostream& OS) override {
        if (const Instruction* I = dyn_cast<Instruction>(&V)) {
            if (isa<DbgInfoIntrinsic>(I)) {
                DILocalVariable* Var = nullptr;
                DIExpression* Expr = nullptr;
                if (const DbgDeclareInst* DI = dyn_cast<DbgDeclareInst>(I)) {
                    Var = DI->getVariable();
                    Expr = DI->getExpression();
                }
                else if (const DbgValueInst* DI = dyn_cast<DbgValueInst>(I)) {
                    Var = DI->getVariable();
                    Expr = DI->getExpression();
                }

                if (Var && Expr) {
                    OS << " ; var:\"" << Var->getName() << "\"" << " ";
                    Expr->printAsBody(OS);
                }
            }
            else {
                DebugLoc Loc = I->getDebugLoc();
                if (Loc && Loc.getLine() != 0)
                    OS << " ; line:" << Loc.getLine() << " col:" << Loc.getCol();
            }
        }
        const CallInst* CI = dyn_cast<const CallInst>(&V);
        if (!CI) {
            return;
        }
        // TODO: annotate high-level operations where possible as well
        if (CI->getNumArgOperands() == 0 ||
            !CI->getCalledFunction()->getName().startswith("dx.op.")) {
            return;
        }
        const ConstantInt* CInt = dyn_cast<const ConstantInt>(CI->getArgOperand(0));
        if (!CInt) {
            // At this point, we know this is malformed; ignore.
            return;
        }

        unsigned opcodeVal = CInt->getZExtValue();
        if (opcodeVal >= (unsigned)DXIL::OpCode::NumOpCodes) {
            OS << "  ; invalid DXIL opcode #" << opcodeVal;
            return;
        }

        // TODO: if an argument references a resource, look it up and write the
        // name/binding
        DXIL::OpCode opcode = (DXIL::OpCode)opcodeVal;
        OS << "  ; " << hlsl::OP::GetOpCodeName(opcode)
            << OpCodeSignatures[opcodeVal];

        // Add extra decoding for certain ops
        switch (opcode) {
        case DXIL::OpCode::AnnotateHandle: {
            // Decode resource properties
            DxilInst_AnnotateHandle AH(const_cast<CallInst*>(CI));
            if (Constant* Props = dyn_cast<Constant>(AH.get_props())) {
                DxilResourceProperties RP = resource_helper::loadPropsFromConstant(*Props);
                PrintResourceProperties(RP, OS);
            }
        } break;
        default:
            break;
        }
    }
};

extern "C"
{
    char const* LibLLVMPrintModuleToStringWithDxcAssemblyAnnotationWriter(LLVMModuleRef M) {
        std::string buf;
        raw_string_ostream os(buf);

        DxcAssemblyAnnotationWriter w;
        unwrap(M)->print(os, &w);
        os.flush();

        return strdup(buf.c_str());
    }
}
