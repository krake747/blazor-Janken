using BlazorJanken.Components.Enums;

namespace BlazorJanken.Components.Models;

public readonly record struct RoundResult(GameState State, Shape Player, Shape Computer);