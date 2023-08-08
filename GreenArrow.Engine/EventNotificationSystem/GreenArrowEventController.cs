﻿using GreenArrow.Engine.Model.Events;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace GreenArrow.Engine.EventNotificationSystem
{
    /// <summary>
    /// /Controller to receive events generated by Green Arrow Event Notification System
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public sealed class GreenArrowEventController : ControllerBase
    {
        private readonly ILogger<GreenArrowEventController> _logger;
        private readonly IEventReceptor _eventReceptor;

        /// <summary>
        /// Create an instance of GreenArrowEventController
        /// </summary>
        public GreenArrowEventController(
            ILogger<GreenArrowEventController> logger,
            IEventReceptor eventReceptor
            )
        {
            _logger = logger;
            _eventReceptor = eventReceptor;
        }

        /// <summary>
        /// Receive Bounce All event
        /// </summary>
        [Route(nameof(EventType.BounceAll))]
        [HttpPost()]
        public async Task<IActionResult> PostBounceAll([FromBody] BounceAll bounceAll)
        {
            _logger.LogDebug("Green Arrow Event {GreenArrowEventType} received", EventType.BounceAll);

            await _eventReceptor.HandleAsync(bounceAll);

            _logger.LogDebug("Green Arrow Event {GreenArrowEventType} handled", EventType.BounceAll);

            return Ok();
        }

        /// <summary>
        /// Receive Bounce Bad Address event
        /// </summary>
        [Route(nameof(EventType.BounceBadAddress))]
        [HttpPost()]
        public async Task<IActionResult> PostBounceBadAddress([FromBody] BounceBadAddress bounceBadAddress)
        {
            _logger.LogDebug("Green Arrow Event {GreenArrowEventType} received", EventType.BounceBadAddress);

            await _eventReceptor.HandleAsync(bounceBadAddress);

            _logger.LogDebug("Green Arrow Event {GreenArrowEventType} handled", EventType.BounceBadAddress);

            return Ok();
        }

        /// <summary>
        /// Receive Delivery Attempt event
        /// </summary>
        [Route(nameof(EventType.DeliveryAttempt))]
        [HttpPost()]
        public async Task<IActionResult> PostDeliveryAttempt([FromBody] DeliveryAttempt deliveryAttempt)
        {
            _logger.LogDebug("Green Arrow Event {GreenArrowEventType} received", EventType.DeliveryAttempt);

            await _eventReceptor.HandleAsync(deliveryAttempt);

            _logger.LogDebug("Green Arrow Event {GreenArrowEventType} handled", EventType.DeliveryAttempt);

            return Ok();
        }

        /// <summary>
        /// Receive Click Tracking event
        /// </summary>
        [Route(nameof(EventType.EngineClick))]
        [HttpPost()]
        public async Task<IActionResult> PostClickTracking([FromBody] ClickTracking clickTracking)
        {
            _logger.LogDebug("Green Arrow Event {GreenArrowEventType} received", EventType.EngineClick);

            await _eventReceptor.HandleAsync(clickTracking);

            _logger.LogDebug("Green Arrow Event {GreenArrowEventType} handled", EventType.EngineClick);

            return Ok();
        }

        /// <summary>
        /// Receive Open Tracking event
        /// </summary>
        [Route(nameof(EventType.EngineOpen))]
        [HttpPost()]
        public async Task<IActionResult> PostOpenTracking([FromBody] OpenTracking openTracking)
        {
            _logger.LogDebug("Green Arrow Event {GreenArrowEventType} received", EventType.EngineOpen);

            await _eventReceptor.HandleAsync(openTracking);

            _logger.LogDebug("Green Arrow Event {GreenArrowEventType} handled", EventType.EngineOpen);

            return Ok();
        }

        /// <summary>
        /// Receive Spam Compaint event
        /// </summary>
        [Route(nameof(EventType.Scomp))]
        [HttpPost()]
        public async Task<IActionResult> PostSpamComplaint([FromBody] SpamComplaint spamComplaint)
        {
            _logger.LogDebug("Green Arrow Event {GreenArrowEventType} received", EventType.Scomp);

            await _eventReceptor.HandleAsync(spamComplaint);

            _logger.LogDebug("Green Arrow Event {GreenArrowEventType} handled", EventType.Scomp);

            return Ok();
        }

        /// <summary>
        /// Receive Unsubscribe event
        /// </summary>
        [Route(nameof(EventType.EngineUnsub))]
        [HttpPost()]
        public async Task<IActionResult> PostUnsubscribe([FromBody] Unsubscribe unsubscribe)
        {
            _logger.LogDebug("Green Arrow Event {GreenArrowEventType} received", EventType.EngineUnsub);

            await _eventReceptor.HandleAsync(unsubscribe);

            _logger.LogDebug("Green Arrow Event {GreenArrowEventType} handled", EventType.EngineUnsub);

            return Ok();
        }
    }
}