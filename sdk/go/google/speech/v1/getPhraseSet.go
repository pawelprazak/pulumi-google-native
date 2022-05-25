// Code generated by the Pulumi SDK Generator DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package v1

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Get a phrase set.
func LookupPhraseSet(ctx *pulumi.Context, args *LookupPhraseSetArgs, opts ...pulumi.InvokeOption) (*LookupPhraseSetResult, error) {
	var rv LookupPhraseSetResult
	err := ctx.Invoke("google-native:speech/v1:getPhraseSet", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupPhraseSetArgs struct {
	Location    string  `pulumi:"location"`
	PhraseSetId string  `pulumi:"phraseSetId"`
	Project     *string `pulumi:"project"`
}

type LookupPhraseSetResult struct {
	// Hint Boost. Positive value will increase the probability that a specific phrase will be recognized over other similar sounding phrases. The higher the boost, the higher the chance of false positive recognition as well. Negative boost values would correspond to anti-biasing. Anti-biasing is not enabled, so negative boost will simply be ignored. Though `boost` can accept a wide range of positive values, most use cases are best served with values between 0 (exclusive) and 20. We recommend using a binary search approach to finding the optimal value for your use case. Speech recognition will skip PhraseSets with a boost value of 0.
	Boost float64 `pulumi:"boost"`
	// The resource name of the phrase set.
	Name string `pulumi:"name"`
	// A list of word and phrases.
	Phrases []PhraseResponse `pulumi:"phrases"`
}

func LookupPhraseSetOutput(ctx *pulumi.Context, args LookupPhraseSetOutputArgs, opts ...pulumi.InvokeOption) LookupPhraseSetResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupPhraseSetResult, error) {
			args := v.(LookupPhraseSetArgs)
			r, err := LookupPhraseSet(ctx, &args, opts...)
			var s LookupPhraseSetResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(LookupPhraseSetResultOutput)
}

type LookupPhraseSetOutputArgs struct {
	Location    pulumi.StringInput    `pulumi:"location"`
	PhraseSetId pulumi.StringInput    `pulumi:"phraseSetId"`
	Project     pulumi.StringPtrInput `pulumi:"project"`
}

func (LookupPhraseSetOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupPhraseSetArgs)(nil)).Elem()
}

type LookupPhraseSetResultOutput struct{ *pulumi.OutputState }

func (LookupPhraseSetResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupPhraseSetResult)(nil)).Elem()
}

func (o LookupPhraseSetResultOutput) ToLookupPhraseSetResultOutput() LookupPhraseSetResultOutput {
	return o
}

func (o LookupPhraseSetResultOutput) ToLookupPhraseSetResultOutputWithContext(ctx context.Context) LookupPhraseSetResultOutput {
	return o
}

// Hint Boost. Positive value will increase the probability that a specific phrase will be recognized over other similar sounding phrases. The higher the boost, the higher the chance of false positive recognition as well. Negative boost values would correspond to anti-biasing. Anti-biasing is not enabled, so negative boost will simply be ignored. Though `boost` can accept a wide range of positive values, most use cases are best served with values between 0 (exclusive) and 20. We recommend using a binary search approach to finding the optimal value for your use case. Speech recognition will skip PhraseSets with a boost value of 0.
func (o LookupPhraseSetResultOutput) Boost() pulumi.Float64Output {
	return o.ApplyT(func(v LookupPhraseSetResult) float64 { return v.Boost }).(pulumi.Float64Output)
}

// The resource name of the phrase set.
func (o LookupPhraseSetResultOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v LookupPhraseSetResult) string { return v.Name }).(pulumi.StringOutput)
}

// A list of word and phrases.
func (o LookupPhraseSetResultOutput) Phrases() PhraseResponseArrayOutput {
	return o.ApplyT(func(v LookupPhraseSetResult) []PhraseResponse { return v.Phrases }).(PhraseResponseArrayOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupPhraseSetResultOutput{})
}