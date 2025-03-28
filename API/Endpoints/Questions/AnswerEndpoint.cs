using API.Extensions;
using API.RequestModels.Questions;
using API.ResponseModels.Questions;
using Application.CQRS.Questions.Commands;
using FastEndpoints;
using MediatR;

namespace API.Endpoints.Questions;

public class AnswerEndpoint(IMediator mediator):Endpoint<AnswerRequest, AnswerResponse>
{
    public override void Configure()
    {
        Post("/answer");
        AllowAnonymous();
    }

    public override async Task HandleAsync(AnswerRequest request, CancellationToken cancellationToken)
    {
        var result =
            await mediator.Send(
                                new AnswerCommand(request.InterviewId, request.QuestionId, request.AnswerId),
                                cancellationToken);

        await this.SendResponse(result, static result => new AnswerResponse(result));
    }
}