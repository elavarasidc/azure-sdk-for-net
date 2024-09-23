private static IEnumerable<object?[]> TestData_PlayOperationsAsync()
        {
            return new[]
            {
                new object?[]
                {
                   new Func<CallMedia, Task<Response<PlayResult>>>(callMedia => callMedia.PlayAsync(_fileOptions))
                },
                new object?[]
                {
                   new Func<CallMedia, Task<Response<PlayResult>>>(callMedia => callMedia.PlayToAllAsync(_filePlayToAllOptions))
                }
            };
        }

        private static IEnumerable<object?[]> TestData_CancelOperationsAsync()
        {
            return new[]
            {
                new object?[]
                {
                   new Func<CallMedia, Task<Response<CancelAllMediaOperationsResult>>>(callMedia => callMedia.CancelAllMediaOperationsAsync())
                },
            };
        }

        private static IEnumerable<object?[]> TestData_RecognizeOperationsAsync()
        {
            return new[]
            {
                new object?[]
                {
                   new Func<CallMedia, Task<Response<StartRecognizingCallMediaResult>>>(callMedia => callMedia.StartRecognizingAsync(_dmtfRecognizeOptions))
                },
                new object?[]
                {
                   new Func<CallMedia, Task<Response<StartRecognizingCallMediaResult>>>(callMedia => callMedia.StartRecognizingAsync(_emptyRecognizeOptions))
                }
            };
        }

        private static IEnumerable<object?[]> TestData_PlayOperations()
        {
            return new[]
            {
                new object?[]
                {
                   new Func<CallMedia, Response<PlayResult>>(callMedia => callMedia.Play(_fileOptions))
                },
                new object?[]
                {
                   new Func<CallMedia, Response<PlayResult>>(callMedia => callMedia.PlayToAll(_filePlayToAllOptions))
                },
            };
        }

        private static IEnumerable<object?[]> TestData_CancelOperations()
        {
            return new[]
            {
                new object?[]
                {
                   new Func<CallMedia, Response<CancelAllMediaOperationsResult>>(callMedia => callMedia.CancelAllMediaOperations())
                },
            };
        }

        private static IEnumerable<object?[]> TestData_RecognizeOperations()
        {
            return new[]
            {
                new object?[]
                {
                   new Func<CallMedia, Response<StartRecognizingCallMediaResult>>(callMedia => callMedia.StartRecognizing(_dmtfRecognizeOptions))
                },
                new object?[]
                {
                   new Func<CallMedia, Response<StartRecognizingCallMediaResult>>(callMedia => callMedia.StartRecognizing(_emptyRecognizeOptions))
                }
            };
        }