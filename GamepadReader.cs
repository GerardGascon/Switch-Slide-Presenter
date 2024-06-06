﻿namespace SwitchSlidePresenter;

public interface IGamepadReader {
	public event Action NextSlide;
	public event Action PrevSlide;

	public Task Read();
}